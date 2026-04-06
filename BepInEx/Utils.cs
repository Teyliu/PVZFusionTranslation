using BepInEx;
using BepInEx.Configuration;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using TMPro;
using Unity.Burst.Intrinsics;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.UI;
using static AlmanacPlantBank;
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

                if (File.Exists(zombiePath))
                {
                    string zombieJson = File.ReadAllText(zombiePath);
                    CachedZombieData = JsonUtility.FromJson<ZombieAlmanacData>(zombieJson);
                    Log.LogInfo($"Cached {CachedZombieData?.zombies?.Count ?? 0} zombie entries");
                }
                else
                {
                    Log.LogWarning($"ZombieStringsTranslate.json not found at: {zombiePath}");
                }

                if (File.Exists(moddedZombiePath))
                {
                    string moddedZombieJson = File.ReadAllText(moddedZombiePath);
                    CachedModdedZombieData = JsonUtility.FromJson<ZombieAlmanacData>(moddedZombieJson);
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

            if ((!File.Exists(path)) || (!File.Exists(originalPath)))
            {
                Log.LogError($"LawnStringsTranslate.json file not found at path: {path}");
            }
            else
            {
                originalJson = File.ReadAllText(originalPath);
                translatedJson = File.ReadAllText(path);
                AlmanacPlantBank.PlantData originalPlantData = JsonUtility.FromJson<AlmanacPlantBank.PlantData>(originalJson);
                AlmanacPlantBank.PlantData translatedPlantData = JsonUtility.FromJson<AlmanacPlantBank.PlantData>(translatedJson);

                for (int i = 0; i < originalPlantData.plants.Count; i++)
                {
                    var originalPlantInfo = originalPlantData.plants[i];
                    AlmanacPlantBank.PlantInfo translatedPlantInfo = null;

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
            if (ogTexture != null)
            {
                if (TextureStore.textureDict.TryGetValue(ogTexture.name, out string texturePath))
                {
                    try
                    {
                        ImageConversion.LoadImage(ogTexture, File.ReadAllBytes(texturePath));

                        Core.Log.LogDebug("OK! Replaced Texture " + ogTexture.name);

                        ogTexture.name = "replaced_" + ogTexture.name;
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Log.LogError("Failed to replace texture: " + ogTexture.name + " at path: " + texturePath);
                        Log.LogError(ex.ToString());
                    }
                }
            }
            return false;
        }

        internal static Texture2D LoadImage(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"The image file at path '{path}' does not exist.");
            }

            byte[] array = File.ReadAllBytes(path);
            Texture2D texture2D = new(2, 2, GraphicsFormat.R8G8B8A8_UNorm, TextureCreationFlags.None, 1, IntPtr.Zero, null);
            ImageConversion.LoadImage(texture2D, array);
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

        public static void OpenTrello()
        {
            string website = "https://trello.com/b/DcdT1kUp";
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

        public static string GetPlantNameFromAlmanac(PlantType thePlantType)
        {
            int seedType = (int)thePlantType;
            if (plantIndices.TryGetValue(seedType, out var plantInfo))
            {
                return plantInfo.Value;
            }
            
            return "";
        }

        public static string GetPlantNameFromAlmanac(string theOriginalPlantName)
        {
            string originalJson;
            string translatedJson;
            string thePlantName = "";

            string currentLanguage = Utils.Language.ToString();
            string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
            string dumpDir = GetAssetDir(AssetType.Dumps);
            string originalPath = Path.Combine(dumpDir, "LawnStrings.json");
            string path = Path.Combine(almanacDir, "LawnStringsTranslate.json");

            if ((!File.Exists(path)) || (!File.Exists(originalPath)))
            {
                Log.LogError($"LawnStringsTranslate.json file not found at path: {path}");
                Log.LogError("Plant name could not be found!");
                thePlantName = "";
            }
            else
            {
                bool foundPlantName = false;

                originalJson = File.ReadAllText(originalPath);
                translatedJson = File.ReadAllText(path);
                AlmanacPlantBank.PlantData originalPlantData = JsonUtility.FromJson<AlmanacPlantBank.PlantData>(originalJson);
                AlmanacPlantBank.PlantData translatedPlantData = JsonUtility.FromJson<AlmanacPlantBank.PlantData>(translatedJson);

                for (int i = 0; i < originalPlantData.plants.Count; i++)
                {
                    AlmanacPlantBank.PlantInfo originalPlantInfo = originalPlantData.plants[i];
                    KeyValuePair<int, string> translatedPlantInfo = plantIndices[originalPlantInfo.seedType];

                    if (originalPlantInfo.name == theOriginalPlantName)
                    {
                        thePlantName = translatedPlantInfo.Value;
                        foundPlantName = true;
                    }
                }

                if (!foundPlantName)
                {
                    Log.LogInfo("Couldn't find plant name!");
                    thePlantName = "";
                }
            }

            return thePlantName;
        }

        public static string GetZombieNameFromAlmanac(ZombieType theZombieType)
        {
            if (!ZombieDataCached || CachedZombieData == null || CachedZombieData.zombies == null)
            {
                Log.LogWarning("Zombie data not cached, unable to get zombie name");
                return "";
            }

            foreach (ZombieInfo zombieInfo in CachedZombieData.zombies)
            {
                if ((int)zombieInfo.theZombieType == (int)theZombieType)
                {
                    return zombieInfo.name ?? "";
                }
            }

            if (CachedModdedZombieData != null && CachedModdedZombieData.zombies != null)
            {
                foreach (ZombieInfo zombieInfo in CachedModdedZombieData.zombies)
                {
                    if ((int)zombieInfo.theZombieType == (int)theZombieType)
                    {
                        return zombieInfo.name ?? "";
                    }
                }
            }

            return "";
        }



        public static bool CheckForUntranslatedText(string text)
        {
            Regex regex = new("\\p{IsCJKUnifiedIdeographs}+");
			try 
			{
				Match match = regex.Match(text);
				return match.Success;
			} 
			catch(Exception e) 
			{
				Log.LogError(e);
			}
			return false;
        }


#if MULTI_LANGUAGE
        internal static void ChangeLanguage(string language)
        {
            OldLanguage = Language;

            if (Enum.TryParse(language, out Utils.LanguageEnum lang))
            {
                Utils.Language = lang;
            }
            else
            {
                // Handle invalid language string
                Log.LogError($"Invalid language string: {language}");
            }

            //WarningStore.isWarningMessageLoaded = false;
            FontStore.Reload();
            StringStore.Reload();
            TextureStore.Reload();
            FileLoader.SaveLanguage();
            RegisterPlantIndices();
            PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects.Zombie_Patch.LoadHPStrings();
        }
        #endif

        #if MULTI_LANGUAGE
        public static Utils.LanguageEnum OldLanguage;
        #endif

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
                if(dataRequest.StatusCode == System.Net.HttpStatusCode.OK)
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
            catch(Exception ex)
            {
                Log.LogError($"Failed to load data from {url}! Falling back...");
                Log.LogError(ex);
                new CancellationTokenSource().Cancel();
                return null;
            }
        }

        public static async Task<byte[]> GetImageDataFromWeb(string url, bool isLog = true)
        {
            if (isLog)
            {
                Log.LogInfo($"Attempting to read {url}");
            }
            HttpClient client = new HttpClient();
            try
            {
                var dataRequest = await client.GetAsync(url);
                if(dataRequest.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (isLog)
                    {
                        Log.LogInfo($"Successfully loaded image data from {url}!");
                    }
                
                    byte[] content = await dataRequest.Content.ReadAsByteArrayAsync();
                    return content;
                }
                else
                {
                    if (isLog)
                    {
                        Log.LogError($"Failed to load image data from {url}! Falling back...");
                        Log.LogError($"Status code: {dataRequest.StatusCode}");
                    }
                    new CancellationTokenSource().Cancel();
                    return null;
                }
            }
            catch(Exception ex)
            {
                Log.LogError($"Failed to load image data from {url}! Falling back...");
                Log.LogError(ex);
                new CancellationTokenSource().Cancel();
                return null;
            }
        }
    }

}