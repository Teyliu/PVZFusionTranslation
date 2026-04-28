using BepInEx;
using BepInEx.Configuration;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using TMPro;
using Unity.Burst.Intrinsics;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.UI;
using static PvZ_Fusion_Translator__BepInEx_.FileLoader;

namespace PvZ_Fusion_Translator__BepInEx_
{
    public class Utils
    {
        public static Dictionary<int, KeyValuePair<int, string>> plantIndices = new Dictionary<int, KeyValuePair<int, string>>();

        public static ZombieAlmanacData CachedZombieData = null;
        public static ZombieAlmanacData CachedModdedZombieData = null;
        public static bool ZombieDataCached = false;

        public static void CacheAlmanacData()
        {
            try
            {
                string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
                string zombiePath = Path.Combine(almanacDir, "ZombieStringsTranslate.json");
                string moddedZombiePath = Path.Combine(almanacDir, "ModdedZombiesTranslate.json");

                var jsonOptions = new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                if (File.Exists(zombiePath))
                {
                    string zombieJson = File.ReadAllText(zombiePath);
                    string cleanedZombieJson = ExtractFirstJsonObject(zombieJson);
                    CachedZombieData = System.Text.Json.JsonSerializer.Deserialize<ZombieAlmanacData>(cleanedZombieJson, jsonOptions);
                    Log.LogInfo($"Cached {CachedZombieData?.zombies?.Count ?? 0} zombie entries");
                }
                else
                {
                    Log.LogWarning($"ZombieStringsTranslate.json not found at: {zombiePath}");
                }

                if (File.Exists(moddedZombiePath))
                {
                    string moddedZombieJson = File.ReadAllText(moddedZombiePath);
                    string cleanedModdedJson = ExtractFirstJsonObject(moddedZombieJson);
                    CachedModdedZombieData = System.Text.Json.JsonSerializer.Deserialize<ZombieAlmanacData>(cleanedModdedJson, jsonOptions);
                    Log.LogInfo($"Cached {CachedModdedZombieData?.zombies?.Count ?? 0} modded zombie entries");
                }

                ZombieDataCached = true;
            }
            catch (Exception ex)
            {
                Log.LogError($"Error caching almanac data: {ex.Message}");
            }
        }

        public static void RegisterPlantIndices()
        {
            plantIndices = new Dictionary<int, KeyValuePair<int, string>>();
            string originalJson;
            string translatedJson;

            string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
            string dumpDir = GetAssetDir(AssetType.Dumps);
            string originalPath = Path.Combine(dumpDir, "LawnStrings.json");
            string path = Path.Combine(almanacDir, "LawnStringsTranslate.json");

            var jsonOptions = new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            if ((!File.Exists(path)) || (!File.Exists(originalPath)))
            {
                Log.LogError($"LawnStringsTranslate.json file not found at path: {path}");
            }
            else
            {
                originalJson = File.ReadAllText(originalPath);
                translatedJson = File.ReadAllText(path);

                translatedJson = ExtractFirstJsonObject(translatedJson);
                originalJson = ExtractFirstJsonObject(originalJson);

                PlantData originalPlantData = System.Text.Json.JsonSerializer.Deserialize<PlantData>(originalJson, jsonOptions);
                PlantData translatedPlantData = System.Text.Json.JsonSerializer.Deserialize<PlantData>(translatedJson, jsonOptions);

                for (int i = 0; i < originalPlantData.plants.Count; i++)
                {
                    var originalPlantInfo = originalPlantData.plants[i];
                    PlantInfo translatedPlantInfo = null;

                    foreach (var info in translatedPlantData.plants)
                    {
                        if (info.seedType == originalPlantInfo.seedType)
                        {
                            translatedPlantInfo = info;
                        }
                    }

                    if (translatedPlantInfo != null)
                    {
                        var temp = new KeyValuePair<int, string>(translatedPlantInfo.seedType, translatedPlantInfo.name);
                        plantIndices.Add(originalPlantInfo.seedType, temp);
                    }
                }
            }
        }

        public static string ExtractFirstJsonObject(string json)
        {
            if (string.IsNullOrEmpty(json))
                return json;

            json = json.Trim();
            if (!json.StartsWith("{"))
                return json;

            int braceCount = 0;
            for (int i = 0; i < json.Length; i++)
            {
                if (json[i] == '{') braceCount++;
                else if (json[i] == '}')
                {
                    braceCount--;
                    if (braceCount == 0)
                    {
                        return json.Substring(0, i + 1);
                    }
                }
            }
            return json;
        }

        public static Dictionary<int, List<int>> recipeLinks = new Dictionary<int, List<int>>();

        public static void RegisterRecipeLinks()
        {
            recipeLinks.Clear();

            // In 3.5, MixData uses _recipes dictionary instead of int[,] data
            // The dictionary key is ValueTuple<PlantType, PlantType> and value is the resulting plant
            try
            {
                // Access the static _recipes field via reflection or direct access
                var recipesField = typeof(MixData).GetField("_recipes", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
                if (recipesField == null)
                {
                    Log.LogWarning("[RegisterRecipeLinks] Could not find _recipes field in MixData");
                    return;
                }

                var recipes = recipesField.GetValue(null) as Dictionary<ValueTuple<PlantType, PlantType>, PlantType>;
                if (recipes == null)
                {
                    Log.LogWarning("[RegisterRecipeLinks] _recipes field is null");
                    return;
                }

                // Build recipe links from the dictionary
                foreach (var kvp in recipes)
                {
                    int left = (int)kvp.Key.Item1;
                    int right = (int)kvp.Key.Item2;
                    int result = (int)kvp.Value;

                    if (left > 0 && result > 0)
                    {
                        if (!recipeLinks.ContainsKey(left))
                            recipeLinks[left] = new List<int>();
                        recipeLinks[left].Add(result);
                    }

                    if (right > 0 && result > 0 && left != right)
                    {
                        if (!recipeLinks.ContainsKey(right))
                            recipeLinks[right] = new List<int>();
                        recipeLinks[right].Add(result);
                    }
                }

                // Also check _recipes_random for random mix recipes
                var randomRecipesField = typeof(MixData).GetField("_recipes_random", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
                if (randomRecipesField != null)
                {
                    var randomRecipes = randomRecipesField.GetValue(null) as Dictionary<ValueTuple<PlantType, PlantType>, PlantType>;
                    if (randomRecipes != null)
                    {
                        foreach (var kvp in randomRecipes)
                        {
                            int left = (int)kvp.Key.Item1;
                            int right = (int)kvp.Key.Item2;
                            int result = (int)kvp.Value;

                            if (left > 0 && result > 0)
                            {
                                if (!recipeLinks.ContainsKey(left))
                                    recipeLinks[left] = new List<int>();
                                if (!recipeLinks[left].Contains(result))
                                    recipeLinks[left].Add(result);
                            }

                            if (right > 0 && result > 0 && left != right)
                            {
                                if (!recipeLinks.ContainsKey(right))
                                    recipeLinks[right] = new List<int>();
                                if (!recipeLinks[right].Contains(result))
                                    recipeLinks[right].Add(result);
                            }
                        }
                    }
                }

                Log.LogInfo($"[RegisterRecipeLinks] Loaded {recipes.Count} recipes from MixData");
            }
            catch (Exception ex)
            {
                Log.LogError($"[RegisterRecipeLinks] Error: {ex.Message}");
            }
        }

        internal static bool TryReplaceTexture2D(Texture2D ogTexture)
        {
            if (ogTexture == null)
                return false;

            if (!TextureStore.textureDict.TryGetValue(ogTexture.name, out byte[] textureData))
                return false;

            bool replaced = false;
            try
            {
                replaced = ImageConversion.LoadImage(ogTexture, textureData);
            }
            catch { }

            if (!replaced)
            {
                try
                {
                    Texture2D tempTex = new Texture2D(2, 2, TextureFormat.RGBA32, false);
                    if (ImageConversion.LoadImage(tempTex, textureData))
                    {
                        ogTexture.Resize(tempTex.width, tempTex.height, TextureFormat.RGBA32, false);
                        ogTexture.SetPixels(tempTex.GetPixels());
                        ogTexture.Apply(false);
                        UnityEngine.Object.Destroy(tempTex);
                        replaced = true;
                    }
                    UnityEngine.Object.Destroy(tempTex);
                }
                catch { }
            }

            if (replaced)
            {
                Core.Log.LogDebug("OK! Replaced Texture " + ogTexture.name);
                ogTexture.name = "replaced_" + ogTexture.name;
                return true;
            }
            return false;
        }

        internal static void RebuildSpriteRenderer(SpriteRenderer sr)
        {
            if (sr?.sprite == null)
                return;

            try
            {
                var oldSprite = sr.sprite;
                var texture = oldSprite.texture;

                if (texture == null)
                    return;

                string textureName = texture.name;
                if (!TextureStore.spriteDict.ContainsKey(textureName))
                    return;

                Sprite newSprite = Sprite.Create(
                    texture,
                    new Rect(0, 0, texture.width, texture.height),
                    oldSprite.pivot,
                    oldSprite.pixelsPerUnit,
                    0,
                    SpriteMeshType.FullRect,
                    oldSprite.border
                );
                newSprite.name = oldSprite.name;

                sr.sprite = newSprite;
            }
            catch { }
        }

        internal static void RebuildAllSpriteRenderers()
        {
            var spriteRenderers = Resources.FindObjectsOfTypeAll<SpriteRenderer>();
            int rebuiltCount = 0;
            foreach (var sr in spriteRenderers)
            {
                if (sr.sprite == null)
                    continue;

                var texture = sr.sprite.texture;
                if (texture == null)
                    continue;

                string textureName = texture.name;
                if (!TextureStore.spriteDict.ContainsKey(textureName))
                    continue;

                try
                {
                    var oldSprite = sr.sprite;
                    Sprite newSprite = Sprite.Create(
                        texture,
                        new Rect(0, 0, texture.width, texture.height),
                        oldSprite.pivot,
                        oldSprite.pixelsPerUnit,
                        0,
                        SpriteMeshType.FullRect,
                        oldSprite.border
                    );
                    newSprite.name = oldSprite.name;

                    sr.sprite = newSprite;
                    rebuiltCount++;
                }
                catch { }
            }
            Core.Log.LogDebug($"Rebuilt {rebuiltCount} SpriteRenderers");
        }

        internal static Texture2D LoadImage(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"The image file at path '{path}' does not exist.");
            }

            byte[] array = File.ReadAllBytes(path);
            return LoadImage(array);
        }

        internal static Texture2D LoadImage(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
            {
                throw new ArgumentException("Byte array was null or empty.");
            }

            Texture2D texture2D = new(2, 2, GraphicsFormat.R8G8B8A8_UNorm, TextureCreationFlags.None);
            if (!ImageConversion.LoadImage(texture2D, bytes))
            {
                throw new InvalidOperationException("Failed to load image from bytes.");
            }
            return texture2D;
        }

        public static Color HexToColor(string hex)
        {

            hex = hex.Replace("#", "");

            float r = int.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber) / 255f;
            float g = int.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber) / 255f;
            float b = int.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber) / 255f;

            return new Color(r, g, b);
        }

        public static void OpenSaveDirectory()
        {
            string saveDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "AppData", "LocalLow", "LanPiaoPiao", "PlantsVsZombiesRH");
            Process.Start("explorer.exe", saveDirectory);
        }

        public static void OpenOnlineAlmanac()
        {
            string website = "https://carroti4ch.itch.io/almanac";
            Process.Start(new ProcessStartInfo(website) { UseShellExecute = true });
        }

        public static string RemoveColorTags(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text ?? string.Empty;

            // Remove opening color tags like <color=#FF0000>
            string withoutOpenTags = Regex.Replace(text, @"<color=[^>]+>", string.Empty, RegexOptions.IgnoreCase);
            // Remove closing color tags like </color>
            string withoutCloseTags = Regex.Replace(withoutOpenTags, @"</color>", string.Empty, RegexOptions.IgnoreCase);
            return withoutCloseTags;
        }

        public static string RemoveSizeTags(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text ?? string.Empty;

            string withoutOpenTags = Regex.Replace(text, @"<size=[^>]+>", string.Empty, RegexOptions.IgnoreCase);
            string withoutCloseTags = Regex.Replace(withoutOpenTags, @"</size>", string.Empty, RegexOptions.IgnoreCase);
            return withoutCloseTags;
        }

        public static GameObject ConvertToTextMeshProUGUI(GameObject originalText, Transform parent, string name)
        {
            GameObject newObj = new GameObject(name);
            newObj.transform.position = originalText.transform.position;
            newObj.AddComponent<CanvasRenderer>();
            newObj.AddComponent<RectTransform>();
            newObj.AddComponent<TextMeshProUGUI>();
            newObj.transform.SetParent(parent);
            newObj.transform.localScale = Vector3.one;

            UnityEngine.Object.Destroy(originalText);
            return newObj;
        }

        public static void ConvertButtonText(Transform original, string name)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            Transform transform = original.FindChild(name);
            Transform textTransform = transform.FindChild("text");
            string text = textTransform.GetComponent<Text>().text;
            Color color = textTransform.GetComponent<Text>().color;

            TextMeshProUGUI newGoBackText = Utils.ConvertToTextMeshProUGUI(textTransform.gameObject, transform, "text2").GetComponent<TextMeshProUGUI>();
            newGoBackText.autoSizeTextContainer = true;
            newGoBackText.text = StringStore.TranslateText(text, false);
            newGoBackText.font = fontAsset;
            newGoBackText.color = color;
        }

        public static string GetPlantNameFromAlmanac(PlantType thePlantType, string fallback = null)
        {
            int seedType = (int)thePlantType;
            if (plantIndices.TryGetValue(seedType, out var plantInfo))
            {
                return plantInfo.Value;
            }

            return fallback ?? thePlantType.ToString();
        }

        public static string GetPlantNameFromAlmanac(string theOriginalPlantName)
        {
            string currentLanguage = Utils.Language.ToString();
            string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
            string dumpDir = GetAssetDir(AssetType.Dumps);
            string originalPath = Path.Combine(dumpDir, "LawnStrings.json");
            string path = Path.Combine(almanacDir, "LawnStringsTranslate.json");

            if ((!File.Exists(path)) || (!File.Exists(originalPath)))
            {
                Log.LogError($"LawnStringsTranslate.json file not found at path: {path}");
                return theOriginalPlantName;
            }

            var jsonOptions = new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string originalJson = File.ReadAllText(originalPath);
            string translatedJson = File.ReadAllText(path);
            PlantData originalPlantData = System.Text.Json.JsonSerializer.Deserialize<PlantData>(originalJson, jsonOptions);
            PlantData translatedPlantData = System.Text.Json.JsonSerializer.Deserialize<PlantData>(translatedJson, jsonOptions);

            for (int i = 0; i < originalPlantData.plants.Count; i++)
            {
                PlantInfo originalPlantInfo = originalPlantData.plants[i];

                if (originalPlantInfo.name == theOriginalPlantName)
                {
                    if (plantIndices.TryGetValue(originalPlantInfo.seedType, out var translatedInfo))
                    {
                        return translatedInfo.Value;
                    }

                    return theOriginalPlantName;
                }
            }

            return theOriginalPlantName;
        }

        public static string GetZombieNameFromAlmanac(ZombieType theZombieType, string fallback = null)
        {
            if (!ZombieDataCached || CachedZombieData == null || CachedZombieData.zombies == null)
            {
                Log.LogWarning($"Zombie data not cached, unable to get zombie name for type: {(int)theZombieType}");
                return fallback ?? theZombieType.ToString();
            }

            foreach (ZombieInfo zombieInfo in CachedZombieData.zombies)
            {
                if ((int)zombieInfo.theZombieType == (int)theZombieType)
                {
                    return zombieInfo.name ?? (fallback ?? theZombieType.ToString());
                }
            }

            if (CachedModdedZombieData != null && CachedModdedZombieData.zombies != null)
            {
                foreach (ZombieInfo zombieInfo in CachedModdedZombieData.zombies)
                {
                    if ((int)zombieInfo.theZombieType == (int)theZombieType)
                    {
                        return zombieInfo.name ?? (fallback ?? theZombieType.ToString());
                    }
                }
            }

            return fallback ?? theZombieType.ToString();
        }



        public static bool CheckForUntranslatedText(string text)
        {
            Regex regex = new("\\p{IsCJKUnifiedIdeographs}+");
            try
            {
                Match match = regex.Match(text);
                return match.Success;
            }
            catch (Exception e)
            {
                Log.LogError(e);
            }
            return false;
        }


        internal static void ChangeLanguage(string language)
        {
            try
            {
                if (Enum.TryParse(language, out Utils.LanguageEnum lang))
                {
                    if (Language == lang)
                    {
                        Log.LogInfo($"Language is already {lang}, skipping change");
                        return;
                    }
                    
                    OldLanguage = Language;
                    Utils.Language = lang;
                    
                    Log.LogInfo($"Changing language from {OldLanguage} to {Language}");
                }
                else
                {
                    Log.LogError($"Invalid language string: {language}");
                    return;
                }

                Log.LogInfo("Reloading FontStore...");
                try { FontStore.Reload(); } catch (Exception ex) { Log.LogError($"FontStore.Reload error: {ex.Message}"); }
                
                Log.LogInfo("Reloading StringStore...");
                try { StringStore.Reload(); } catch (Exception ex) { Log.LogError($"StringStore.Reload error: {ex.Message}"); }
                
                Log.LogInfo("Reloading TextureStore...");
                try { TextureStore.Reload(); } catch (Exception ex) { Log.LogError($"TextureStore.Reload error: {ex.Message}"); }

                Log.LogInfo("Applying texture replacements...");
                try { TextureStore.ReplaceTextures(); } catch (Exception ex) { Log.LogError($"ReplaceTextures error: {ex.Message}"); }

                if (!customTextures && !useLocal)
                {
                    Log.LogInfo("Downloading textures from Github...");
                    FileLoader.DownloadTexturesFromGithub(lang);
                }
                
                Log.LogInfo("Loading Almanac...");
                try { FileLoader.LoadAlmanac(); } catch (Exception ex) { Log.LogError($"LoadAlmanac error: {ex.Message}"); }
                
                Log.LogInfo("Saving Language and Almanac...");
                try { FileLoader.SaveLanguage(); FileLoader.SaveAlmanacFiles(); } catch (Exception ex) { Log.LogError($"Save error: {ex.Message}"); }
                
                Log.LogInfo("Registering Plant Indices...");
                try { RegisterPlantIndices(); } catch (Exception ex) { Log.LogError($"RegisterPlantIndices error: {ex.Message}"); }
                
                Log.LogInfo("Caching Almanac Data...");
                try { CacheAlmanacData(); } catch (Exception ex) { Log.LogError($"CacheAlmanacData error: {ex.Message}"); }
                
                Log.LogInfo("Loading HP Strings...");
                try { PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects.Zombie_Patch.LoadHPStrings(); } 
                catch (Exception ex) { Log.LogError($"LoadHPStrings error: {ex.Message}"); }
                
                Log.LogInfo($"Language changed to {Language} successfully");
            }
            catch (Exception ex)
            {
                Log.LogError($"Error in ChangeLanguage: {ex.Message}");
                Log.LogError(ex.StackTrace);
            }
        }

        public static Utils.LanguageEnum OldLanguage;

        public static Utils.LanguageEnum Language;

        public static string mainCategory = "PvZ_Fusion_Translator";

        public static bool customTextures => Core.Instance != null && !Core.Instance.configDefaultTextures.Value;
        public static bool customAudio => Core.Instance != null && !Core.Instance.configDefaultAudio.Value;

        public enum LanguageEnum
        {
            // first column
            English,
            French,
            Italian,
            German,
            Spanish,
            Portuguese,

            // second column
            Javanese, //Filipino,
            Vietnamese,
            Indonesian,
            Russian, //NOTE: legacy language
            Japanese,
            Korean,

            // third column
            Ukrainian,
            // Slovak,
            //Polish,
            Turkish,
            //Arabic,
            Romanian,

            LANG_END
        }

        public enum ToggleEnum
        {
            Textures,
            Audio,
            SwapLocal,
            TOGGLE_END
        }

        public static bool useLocal = false;

        public static Dictionary<ToggleEnum, string> ToggleNames = new Dictionary<ToggleEnum, string>()
        {
            { ToggleEnum.Textures, "Textures" },
            { ToggleEnum.Audio, "Audio" },
            { ToggleEnum.SwapLocal, "SwapLocal" }
        };

        public static void WarnLocalData()
        {
            string modeTo = (Utils.useLocal) ? "online mode" : "local mode";
            Log.LogWarning($"Switching to {modeTo}");
            Utils.useLocal = (Utils.useLocal) ? false : true;
        }

        public static async Task<string> GetDataFromWeb(string url, bool isLog = true)
        {
            if (isLog)
            {
                Log.LogInfo($"Attempting to read {url}");
            }
            HttpClient client = new HttpClient();
            try
            {
                var dataRequest = await client.GetAsync(url);
                if (dataRequest.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (isLog)
                    {
                        Log.LogInfo($"Successfully loaded data from {url}!");
                    }

                    string content = await dataRequest.Content.ReadAsStringAsync();
                    return content;
                }
                else
                {
                    if (isLog)
                    {
                        Log.LogError($"Failed to load data from {url}! Falling back...");
                        Log.LogError($"Status code: {dataRequest.StatusCode}");
                    }
                    new CancellationTokenSource().Cancel();
                    return null;
                }
            }
            catch (Exception ex)
            {
                Log.LogError($"Failed to load data from {url}! Falling back...");
                Log.LogError(ex);
                new CancellationTokenSource().Cancel();
                return null;
            }
        }

        public static async Task<byte[]> GetImageDataFromWeb(string url, bool isLog = true)
        {
            return await GetByteDataFromWeb(url, isLog);
        }

        public static async Task<byte[]> GetByteDataFromWeb(string url, bool isLog = true)
        {
            if (isLog)
            {
                Log.LogInfo($"Attempting to read {url}");
            }
            HttpClient client = new HttpClient();
            try
            {
                var dataRequest = await client.GetAsync(url);
                if (dataRequest.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (isLog)
                    {
                        Log.LogInfo($"Successfully loaded data from {url}!");
                    }

                    byte[] content = await dataRequest.Content.ReadAsByteArrayAsync();
                    return content;
                }
                else
                {
                    if (isLog)
                    {
                        Log.LogError($"Failed to load data from {url}! Falling back...");
                        Log.LogError($"Status code: {dataRequest.StatusCode}");
                    }
                    new CancellationTokenSource().Cancel();
                    return null;
                }
            }
            catch (Exception ex)
            {
                Log.LogError($"Failed to load data from {url}! Falling back...");
                Log.LogError(ex);
                new CancellationTokenSource().Cancel();
                return null;
            }
        }

        public static int CalculateGameVersion(string gameVersion)
        {
            int res = 0;
            string[] gameVersionParts = gameVersion.Split('.');

            int startingPower = (int)Math.Max(gameVersionParts.Length, 3);
            for (int i = 0; i < startingPower; i++)
            {
                int factor = 0;
                if (i < gameVersionParts.Length)
                {
                    factor = int.Parse(gameVersionParts[i]);
                }
                int power = startingPower - i;
                res += factor * (int)Math.Pow(10, power - 1);
            }

            return res;
        }
    }
}