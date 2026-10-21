using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Newtonsoft.Json;
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.GameObjects;
using PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects;
using PvZ_Fusion_Translator.Patches.Modes.Odyssey;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace PvZ_Fusion_Translator;

// ReSharper disable AssignNullToNotNullAttribute Unity.UnknownResource
internal static class FileLoader
{
    internal enum AssetType
    {
        Textures, Strings, Dumps, Almanac, Sprites,
    }

    public static string GetAssetDir(AssetType assetType, Utils.LanguageEnum? language = null)
    {
        var languagePath = language.HasValue
            ? "Localization" + Path.DirectorySeparatorChar + language
            : string.Empty;

        return Path.Combine(Core.ModDirectory, languagePath, assetType.ToString());
    }

    // private static string GetAssetDir(AssetType assetType) =>
    //     Path.Combine(Core.Instance.modsDirectory, assetType.ToString());

    internal static void LoadStrings() => LoadStrings(Utils.Language);

    internal static void LoadStrings(Utils.LanguageEnum language)
    {
        var stringDir = GetAssetDir(AssetType.Strings, Utils.Language);

        if (!Directory.Exists(stringDir))
            Directory.CreateDirectory(stringDir);

        if (!Core.Instance.ConfigUseLocal.Value)
        {
            // load translationStrings
            var translationStringsContent = Utils.GetDataFromWeb(
                    $"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language}/Strings/translation_strings.json"
                )
               .Result;

            if (translationStringsContent != null)
                LoadTranslationStrings(translationStringsContent);
            else
            {
                var translationStringsPath = Path.Combine(
                    GetAssetDir(AssetType.Strings, Utils.Language),
                    "translation_strings.json"
                );

                if (File.Exists(translationStringsPath))
                    LoadTranslationStrings(File.ReadAllText(translationStringsPath));
            }

            // load translationRegexs
            var translationRegexsContent = Utils.GetDataFromWeb(
                    $"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language}/Strings/translation_regexs.json"
                )
               .Result;

            if (translationRegexsContent != null)
                LoadTranslationRegexs(translationRegexsContent);
            else
            {
                var translationRegexsPath = Path.Combine(
                    GetAssetDir(AssetType.Strings, Utils.Language),
                    "translation_regexs.json"
                );

                if (File.Exists(translationRegexsPath))
                    LoadTranslationRegexs(File.ReadAllText(translationRegexsPath));
            }

            var customLevelStringsContent = Utils.GetDataFromWeb(
                    $"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language}/Strings/customlevel_strings.json"
                )
               .Result;

            if (customLevelStringsContent != null)
                LoadCustomLevelStrings(customLevelStringsContent);
            else
            {
                var customLevelStringsPath = Path.Combine(
                    GetAssetDir(AssetType.Strings, Utils.Language),
                    "customlevel_strings.json"
                );

                if (File.Exists(customLevelStringsPath))
                    LoadCustomLevelStrings(File.ReadAllText(customLevelStringsPath));
            }

            // load translationRegexs
            var customLevelRegexsContent = Utils.GetDataFromWeb(
                    $"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language}/Strings/customlevel_regexs.json"
                )
               .Result;

            if (customLevelRegexsContent != null)
                LoadCustomLevelRegexs(customLevelRegexsContent);
            else
            {
                var customLevelRegexsPath = Path.Combine(
                    GetAssetDir(AssetType.Strings, Utils.Language),
                    "customlevel_regexs.json"
                );

                if (File.Exists(customLevelRegexsPath))
                    LoadCustomLevelRegexs(File.ReadAllText(customLevelRegexsPath));
            }

            // load changelog

            LoadChangelogText();

            // load tips
            var izTipsContent = Utils.GetDataFromWeb(
                    $"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language}/Strings/tips_iz.json"
                )
               .Result;

            if (izTipsContent != null)
                LoadIZStrings(izTipsContent);
            else
            {
                var izTipsPath = Path.Combine(GetAssetDir(AssetType.Strings, Utils.Language), "tips_iz.json");

                if (File.Exists(izTipsPath))
                    LoadIZStrings(File.ReadAllText(izTipsPath));
            }

            var fsTipsContent = Utils.GetDataFromWeb(
                    $"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language}/Strings/tips_fs.json"
                )
               .Result;

            if (fsTipsContent != null)
                LoadFsStrings(fsTipsContent);
            else
            {
                var fsTipsPath = Path.Combine(GetAssetDir(AssetType.Strings, Utils.Language), "tips_fs.json");

                if (File.Exists(fsTipsPath))
                    LoadFsStrings(File.ReadAllText(fsTipsPath));
            }

            // load almanacs

            var almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);

            if (!Directory.Exists(almanacDir))
                Directory.CreateDirectory(almanacDir);

            var plantAlmanacContent = Utils.GetDataFromWeb(
                    $"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language}/Almanac/LawnStringsTranslate.json"
                )
               .Result;

            if (plantAlmanacContent != null)
                AlmanacPlantMenu_Patch.LoadPlantAlmanacData(plantAlmanacContent);
            else
            {
                var path = Path.Combine(almanacDir, "LawnStringsTranslate.json");

                if (File.Exists(path))
                    AlmanacPlantMenu_Patch.LoadPlantAlmanacData(File.ReadAllText(path));
            }

            var zombieAlmanacContent = Utils.GetDataFromWeb(
                    $"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language}/Almanac/ZombieStringsTranslate.json"
                )
               .Result;

            if (zombieAlmanacContent != null)
                AlmanacZombieMenu_Patch.AlmanacJson = zombieAlmanacContent;
            else
            {
                var path = Path.Combine(almanacDir, "ZombieStringsTranslate.json");

                if (File.Exists(path))
                    AlmanacZombieMenu_Patch.AlmanacJson = File.ReadAllText(path);
            }

            var detailStringsContent = Utils.GetDataFromWeb(
                    $"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language}/Almanac/DetailStringsTranslate.json"
                )
               .Result;

            if (detailStringsContent != null)
                LoadDetailStrings(detailStringsContent);
            else
            {
                var path = Path.Combine(almanacDir, "DetailStringsTranslate.json");

                if (File.Exists(path))
                    LoadDetailStrings(File.ReadAllText(path));
            }

            // load travel_buffs

            LoadTravelBuffs();

            // load abyss buffs

            //Patches.Modes.Abyss.AbyssBuffMenu_Patch.LoadAbyssBuffData();

            SaveStrings();
            DumpJson();
        }
        else
        {
            if (!Directory.Exists(stringDir))
                Directory.CreateDirectory(stringDir);

            try
            {
                foreach (var filepath in Directory.EnumerateFiles(stringDir, "*.json", SearchOption.AllDirectories))
                {
                    var fileName = Path.GetFileNameWithoutExtension(filepath);
                    StringStore.StringsDict[fileName] = filepath;

                    if (ModFeatures.IsDebug)
                        Log.LogInfo("Loading File : " + filepath);

                    var jsonString = File.ReadAllText(filepath);

                    if (fileName.EndsWith("translation_strings"))
                        LoadTranslationStrings(jsonString);
                    else if (fileName.EndsWith("translation_regexs"))
                        LoadTranslationRegexs(jsonString);
                    else if (fileName.EndsWith("customlevel_strings"))
                        LoadCustomLevelStrings(jsonString);
                    else if (fileName.EndsWith("customlevel_regexs"))
                        LoadCustomLevelRegexs(jsonString);
                    else if (fileName.EndsWith("tips_iz"))
                        LoadIZStrings(jsonString);
                    else if (fileName.EndsWith("tips_fs"))
                        LoadFsStrings(jsonString);
                    //else if(fileName.EndsWith("abyss_buffs"))
                    //{
                    //	Patches.Modes.Abyss.AbyssBuffMenu_Patch.LoadAbyssBuffData();
                    //}
                    else if (fileName.EndsWith("travel_buffs"))
                        LoadTravelBuffs();
                }

                var almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);

                if (!Directory.Exists(almanacDir))
                    Directory.CreateDirectory(almanacDir);

                var plantAlmanacPath = Path.Combine(almanacDir, "LawnStringsTranslate.json");

                if (File.Exists(plantAlmanacPath))
                    AlmanacPlantMenu_Patch.LoadPlantAlmanacData(File.ReadAllText(plantAlmanacPath));

                var zombieAlmanacPath = Path.Combine(almanacDir, "ZombieStringsTranslate.json");

                if (File.Exists(zombieAlmanacPath))
                    AlmanacZombieMenu_Patch.AlmanacJson = File.ReadAllText(zombieAlmanacPath);

                var detailStringsPath = Path.Combine(almanacDir, "DetailStringsTranslate.json");

                if (File.Exists(detailStringsPath))
                    LoadDetailStrings(File.ReadAllText(detailStringsPath));

                LoadChangelogText();

                SaveStrings();
                DumpJson();
            }
            catch (Exception e)
            {
                Log.LogError("Error loading string.");
                Log.LogError(e.GetType() + " " + e.Message);
            }
        }

        Log.LogInfo("Strings loaded successfully.");
    }

    internal static void LoadTranslationStrings(string content)
    {
        var dictionary =
            System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(content);

        foreach (var (key, value) in dictionary)
            StringStore.TranslationString[key] = value;
    }

    internal static void LoadTranslationRegexs(string content)
    {
        var dictionary =
            System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(content);

        foreach (var (key, value) in dictionary)
            StringStore.TranslationStringRegex[key] = value;

        Zombie_Patch.LoadHpStrings();
    }

    internal static void LoadCustomLevelStrings(string content)
    {
        var dictionary =
            System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(content);

        foreach (var (key, value) in dictionary)
            StringStore.CustomLevelString[key] = value;
    }

    internal static void LoadCustomLevelRegexs(string content)
    {
        var dictionary =
            System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(content);

        foreach (var (key, value) in dictionary)
            StringStore.CustomLevelStringRegex[key] = value;
    }

    internal static void LoadIZStrings(string content)
    {
        var (izLevelData, _) = DumpIZStrings();

        var izTranslatedTips = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(content);

        foreach (var level in izLevelData)
        {
            var data = level.text;
            var levelData = JsonUtility.FromJson<Il2CppLevelData>(data);

            if (levelData.tips == null)
                continue;

            if (!izTranslatedTips.ContainsKey(level.name) ||
                StringStore.IZTipCollectionString.ContainsKey(levelData.tips))
                continue;

            StringStore.IZLevelTipDictionary.Add(level.name, izTranslatedTips[level.name]);
            StringStore.IZTipCollectionString.Add(levelData.tips, izTranslatedTips[level.name]);
        }
    }

    internal static void LoadFsStrings(string content)
    {
        var (fusionShowcaseData, _) = DumpFSStrings();

        var fsTranslatedTips = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(content);

        foreach (var level in fusionShowcaseData)
        {
            var data = level.text;
            var levelData = JsonUtility.FromJson<Il2CppLevelData>(data);

            if (levelData.tips == null)
                continue;

            if (!fsTranslatedTips.ContainsKey(level.name) ||
                StringStore.FSTipCollectionString.ContainsKey(levelData.tips))
                continue;

            StringStore.FSLevelTipDictionary.Add(level.name, fsTranslatedTips[level.name]);
            StringStore.FSTipCollectionString.Add(levelData.tips, fsTranslatedTips[level.name]);
        }
    }

    internal static void LoadDetailStrings(string content)
    {
        var (detailStringsData, _) = DumpDetailStrings();

        var translatedDetailStrings = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(content);
        AlmanacSelectMenu_Patch.DetailStrings = translatedDetailStrings;

        foreach (var detailString in detailStringsData.details)
            if (translatedDetailStrings.TryGetValue(detailString.title, out var s))
                AlmanacSelectMenu_Patch.DetailTranslateStrings[detailString.text] = s;
    }

    internal static void LoadChangelogText()
    {
        var stringDir = GetAssetDir(AssetType.Strings, Utils.Language);
        var changelogDir = Path.Combine(stringDir, "changelog.txt");

        if (!File.Exists(changelogDir))
            File.WriteAllText(changelogDir, "");

        var changelogText = File.ReadAllText(changelogDir);

        if (!Core.Instance.ConfigUseLocal.Value)
        {
            var changelogContent = Utils.GetDataFromWeb(
                    $"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language}/Strings/changelog.txt"
                )
               .Result;

            if (changelogContent != null)
                changelogText = changelogContent;
        }
        else
            changelogText = File.ReadAllText(changelogDir);

        NoticePauseMenu_Patch.ChangelogText = changelogText;
    }

    internal static void LoadTravelBuffs()
    {
        if (!Core.Instance.ConfigUseLocal.Value)
        {
            var travelBuffsContent = Utils.GetDataFromWeb(
                    $"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language}/Strings/travel_buffs.json"
                )
               .Result;

            if (travelBuffsContent != null)
                TravelMgr_Patch.GenerateTranslatedTravelBuffs(travelBuffsContent);
            else
            {
                var travelBuffsPath = Path.Combine(
                    GetAssetDir(AssetType.Strings, Utils.Language),
                    "travel_buffs.json"
                );

                if (File.Exists(travelBuffsPath))
                    TravelMgr_Patch.GenerateTranslatedTravelBuffs(File.ReadAllText(travelBuffsPath));
            }
        }
        else
        {
            var stringDir = GetAssetDir(AssetType.Strings, Utils.Language);

            foreach (var jsonString in from filepath in
                    Directory.EnumerateFiles(stringDir, "*.json", SearchOption.AllDirectories)
                let fileName = Path.GetFileNameWithoutExtension(filepath)
                let jsonString = File.ReadAllText(filepath)
                where fileName.EndsWith("travel_buffs")
                select jsonString)
                TravelMgr_Patch.GenerateTranslatedTravelBuffs(jsonString);
        }
    }

    internal static void LoadTextures()
    {
        // Default or Custom Texturse -> English Textures -> Localized Textures
        try
        {
            if (!Core.Instance.ConfigDefaultTextures.Value)
                LoadCustomTextures();
        }
        catch (Exception e)
        {
            Log.LogError("Error loading texture setting.");
            Log.LogError($"{e.GetType()} {e.Message}");
        }

        if (ModFeatures.IsMultiLanguage)
        {
            LoadLocalizedTextures(Utils.Language);
            LoadLocalizedSprites(Utils.Language);
        }
        else
            LoadLocalizedTextures();

        Log.LogInfo("Textures loaded successfully.");
    }

    // ReSharper disable once FunctionComplexityOverflow
    internal static void LoadLocalizedTextures(Utils.LanguageEnum? language = null)
    {
        var textureDir = GetAssetDir(AssetType.Textures, language);

        if (!Directory.Exists(textureDir))
            Directory.CreateDirectory(textureDir);

        try
        {
            var localTocDir = Path.Combine(textureDir, "Texture_TOC.json");

            if (!File.Exists(localTocDir))
                File.WriteAllText(localTocDir, "{}");

            var localTocContent = File.ReadAllText(localTocDir);
            var localToc = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(localTocContent);

            var basePath = Core.ModDirectory;

            if (!Core.Instance.ConfigUseLocal.Value)
            {
                var textureTocRequest = Utils.GetDataFromWeb(
                        $"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language}/Textures/Texture_TOC.json"
                    )
                   .Result;

                if (textureTocRequest != null)
                {
                    var textureToc =
                        JsonConvert.DeserializeObject<Dictionary<string, string>>(textureTocRequest);

                    List<string> toDownload = new();

                    foreach (var pair in textureToc)
                    {
                        if (!localToc.TryGetValue(pair.Key, out var value))
                        {
                            toDownload.Add(pair.Key);
                            continue;
                        }

                        if (pair.Value != value)
                            toDownload.Add(pair.Key);

                        if (!File.Exists(Path.Combine(basePath, pair.Key)))
                            toDownload.Add(pair.Key);
                    }

                    var toWriteText = SerializeWithIndentation(textureToc);
                    File.WriteAllText(localTocDir, toWriteText);

                    foreach (var path in toDownload)
                    {
                        var downloadPath = Path.Combine(basePath, path);

                        const string BaseUrl =
                            "https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/";

                        var imageData = Utils.GetByteDataFromWeb($"{BaseUrl}{path}").Result;

                        if (imageData == null)
                            continue;

                        var fileName = Path.GetFileName(downloadPath);
                        _ = Utils.LoadImage(imageData);
                        TextureStore.TextureDict[fileName] = imageData;

                        if (!Directory.Exists(Path.GetDirectoryName(downloadPath)))
                            Directory.CreateDirectory(Path.GetDirectoryName(downloadPath));

                        File.WriteAllBytes(downloadPath, imageData);
                    }
                }
            }

            foreach (var path in Directory.EnumerateFiles(textureDir, "*.png", SearchOption.AllDirectories)
               .Where(
                    p => (!p.Contains("[Custom Textures]", StringComparison.OrdinalIgnoreCase) ||
                            !Core.Instance.ConfigDefaultTextures.Value) &&
                        (localToc.ContainsKey(p.Replace(basePath + "\\", "").Replace("\\", "/")) ||
                            SerializeWithIndentation(localToc) == "{}")
                ))
            {
                if (ModFeatures.IsDebug)
                    Log.LogDebug("Loading File : " + path);

                var imageData = File.ReadAllBytes(path);
                _ = Utils.LoadImage(imageData);
                TextureStore.TextureDict[Path.GetFileNameWithoutExtension(path)] = imageData;
            }
        }

        catch (Exception e)
        {
            Log.LogError("Error loading Texture.");
            Log.LogError(e.GetType() + " " + e.Message);
        }
    }

    // ReSharper disable once FunctionComplexityOverflow
    internal static void LoadLocalizedSprites(Utils.LanguageEnum? language = null)
    {
        var textureDir = GetAssetDir(AssetType.Sprites, language);

        if (!Directory.Exists(textureDir))
            Directory.CreateDirectory(textureDir);

        try
        {
            var trueTextureDir = GetAssetDir(AssetType.Textures, language);
            var localTocDir = Path.Combine(trueTextureDir, "Texture_TOC.json");

            if (!File.Exists(localTocDir))
                File.WriteAllText(localTocDir, "{}");

            var localTocContent = File.ReadAllText(localTocDir);
            var localToc = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(localTocContent);

            var basePath = Core.ModDirectory;

            if (!Core.Instance.ConfigUseLocal.Value)
            {
                var textureTocRequest = Utils.GetDataFromWeb(
                        $"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language}/Textures/Texture_TOC.json"
                    )
                   .Result;

                if (textureTocRequest != null)
                {
                    var textureToc =
                        JsonConvert.DeserializeObject<Dictionary<string, string>>(textureTocRequest);

                    List<string> toDownload = new();

                    foreach (var pair in textureToc)
                    {
                        if (!localToc.TryGetValue(pair.Key, out var value))
                        {
                            toDownload.Add(pair.Key);
                            continue;
                        }

                        if (pair.Value != value)
                            toDownload.Add(pair.Key);

                        if (!File.Exists(Path.Combine(basePath, pair.Key)))
                            toDownload.Add(pair.Key);
                    }

                    var toWriteText = SerializeWithIndentation(textureToc);
                    File.WriteAllText(localTocDir, toWriteText);

                    foreach (var path in toDownload)
                    {
                        var downloadPath = Path.Combine(basePath, path);

                        const string BaseUrl =
                            "https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/";

                        var url = $"{BaseUrl}{path}";

                        var imageData = Utils.GetByteDataFromWeb(url).Result;

                        if (imageData == null)
                            continue;

                        var fileName = Path.GetFileName(downloadPath);
                        _ = Utils.LoadImage(imageData);
                        TextureStore.SpriteDict[fileName] = imageData;

                        if (!Directory.Exists(Path.GetDirectoryName(downloadPath)))
                            Directory.CreateDirectory(Path.GetDirectoryName(downloadPath));

                        File.WriteAllBytes(downloadPath, imageData);
                    }
                }
            }

            foreach (var path in Directory.EnumerateFiles(textureDir, "*.png", SearchOption.AllDirectories)
               .Where(
                    p => (!p.Contains("[Custom Textures]", StringComparison.OrdinalIgnoreCase) ||
                            !Core.Instance.ConfigDefaultTextures.Value) &&
                        (localToc.ContainsKey(p.Replace(basePath + "\\", "").Replace("\\", "/")) ||
                            SerializeWithIndentation(localToc) == "{}")
                ))
            {
                if (ModFeatures.IsDebug)
                    Log.LogDebug("Loading File (Sprite): " + path);

                var imageData = File.ReadAllBytes(path);
                _ = Utils.LoadImage(imageData);
                TextureStore.SpriteDict[Path.GetFileNameWithoutExtension(path)] = imageData;
            }
        }

        catch (Exception e)
        {
            Log.LogError("Error loading Texture.");
            Log.LogError(e.GetType() + " " + e.Message);
        }
    }

    internal static void LoadDefaultTextures()
    {
        if (!Core.Instance.ConfigDefaultTextures.Value)
            return;

        var textureDefaultDir = Path.Combine(
            Core.ModDirectory,
            nameof(AssetType.Dumps),
            "Default Textures [Do Not Remove]"
        );

        if (!Directory.Exists(textureDefaultDir))
            Directory.CreateDirectory(textureDefaultDir);

        try
        {
            var trueTextureDir = Path.Combine(Core.ModDirectory, "[Custom Textures]");
            var localTocDir = Path.Combine(trueTextureDir, "Default_TOC.json");

            if (!File.Exists(localTocDir))
                File.WriteAllText(localTocDir, "{}");

            var localTocContent = File.ReadAllText(localTocDir);
            var localToc = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(localTocContent);

            var basePath = Core.ModDirectory;

            if (!Core.Instance.ConfigUseLocal.Value)
            {
                var textureTocRequest = Utils.GetDataFromWeb(
                        $"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/{Uri.EscapeDataString("[Custom Textures]")}/Default_TOC.json"
                    )
                   .Result;

                if (textureTocRequest != null)
                {
                    var textureToc =
                        JsonConvert.DeserializeObject<Dictionary<string, string>>(textureTocRequest);

                    List<string> toDownload = new();

                    foreach (var pair in textureToc)
                    {
                        if (!localToc.TryGetValue(pair.Key, out var value))
                        {
                            toDownload.Add(pair.Key);
                            continue;
                        }

                        if (pair.Value != value)
                            toDownload.Add(pair.Key);

                        if (!File.Exists(Path.Combine(basePath, pair.Key)))
                            toDownload.Add(pair.Key);
                    }

                    var toWriteText = SerializeWithIndentation(textureToc);
                    File.WriteAllText(localTocDir, toWriteText);

                    foreach (var path in toDownload)
                    {
                        var downloadPath = Path.Combine(basePath, path);

                        const string BaseUrl =
                            "https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/";

                        var url = $"{BaseUrl}{path}";

                        var imageData = Utils.GetByteDataFromWeb(url).Result;

                        if (imageData == null)
                            continue;

                        var fileName = Path.GetFileName(downloadPath);
                        _ = Utils.LoadImage(imageData);
                        TextureStore.TextureDict[fileName] = imageData;

                        if (!Directory.Exists(Path.GetDirectoryName(downloadPath)))
                            Directory.CreateDirectory(Path.GetDirectoryName(downloadPath));

                        File.WriteAllBytes(downloadPath, imageData);
                    }
                }
            }

            foreach (var filepath in Directory.EnumerateFiles(
                textureDefaultDir,
                "*.png",
                SearchOption.AllDirectories
            ))
            {
                if (!localToc.ContainsKey(filepath.Replace(basePath + "\\", "").Replace("\\", "/")) &&
                    SerializeWithIndentation(localToc) != "{}")
                    continue;

                var imageData = File.ReadAllBytes(filepath);
                _ = Utils.LoadImage(imageData);
                TextureStore.TextureDict[Path.GetFileNameWithoutExtension(filepath)] = imageData;
            }
        }

        catch (Exception e)
        {
            Log.LogError("Error loading Texture.");
            Log.LogError(e.GetType() + " " + e.Message);
        }
    }

    internal static void LoadCustomTextures()
    {
        var texturePackDir = Path.Combine(Core.ModDirectory, "[Custom Textures]");

        if (!Directory.Exists(texturePackDir))
            Directory.CreateDirectory(texturePackDir);

        try
        {
            var trueTextureDir = Path.Combine(Core.ModDirectory, "[Custom Textures]");
            var localTocDir = Path.Combine(trueTextureDir, "Custom_TOC.json");

            if (!File.Exists(localTocDir))
                File.WriteAllText(localTocDir, "{}");

            var localTocContent = File.ReadAllText(localTocDir);
            var localToc = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(localTocContent);

            var basePath = Core.ModDirectory;

            if (!Core.Instance.ConfigUseLocal.Value)
            {
                var textureTocRequest = Utils.GetDataFromWeb(
                        $"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/{Uri.EscapeDataString("[Custom Textures]")}/Custom_TOC.json"
                    )
                   .Result;

                if (textureTocRequest != null)
                {
                    var textureToc =
                        JsonConvert.DeserializeObject<Dictionary<string, string>>(textureTocRequest);

                    List<string> toDownload = new();

                    foreach (var pair in textureToc)
                    {
                        if (!localToc.TryGetValue(pair.Key, out var value) || pair.Value != value)
                        {
                            toDownload.Add(pair.Key);
                            continue;
                        }

                        if (!File.Exists(Path.Combine(basePath, pair.Key)))
                            toDownload.Add(pair.Key);
                    }

                    var toWriteText = SerializeWithIndentation(textureToc);
                    File.WriteAllText(localTocDir, toWriteText);

                    foreach (var path in toDownload)
                    {
                        var downloadPath = Path.Combine(basePath, path);

                        const string BaseUrl =
                            "https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/";

                        var url = $"{BaseUrl}{path}";

                        var imageData = Utils.GetByteDataFromWeb(url).Result;

                        if (imageData == null)
                            continue;

                        var fileName = Path.GetFileName(downloadPath);
                        _ = Utils.LoadImage(imageData);
                        TextureStore.TextureDict[fileName] = imageData;

                        if (!Directory.Exists(Path.GetDirectoryName(downloadPath)))
                            Directory.CreateDirectory(Path.GetDirectoryName(downloadPath));

                        File.WriteAllBytes(downloadPath, imageData);
                    }
                }
            }

            foreach (var filepath in Directory.EnumerateFiles(texturePackDir, "*.png", SearchOption.AllDirectories))
            {
                if (!localToc.ContainsKey(filepath.Replace(basePath + "\\", "").Replace("\\", "/")) &&
                    SerializeWithIndentation(localToc) != "{}")
                    continue;

                var imageData = File.ReadAllBytes(filepath);
                _ = Utils.LoadImage(imageData);
                TextureStore.TextureDict[Path.GetFileNameWithoutExtension(filepath)] = imageData;
            }
        }

        catch (Exception e)
        {
            Log.LogError("Error loading Texture.");
            Log.LogError(e.GetType() + " " + e.Message);
        }
    }

    internal static void SaveStrings()
    {
        var stringDir = GetAssetDir(AssetType.Strings, ModFeatures.IsMultiLanguage ? Utils.Language : null);

        if (!Directory.Exists(stringDir))
            Directory.CreateDirectory(stringDir);

        // save regexs

        var translationStringRegex = SerializeWithIndentation(StringStore.TranslationStringRegex, 2);

        File.WriteAllText(Path.Combine(stringDir, "translation_regexs.json"), translationStringRegex);

        // save strings

        var translationString = SerializeWithIndentation(StringStore.TranslationString, 2);

        File.WriteAllText(Path.Combine(stringDir, "translation_strings.json"), translationString);

        // save iz tips

        var izTipCollectionString = SerializeWithIndentation(StringStore.IZLevelTipDictionary, 1, '	');

        File.WriteAllText(Path.Combine(stringDir, "tips_iz.json"), izTipCollectionString);

        // save fs tips

        var fsLevelTipDictionary = SerializeWithIndentation(StringStore.FSLevelTipDictionary);

        File.WriteAllText(Path.Combine(stringDir, "tips_fs.json"), fsLevelTipDictionary);

        // save changelog

        if (NoticePauseMenu_Patch.ChangelogText != "")
            File.WriteAllText(Path.Combine(stringDir, "changelog.txt"), NoticePauseMenu_Patch.ChangelogText);

        // save abyss buffs

        //if(Patches.Modes.Abyss.AbyssBuffMenu_Patch.abyssBuffData != new Dictionary<string, string>())
        //{
        //	string abyssBuffData = SerializeWithIndentation(Patches.Modes.Abyss.AbyssBuffMenu_Patch.abyssBuffData, 2);
        //	File.WriteAllText(Path.Combine(stringDir, "abyss_buffs.json"), abyssBuffData);
        //}

        // save almanacs

        var almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);

        if (AlmanacPlantMenu_Patch.AlmanacJson != "")
            File.WriteAllText(
                Path.Combine(almanacDir, "LawnStringsTranslate.json"),
                AlmanacPlantMenu_Patch.AlmanacJson
            );

        if (AlmanacZombieMenu_Patch.AlmanacJson != "")
            File.WriteAllText(
                Path.Combine(almanacDir, "ZombieStringsTranslate.json"),
                AlmanacZombieMenu_Patch.AlmanacJson
            );

        if (AlmanacSelectMenu_Patch.DetailStrings == new Dictionary<string, string>())
            return;

        var detailStrings = SerializeWithIndentation(AlmanacSelectMenu_Patch.DetailStrings);

        File.WriteAllText(Path.Combine(almanacDir, "DetailStringsTranslate.json"), detailStrings);
    }

    public static string SerializeWithIndentation<T>(T value, int size = 4, char indentChar = ' ')
    {
        var stringWriter = new StringWriter();

        using (JsonTextWriter writer = new(stringWriter))
        {
            writer.Formatting = Formatting.Indented;
            writer.Indentation = size;
            writer.IndentChar = indentChar;

            Newtonsoft.Json.JsonSerializer serializer = new();
            serializer.Serialize(writer, value, typeof(T));
        }

        return stringWriter.ToString();
    }

    public static void DumpJson()
    {
        var dumpDir = GetAssetDir(AssetType.Dumps);

        if (!Directory.Exists(dumpDir))
            Directory.CreateDirectory(dumpDir);

        var lawnStrings = Resources.Load<TextAsset>("LawnStrings").text;
        var zombieStrings = Resources.Load<TextAsset>("ZombieStrings").text;
        //string AbyssBuffData = Resources.Load<TextAsset>("AbyssBuffData").text;
        File.WriteAllText(Path.Combine(dumpDir, "LawnStrings.json"), lawnStrings);
        File.WriteAllText(Path.Combine(dumpDir, "ZombieStrings.json"), zombieStrings);
        //File.WriteAllText(Path.Combine(dumpDir, "AbyssBuffData.json"), AbyssBuffData);

        // Dump IZ tips.
        var (_, izLevelDataDump) = DumpIZStrings();

        File.WriteAllText(
            Path.Combine(dumpDir, "tips_iz.json"),
            System.Text.Json.JsonSerializer.Serialize(
                izLevelDataDump,
                new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                }
            )
        );

        // Dump fusion showcase tips.
        var (_, fusionShowcaseDataDump) = DumpFSStrings();

        File.WriteAllText(
            Path.Combine(dumpDir, "tips_fs.json"),
            System.Text.Json.JsonSerializer.Serialize(
                fusionShowcaseDataDump,
                new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                }
            )
        );

        // Dump almanac mechanics.
        var (_, detailStrings) = DumpDetailStrings();

        File.WriteAllText(
            Path.Combine(dumpDir, "DetailStrings.json"),
            System.Text.Json.JsonSerializer.Serialize(
                detailStrings,
                new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                }
            )
        );
    }

    public static (Il2CppArrayBase<TextAsset>, Dictionary<string, string>) DumpIZStrings()
    {
        var izLevelData = Resources.LoadAll<TextAsset>("izleveldata");
        var izLevelDataDump = new Dictionary<string, string>();

        foreach (var level in izLevelData)
        {
            var data = level.text;
            var levelData = JsonUtility.FromJson<Il2CppLevelData>(data);

            if (levelData.tips != null)
                izLevelDataDump.Add(level.name, levelData.tips);
        }

        return (izLevelData, izLevelDataDump);
    }

    public static (Il2CppArrayBase<TextAsset>, Dictionary<string, string>) DumpFSStrings()
    {
        var fusionShowcaseData = Resources.LoadAll<TextAsset>("leveldata/explore");
        var fusionShowcaseDataDump = new Dictionary<string, string>();

        foreach (var level in fusionShowcaseData)
        {
            var data = level.text;
            var levelData = JsonUtility.FromJson<Il2CppLevelData>(data);

            if (levelData.tips != null)
                fusionShowcaseDataDump.Add(level.name, levelData.tips);
        }

        return (fusionShowcaseData, fusionShowcaseDataDump);
    }

    public static (Il2CppAlmanacDataClass, Dictionary<string, string>) DumpDetailStrings()
    {
        var detailStringsData = Resources.Load<TextAsset>("detailstrings").text;
        var detailStrings = JsonUtility.FromJson<Il2CppAlmanacDataClass>(detailStringsData);
        Dictionary<string, string> detailStringsDump = new();

        foreach (var detailString in detailStrings.details)
            detailStringsDump[detailString.title] = detailString.text;

        return (detailStrings, detailStringsDump);
    }

    public static void DumpUntranslatedStrings(string text)
    {
        Debug.Assert(ModFeatures.IsDebug, nameof(ModFeatures.IsDebug));
        Log.LogDebug($"Untranslated String: {text}");
        var dumpDir = GetAssetDir(AssetType.Dumps);
        var jsonFile = Path.Combine(dumpDir, "UntranslatedStrings.json");

        if (!Directory.Exists(dumpDir))
            Directory.CreateDirectory(dumpDir);

        if (!File.Exists(jsonFile))
            File.WriteAllText(jsonFile, "{}"); // Initialize empty JSON object

        var json = File.ReadAllText(jsonFile);
        var untranslatedStrings = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(json);

        if (!untranslatedStrings.TryAdd(text, text))
            return;

        JsonSerializerOptions options = new()
        {
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            WriteIndented = true,
        };

        File.WriteAllText(jsonFile, System.Text.Json.JsonSerializer.Serialize(untranslatedStrings, options));
    }

    internal static void LoadLanguage()
    {
        Debug.Assert(ModFeatures.IsMultiLanguage, nameof(ModFeatures.IsMultiLanguage));

        try
        {
            // Load the language preference as a string and parse it into the enum
            var languageName = Core.Instance.ConfigLanguage.Value;

            if (Enum.TryParse(languageName, out Utils.LanguageEnum loadedLanguage))
                Utils.Language = loadedLanguage;
            else
            {
                Log.LogWarning($"Invalid language '{languageName}' found in preferences. Falling back to English.");
                Utils.Language = Utils.LanguageEnum.English; // Default fallback
            }

            Log.LogWarning($"Loaded language {languageName}");
        }
        catch (Exception e)
        {
            Log.LogError("Error loading language setting.");
            Log.LogError($"{e.GetType()} {e.Message}");
        }

        Log.LogInfo($"Language has been loaded: {Utils.Language}");
    }

    internal static void SaveLanguage()
    {
        Debug.Assert(ModFeatures.IsMultiLanguage, nameof(ModFeatures.IsMultiLanguage));

        try
        {
            // Save the current language as a string
            Core.Instance.ConfigLanguage.Value = Utils.Language.ToString();

            // Ensure changes are written to the config file
            // MelonPreferences.Save();
        }
        catch (Exception e)
        {
            Log.LogError("Error saving language setting.");
            Log.LogError($"{e.GetType()} {e.Message}");
        }
        // Log.LogInfo($"Language has been saved: {Utils.Language}");
    }
}
