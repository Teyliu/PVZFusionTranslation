using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.GameObjects;
using PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects;
using PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using UnityEngine.Experimental.Rendering;
using UnityEngine.UI;

namespace PvZ_Fusion_Translator;

public static class Utils
{
    internal static bool TryReplaceTexture2D(Texture2D ogTexture)
    {
        if (ogTexture == null)
            return false;

        if (!TextureStore.TextureDict.TryGetValue(ogTexture.name, out var textureData))
            return false;

        try
        {
            ImageConversion.LoadImage(ogTexture, textureData);

            Log.LogDebug("OK! Replaced Texture " + ogTexture.name);

            ogTexture.name = "replaced_" + ogTexture.name;
            return true;
        }
        catch (Exception ex)
        {
            Log.LogError("Failed to replace texture: " + ogTexture.name);
            Log.LogError(ex.ToString());
        }

        return false;
    }

    internal static Texture2D LoadImage(string path)
    {
        if (!File.Exists(path))
            throw new FileNotFoundException($"The image file at path '{path}' does not exist.");

        var array = File.ReadAllBytes(path);

        Texture2D texture2D = new(
            2,
            2,
            GraphicsFormat.R8G8B8A8_UNorm,
            TextureCreationFlags.None,
            1,
            IntPtr.Zero,
            null
        );

        ImageConversion.LoadImage(texture2D, array);
        return texture2D;
    }

    internal static Texture2D LoadImage(byte[] bytes)
    {
        if (bytes == null)
            throw new FileNotFoundException("Byte array was null.");

        Texture2D texture2D = new(
            2,
            2,
            GraphicsFormat.R8G8B8A8_UNorm,
            TextureCreationFlags.None,
            1,
            IntPtr.Zero,
            null
        );

        ImageConversion.LoadImage(texture2D, bytes);
        return texture2D;
    }

    public static Color HexToColor(string hex)
    {
        var r = int.Parse(hex.TrimStart("#")[..2], System.Globalization.NumberStyles.HexNumber) / 255f;
        var g = int.Parse(hex.TrimStart("#")[2..4], System.Globalization.NumberStyles.HexNumber) / 255f;
        var b = int.Parse(hex.TrimStart("#")[4..6], System.Globalization.NumberStyles.HexNumber) / 255f;
        return new(r, g, b);
    }

    public static void OpenSaveDirectory()
    {
        var saveDirectory = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            "AppData",
            "LocalLow",
            "LanPiaoPiao",
            "PlantsVsZombiesRH"
        );

        Process.Start("explorer.exe", saveDirectory);
    }

    public static void OpenOnlineAlmanac()
    {
        const string Website = "https://carroti4ch.itch.io/almanac";
        Process.Start(new ProcessStartInfo(Website) { UseShellExecute = true });
    }

    public static string RemoveColorTags(string text)
    {
        if (string.IsNullOrEmpty(text))
            return text ?? string.Empty;

        // Remove opening color tags like <color=#FF0000>
        var withoutOpenTags = Regex.Replace(text, "<color=[^>]+>", string.Empty, RegexOptions.IgnoreCase);
        // Remove closing color tags like </color>
        var withoutCloseTags = Regex.Replace(withoutOpenTags, "</color>", string.Empty, RegexOptions.IgnoreCase);
        return withoutCloseTags;
    }

    public static string RemoveSizeTags(string text)
    {
        if (string.IsNullOrEmpty(text))
            return text ?? string.Empty;

        // Remove opening size tags like <color=#FF0000>
        var withoutOpenTags = Regex.Replace(text, "<size=[^>]+>", string.Empty, RegexOptions.IgnoreCase);
        // Remove closing size tags like </color>
        var withoutCloseTags = Regex.Replace(withoutOpenTags, "</size>", string.Empty, RegexOptions.IgnoreCase);
        return withoutCloseTags;
    }

    public static string RemoveFormatTags(string text)
    {
        if (string.IsNullOrEmpty(text))
            return text ?? string.Empty;

        var withoutUnderlineTags = Regex.Replace(text, "<u>", string.Empty, RegexOptions.IgnoreCase);

        var withoutUnderlineCloseTags = Regex.Replace(
            withoutUnderlineTags,
            "</u>",
            string.Empty,
            RegexOptions.IgnoreCase
        );

        var withoutItalicTags = Regex.Replace(
            withoutUnderlineCloseTags,
            "<i>",
            string.Empty,
            RegexOptions.IgnoreCase
        );

        var withoutItalicCloseTags = Regex.Replace(
            withoutItalicTags,
            "</i>",
            string.Empty,
            RegexOptions.IgnoreCase
        );

        return withoutItalicCloseTags;
    }

    public static string RemoveAllTags(string text)
    {
        if (string.IsNullOrEmpty(text))
            return text ?? string.Empty;

        return RemoveColorTags(RemoveSizeTags(RemoveFormatTags(text)));
    }

    public static GameObject ConvertToTextMeshProUGUI(GameObject originalText, Transform parent, string name)
    {
        GameObject newObj = new(name)
        {
            transform =
            {
                position = originalText.transform.position,
            },
        };

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
        var fontAsset = FontStore.LoadTMPFont(Language.ToString());

        var transform = original.FindChild(name);
        var textTransform = transform.FindChild("text");
        var text = textTransform.GetComponent<Text>().text;
        var color = textTransform.GetComponent<Text>().color;

        var newGoBackText = ConvertToTextMeshProUGUI(textTransform.gameObject, transform, "text2")
           .GetComponent<TextMeshProUGUI>();

        newGoBackText.autoSizeTextContainer = true;
        newGoBackText.text = StringStore.TranslateText(text);
        newGoBackText.font = fontAsset;
        newGoBackText.color = color;
    }

    public static string GetPlantNameFromAlmanac(PlantType thePlantType, bool removeTags = false, bool log = false)
    {
        var foundPlantName = false;
        var thePlantName = "";

        if (PlantIndices.ContainsKey((int)thePlantType))
        {
            foundPlantName = true;
            thePlantName = PlantIndices[(int)thePlantType].Value;
        }

        if (!foundPlantName)
        {
            if (log)
                Log.LogInfo("Couldn't find plant name!");

            thePlantName = "";
        }

        thePlantName = removeTags ? RemoveAllTags(thePlantName) : thePlantName;

        return thePlantName;
    }

    public static string GetPlantNameFromAlmanac(
        string theOriginalPlantName,
        bool removeTags = false,
        bool log = false
    )
    {
        var foundPlantName = false;
        var thePlantName = "";

        if (PlantIndiceString.TryGetValue(theOriginalPlantName, out var value))
        {
            foundPlantName = true;
            thePlantName = value;
        }

        if (!foundPlantName)
        {
            if (log)
                Log.LogInfo("Couldn't find plant name!");

            thePlantName = "";
        }

        thePlantName = removeTags ? RemoveAllTags(thePlantName) : thePlantName;

        return thePlantName;
    }

    public static string GetZombieNameFromAlmanac(ZombieType theZombieType, bool removeTags = false)
    {
        var theZombieName = "";
        var json = AlmanacZombieMenu_Patch.AlmanacJson;
        var zombieData = JsonUtility.FromJson<Il2CppAlmanacDataClass>(json);

        foreach (var zombieInfo in zombieData.zombies)
            if ((int)zombieInfo.theZombieType == (int)theZombieType)
                theZombieName = zombieInfo.name;

        theZombieName = removeTags ? RemoveAllTags(theZombieName) : theZombieName;

        return theZombieName;
    }

#pragma warning disable CA2211
    public static Dictionary<int, KeyValuePair<int, string>> PlantIndices = new();

    public static Dictionary<string, string> PlantIndiceString = new();
#pragma warning restore CA2211
    public static void RegisterPlantIndices()
    {
        PlantIndices = new();
        PlantIndiceString = new();

        var dumpDir = FileLoader.GetAssetDir(FileLoader.AssetType.Dumps);
        var originalPath = Path.Combine(dumpDir, "LawnStrings.json");

        if (!File.Exists(originalPath))
            Log.LogError($"LawnStrings.json file not found at path: {originalPath}");
        else
            try
            {
                var originalJson = File.ReadAllText(originalPath);
                var translatedJson = AlmanacPlantMenu_Patch.AlmanacJson;

                var originalPlantData = JsonUtility.FromJson<Il2CppAlmanacDataClass>(originalJson);
                var translatedPlantData = JsonUtility.FromJson<Il2CppAlmanacDataClass>(translatedJson);

                foreach (var originalPlantInfo in originalPlantData.plants)
                {
                    if (!PlantIndiceString.ContainsKey(originalPlantInfo.name))
                        PlantIndiceString.Add(originalPlantInfo.name, originalPlantInfo.name);

                    Il2CppPlantInfo translatedPlantInfo = null;

                    foreach (var info in translatedPlantData.plants)
                        if (info.seedType == originalPlantInfo.seedType)
                            translatedPlantInfo = info;

                    if (translatedPlantInfo is not { name: not null })
                        continue;

                    KeyValuePair<int, string> temp = new(translatedPlantInfo.seedType, translatedPlantInfo.name);
                    PlantIndices.Add(originalPlantInfo.seedType, temp);
                    PlantIndiceString[originalPlantInfo.name] = translatedPlantInfo.name;
                }
            }
            catch (Exception e)
            {
                Log.LogError(e);
            }
    }

    public static void TryAdd<TA, TB>(Dictionary<TA, TB> dict, TA key, TB val) => dict[key] = val;

    public static void TryAdd<TA, TB>(SortedDictionary<TA, TB> dict, TA key, TB val) => dict[key] = val;

    public static AssetBundle GetAssetBundle(Assembly assembly, string assetBundlePath, bool log = false)
    {
        try
        {
            if (assembly == null)
                throw new($"AssetBundle {assetBundlePath} was null.");

            using var manifestResourceStream =
                assembly.GetManifestResourceStream($"PvZ_Fusion_Translator.Resources.{assetBundlePath}");

            if (manifestResourceStream == null)
                throw new("Stream was null.");

            var array = new byte[manifestResourceStream.Length];
            _ = manifestResourceStream.Read(array, 0, array.Length);
            var assetBundle = AssetBundle.LoadFromMemory(array);
            ArgumentNullException.ThrowIfNull(assetBundle);

            if (log)
                Log.LogDebug($"AssetBundle {assetBundlePath} has successfully been loaded.");

            return assetBundle;
        }
        catch (Exception value)
        {
            throw new ArgumentException($"Failed to load {assetBundlePath}. \n{value}");
        }
    }

    public static AssetBundle GetAssetBundle(string path)
    {
        var assetBundle = AssetBundle.LoadFromFile(path);
        return assetBundle;
    }
#if false
    public static readonly Dictionary<int, List<int>> recipeLinks = new();

    public static void RegisterRecipeLinks()
    {
        recipeLinks.Clear();

        Il2CppSystem.Array mixData = MixData.data.Cast<Il2CppSystem.Array>();
        var rows = mixData.GetLength(0);
        var columns = mixData.GetLength(1);

        foreach (var seedType in from PlantType plantType in Enum.GetValues(typeof(PlantType)) select (int)plantType)
        {
            recipeLinks.Add(seedType, new());

            if (seedType > 0)
                foreach (var checks in Enum.GetValues(typeof(PlantType))
                   .Cast<PlantType>()
                   .Where(checkType => checkType > 0)
                   .Select(
                        int[] (checkType) =>
                        [
                            mixData.GetValue(seedType, (int)checkType).Unbox<int>(),
                            mixData.GetValue((int)checkType, seedType).Unbox<int>(),
                        ]
                    ))
                {
                    if (checks[0] != 0)
                        recipeLinks[seedType].Add(checks[0]);

                    if (checks[1] != 0)
                        recipeLinks[seedType].Add(checks[1]);
                }

            if (recipeLinks[seedType].Count > 0)
                Log.LogDebug($"Found {recipeLinks[seedType].Count} fusions for {seedType}!");
        }
    }
#endif
    public static readonly Regex UntranslatedRegex = new("\\p{IsCJKUnifiedIdeographs}+");

    public static bool CheckForUntranslatedText(string text)
    {
        try
        {
            var match = UntranslatedRegex.Match(text);
            return match.Success;
        }
        catch (Exception e)
        {
            Log.LogError(e);
        }

        return false;
    }

    public static void WarnLocalData()
    {
        var newMenu = GameAPP.UIManager.Push(UIType.ConfirmMenu, GameAPP.canvasUp);
        var confirmMenu = newMenu.gameObject.GetComponent<ConfirmMenu>();

        var modeTo = Core.Instance.ConfigUseLocal.Value ? "online mode" : "local mode";

        confirmMenu.SetTitle(
            $"<size=40%>WARNING: This button is meant for translator testing and can overwrite/interfere with the translation files saved in your installation. Proceed with caution. <color=red>You are switching to {modeTo}.</color>\nOnline Mode: Default, strings will auto-sync with the latest version when opening the game\nLocal Mode: Strings are only loaded from your installaion and do not update (meant for translators)"
        );

        confirmMenu.transform.Find("window/text").GetComponent<TextMeshProUGUI>().text = RemoveColorTags(
            confirmMenu.transform.Find("window/text").GetComponent<TextMeshProUGUI>().text
        );

        var confirmButton = confirmMenu.transform.Find("Image").GetComponent<UIButton>();
        _ = confirmMenu.transform.Find("Image2").GetComponent<UIButton>();

        confirmButton.clickEvent = new();
        confirmButton.clickEvent.AddListener(new Action(SwapLocalData));
        confirmButton.clickEvent.AddListener(new Action(CursorChange.SetDefaultCursor));
        confirmButton.clickEvent.AddListener(new Action(() => GameAPP.UIManager.Pop()));
    }

    public static void SwapLocalData()
    {
        Core.Instance.ConfigUseLocal.Value = !Core.Instance.ConfigUseLocal.Value;
        ChangeLanguage(Language.ToString());
        var sourceMsg = $"<size=10>Translation Source:\n{(Core.Instance.ConfigUseLocal.Value ? "Local" : "Online")}";
        OptLanguageBtn_Patch.FlashMessage(OptLanguageBtn_Patch.ToggleSlots[2], sourceMsg, 0.1f, false);
        CursorChange.SetDefaultCursor();
    }

    public static async Task<string> GetDataFromWeb(string url, bool isLog = true)
    {
        if (isLog)
            Log.LogInfo($"Attempting to read {url}");

        try
        {
            var dataRequest = await s_client.GetAsync(url);

            if (dataRequest.StatusCode == System.Net.HttpStatusCode.OK)
            {
                if (isLog)
                    Log.LogInfo($"Successfully loaded data from {url}!");

                var content = await dataRequest.Content.ReadAsStringAsync();
                return content;
            }

            if (isLog)
            {
                Log.LogError($"Failed to load data from {url}! Falling back...");
                Log.LogError($"Status code: {dataRequest.StatusCode}");
            }

            new CancellationTokenSource().Cancel();
            return null;
        }
        catch (Exception ex)
        {
            Log.LogError($"Failed to load data from {url}! Falling back...");
            Log.LogError(ex);
            new CancellationTokenSource().Cancel();
            return null;
        }
    }

    public static async Task<byte[]> GetByteDataFromWeb(string url, bool isLog = true)
    {
        if (isLog)
            Log.LogInfo($"Attempting to read {url}");

        try
        {
            var dataRequest = await s_client.GetAsync(url);

            if (dataRequest.StatusCode == System.Net.HttpStatusCode.OK)
            {
                if (isLog)
                    Log.LogInfo($"Successfully loaded data from {url}!");

                var content = await dataRequest.Content.ReadAsByteArrayAsync();
                return content;
            }

            if (isLog)
            {
                Log.LogError($"Failed to load data from {url}! Falling back...");
                Log.LogError($"Status code: {dataRequest.StatusCode}");
            }

            new CancellationTokenSource().Cancel();
            return null;
        }
        catch (Exception ex)
        {
            Log.LogError($"Failed to load data from {url}! Falling back...");
            Log.LogError(ex);
            new CancellationTokenSource().Cancel();
            return null;
        }
    }

    public static async Task<string> GetDataFromWebWithInput(string url, bool isLog = true)
    {
        if (isLog)
            Log.LogInfo($"Attempting to read {url}");

        using var request = new HttpRequestMessage();
        request.Method = HttpMethod.Get;
        request.RequestUri = new(url);

        request.Headers.Add("Accept", "*/*");
        request.Headers.Add("Accept-Encoding", "gzip, deflate, br");
        request.Headers.Add("User-Agent", "TranslatorMod");

        var dataRequest = await s_client.SendAsync(request);

        if (dataRequest.StatusCode == System.Net.HttpStatusCode.OK)
        {
            if (isLog)
                Log.LogInfo($"Successfully loaded data from {url}!");

            var content = await dataRequest.Content.ReadAsStringAsync();
            return content;
        }

        if (isLog)
        {
            Log.LogError($"Failed to load data from {url}! Falling back...");
            Log.LogError($"Status code: {dataRequest.StatusCode}");
        }

        new CancellationTokenSource().Cancel();
        return null;
    }

    public static int CalculateGameVersion(string gameVersion)
    {
        var res = 0;
        var gameVersionParts = gameVersion.Split('.');

        var startingPower = Math.Max(gameVersionParts.Length, 3);

        for (var i = 0; i < startingPower; i++)
        {
            var factor = 0;

            if (i < gameVersionParts.Length)
                factor = int.Parse(gameVersionParts[i]);

            var power = startingPower - i;
            res += factor * (int)Math.Pow(10, power - 1);
        }

        return res;
    }

    internal static void ChangeLanguage(string language)
    {
        UnityEngine.Debug.Assert(ModFeatures.IsMultiLanguage, nameof(ModFeatures.IsMultiLanguage));
        OldLanguage = Language;

        if (Enum.TryParse(language, out LanguageEnum lang))
            Language = lang;
        else
            // Handle invalid language string
            Log.LogError($"Invalid language string: {language}");

        //WarningStore.isWarningMessageLoaded = false;
        FontStore.Reload();
        StringStore.Reload();
        TextureStore.Reload();
        FileLoader.SaveLanguage();
        RegisterPlantIndices();
        Zombie_Patch.LoadHpStrings();
    }
#pragma warning disable CA2211 // ReSharper disable once NotAccessedField.Global
    public static LanguageEnum OldLanguage;
    public static LanguageEnum Language;

    public enum LanguageEnum
    {
        // first column
        English,
        ChineseCn,
        French,

        //Italian,
        German,
        Spanish,

        // second column
        //Portuguese,
        //Javanese,
        //Filipino,
        Vietnamese,
        Indonesian,

        //Russian, //NOTE: legacy language
        Japanese,

        // third column
        Korean,
        Ukrainian,

        // Slovak,
        //Polish,
        //Turkish,
        Arabic,
        Romanian,

        LangEnd,
    }

    public static Dictionary<LanguageEnum, string> LanguageNames = new()
    {
        { LanguageEnum.English, "English" },
        { LanguageEnum.ChineseCn, "简体中文" },
        { LanguageEnum.French, "Français" },
        { LanguageEnum.German, "Deutsch" },
        { LanguageEnum.Spanish, "Español" },
        { LanguageEnum.Vietnamese, "Tiếng Việt" },
        { LanguageEnum.Indonesian, "Bahasa Indonesia" },
        { LanguageEnum.Japanese, "日本語" },
        { LanguageEnum.Korean, "한국어" },
        { LanguageEnum.Ukrainian, "українська" },
        { LanguageEnum.Arabic, "ﺔﻴﺑﺮﻌﻟا" },
        { LanguageEnum.Romanian, "Română" },
    };

    public static Dictionary<ToggleEnum, string> ToggleNames = new()
    {
        { ToggleEnum.Textures, "<size=85%>Change Texture\nSource" },
        { ToggleEnum.Audio, "<size=85%>Change Audio\nSource" },
        { ToggleEnum.SwapLocal, "<size=85%>Change Translation\nSource" },
    };

    private static readonly HttpClient s_client = new();
#pragma warning restore CA2211
    public enum ToggleEnum
    {
        Textures,
        Audio,
        SwapLocal,
        ToggleEnd,
    }
}
