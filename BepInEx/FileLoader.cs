using BepInEx.Configuration;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches;
using PvZ_Fusion_Translator__BepInEx_.Patches.OtherManagers;
using PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;
using UnityEngine;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace PvZ_Fusion_Translator__BepInEx_
{
    internal static class FileLoader
    {
        internal enum AssetType
        {
            Textures,
            Strings,
            Dumps,
            Almanac,
            Sprites
        }

        public static string GetAssetDir(AssetType assetType, Utils.LanguageEnum? language = null)
        {
            string languagePath = language.HasValue ? ("Localization" + Path.DirectorySeparatorChar + language.ToString()) : string.Empty;
            return Path.Combine(PluginCore.Instance.modsDirectory, languagePath, assetType.ToString());
        }

#if MULTI_LANGUAGE
        internal static void LoadStrings() => LoadStrings(Utils.Language);

        internal static void LoadStrings(Utils.LanguageEnum language)
#else
		internal static void LoadStrings(bool isLog = false)
#endif
        {
#if MULTI_LANGUAGE
            Utils.LanguageEnum currentLang = language;
            string stringDir = GetAssetDir(AssetType.Strings, currentLang);
#else
			string stringDir = GetAssetDir(AssetType.Strings);
#endif
            if (!Directory.Exists(stringDir))
            {
                Directory.CreateDirectory(stringDir);
            }
            try
            {
                foreach (string filepath in Directory.EnumerateFiles(stringDir, "*.json", SearchOption.AllDirectories))
                {

#if OBFUSCATE
					if (CheckSumStore.IsModified(filepath))
					{
						Log.LogError("File {0} was modified!" , filepath);
						continue;
					}
#endif

                    string fileName = Path.GetFileNameWithoutExtension(filepath);
                    StringStore.stringsDict[fileName] = filepath;
#if DEBUG
                    Log.LogInfo("Loading File : " + filepath);
#endif
                    string jsonString = File.ReadAllText(filepath);
                    if (fileName.EndsWith("_strings"))
                    {
                        Dictionary<string, string> dictionary = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);
                        foreach (var (key, value) in dictionary)
                        {
                            StringStore.translationString[key] = value;
                        }
                    }
                    else if (fileName.EndsWith("_regexs"))
                    {
                        Dictionary<string, string> dictionary = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);
                        foreach (var (key, value) in dictionary)
                        {
                            StringStore.translationStringRegex[key] = value;
                        }
                    }
                    else if (fileName.EndsWith("travel_buffs"))
                    {
                        try
                        {
                            var parsed = TravelMgr_Patch.ParseBuffJson(jsonString);
                            if (parsed != null && parsed.Count > 0
                                && parsed.Any(c => c.Value != null && c.Value.Count > 0))
                            {
                                TravelMgr_Patch.translatedTravelBuffs = parsed;
                                TravelMgr_Patch.RebuildTravelBuffString();
                            }
                        }
                        catch (Exception ex)
                        {
                            Log.LogWarning("[FileLoader] travel_buffs parse failed: " + ex.Message);
                        }
                    }
                    else if (fileName.EndsWith("tips_iz"))
                    {
                        LoadIZStrings(jsonString);
                    }
                    else if (fileName.EndsWith("tips_fs"))
                    {
                        LoadFSStrings(jsonString);
                    }
                    else if (fileName.EndsWith("abyss_buffs"))
                    {
                        AbyssBuffStore.LoadAbyssBuffData();
                    }
                }
                SaveStrings();
                DumpJson();
            }
            catch (Exception e)
            {
                Log.LogError("Error loading string.");
                Log.LogError(e.GetType() + " " + e.Message);
            }
            Log.LogInfo("Strings loaded successfully.");

            LoadTravelBuffs();
            LoadAlmanac();
            SaveAlmanacFiles();
        }

        internal static void LoadAlmanac()
        {
            try
            {
#if MULTI_LANGUAGE
                Utils.LanguageEnum currentLang = Utils.Language;
                Log.LogInfo($"[LoadAlmanac] Loading for language: {currentLang}");

                string almanacDir = GetAssetDir(AssetType.Almanac, currentLang);
                if (!Directory.Exists(almanacDir))
                {
                    Directory.CreateDirectory(almanacDir);
                }

                string plantPath = Path.Combine(almanacDir, "LawnStringsTranslate.json");
                if (File.Exists(plantPath))
                {
                    AlmanacPlantMenu_Patch.almanacJson = File.ReadAllText(plantPath);
                    Log.LogInfo($"[LoadAlmanac] Loaded plant almanac from: {plantPath}");
                }
                else
                {
                    Log.LogWarning($"[LoadAlmanac] Plant almanac not found at: {plantPath}");
                }

                string zombiePath = Path.Combine(almanacDir, "ZombieStringsTranslate.json");
                if (File.Exists(zombiePath))
                {
                    AlmanacZombieMenu_Patch.almanacJson = File.ReadAllText(zombiePath);
                    Log.LogInfo($"[LoadAlmanac] Loaded zombie almanac from: {zombiePath}");
                }
                else
                {
                    Log.LogWarning($"[LoadAlmanac] Zombie almanac not found at: {zombiePath}");
                }

                string moddedPlantPath = Path.Combine(almanacDir, "ModdedPlantsTranslate.json");
                if (File.Exists(moddedPlantPath))
                {
                    string moddedContent = File.ReadAllText(moddedPlantPath);
                    if (!string.IsNullOrEmpty(moddedContent) && !string.IsNullOrEmpty(AlmanacPlantMenu_Patch.almanacJson))
                    {
                        try
                        {
                            var plantData = System.Text.Json.JsonSerializer.Deserialize<System.Text.Json.JsonElement>(moddedContent);
                            if (plantData.TryGetProperty("plants", out var plants) && plants.ValueKind == System.Text.Json.JsonValueKind.Array)
                            {
                                Log.LogInfo($"[LoadAlmanac] Loaded modded plants");
                            }
                        }
                        catch (Exception ex)
                        {
                            Log.LogError($"[LoadAlmanac] Failed to parse modded plants: {ex.Message}");
                        }
                    }
                }

                string moddedZombiePath = Path.Combine(almanacDir, "ModdedZombiesTranslate.json");
                if (File.Exists(moddedZombiePath))
                {
                    string moddedContent = File.ReadAllText(moddedZombiePath);
                    if (!string.IsNullOrEmpty(moddedContent) && !string.IsNullOrEmpty(AlmanacZombieMenu_Patch.almanacJson))
                    {
                        try
                        {
                            var zombieData = System.Text.Json.JsonSerializer.Deserialize<System.Text.Json.JsonElement>(moddedContent);
                            if (zombieData.TryGetProperty("zombies", out var zombies) && zombies.ValueKind == System.Text.Json.JsonValueKind.Array)
                            {
                                Log.LogInfo($"[LoadAlmanac] Loaded modded zombies");
                            }
                        }
                        catch (Exception ex)
                        {
                            Log.LogError($"[LoadAlmanac] Failed to parse modded zombies: {ex.Message}");
                        }
                    }
                }

                string detailStringsPath = Path.Combine(almanacDir, "DetailStringsTranslate.json");
                if (File.Exists(detailStringsPath))
                {
                    LoadDetailStrings(File.ReadAllText(detailStringsPath));
                }
#endif
            }
            catch (Exception e)
            {
                Log.LogError("Error loading almanac: " + e.Message);
            }
        }

        internal static void LoadTravelBuffs()
        {
            try
            {
#if MULTI_LANGUAGE
                string travelBuffsPath = Path.Combine(GetAssetDir(AssetType.Strings, Utils.Language), "travel_buffs.json");
                int localCount = 0;
                bool localOk = false;
                if (File.Exists(travelBuffsPath))
                {
                    try
                    {
                        var loaded = TravelMgr_Patch.LoadBuffFile(travelBuffsPath);
                        if (loaded != null)
                        {
                            TravelMgr_Patch.translatedTravelBuffs = loaded;
                            TravelMgr_Patch.RebuildTravelBuffString();
                            foreach (var kv in TravelMgr_Patch.translatedTravelBuffs)
                                if (kv.Value != null) localCount += kv.Value.Count;
                            localOk = localCount > 0;
                            Log.LogInfo("[FileLoader] travel_buffs loaded locally: " + localCount + " entries");
                        }
                        else Log.LogWarning("[FileLoader] LoadBuffFile returned null");
                    }
                    catch (System.Exception ex2)
                    {
                        Log.LogWarning("[FileLoader] local load failed: " + ex2.Message);
                    }
                }

                if (!localOk && !Utils.useLocal)
                {
                    Log.LogInfo("[FileLoader] Attempting to download travel_buffs.json from GitHub");
                    string url = "https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/" + Utils.Language + "/Strings/travel_buffs.json";
                    string content = Utils.GetDataFromWeb(url).Result;
                    if (!string.IsNullOrEmpty(content))
                    {
                        try
                        {
                            var loaded = TravelMgr_Patch.ParseBuffJson(content);
                            if (loaded != null && loaded.Count > 0)
                            {
                                bool hasEntries = false;
                                foreach (var kv in loaded)
                                    if (kv.Value != null && kv.Value.Count > 0) { hasEntries = true; break; }
                                if (hasEntries)
                                {
                                    TravelMgr_Patch.translatedTravelBuffs = loaded;
                                    TravelMgr_Patch.RebuildTravelBuffString();
                                    int c = 0;
                                    foreach (var kv in TravelMgr_Patch.translatedTravelBuffs)
                                        if (kv.Value != null) c += kv.Value.Count;
                                    Log.LogInfo("[FileLoader] travel_buffs loaded from GitHub: " + c + " entries");
                                    try { File.WriteAllText(travelBuffsPath, content); } catch { }
                                }
                            }
                        }
                        catch (System.Exception ex3)
                        {
                            Log.LogWarning("[FileLoader] GitHub download parse failed: " + ex3.Message);
                        }
                    }
                    else
                    {
                        Log.LogWarning("[FileLoader] GitHub download returned empty content");
                    }
                }
#endif
            }
            catch (Exception e)
            {
                Log.LogError("Error loading travel buffs: " + e.Message);
            }
        }

        internal static void LoadTextures()
        {
            try
            {
                if (Utils.customTextures)
                {
                    LoadCustomTextures();
                }
                else
                {
                    LoadDefaultTextures();
                }
            }
            catch (Exception e)
            {
                Log.LogError("Error loading texture setting.");
                Log.LogError($"{e.GetType()} {e.Message}");
            }

#if MULTI_LANGUAGE
            LoadLocalizedTextures(Utils.Language);
            LoadLocalizedSprites(Utils.Language);
#else
			LoadLocalizedTextures();
#endif

            Log.LogInfo("Textures loaded successfully.");
        }

        internal static void LoadLocalizedTextures(Utils.LanguageEnum? language = null)
        {
            ConfigEntry<bool> defaultTextureEntry;
            PluginCore.Instance.Config.TryGetEntry<bool>(new ConfigDefinition("PvZ_Fusion_Translator", "DefaultTextures"), out defaultTextureEntry);

            string textureDir = GetAssetDir(AssetType.Textures, language);

            if (!Directory.Exists(textureDir))
            {
                Directory.CreateDirectory(textureDir);
            }
            try
            {
                foreach (string filepath in Directory.EnumerateFiles(textureDir, "*.png", SearchOption.AllDirectories))
                {
                    if (filepath.Contains("[Custom Textures]", StringComparison.OrdinalIgnoreCase) && defaultTextureEntry.Value)
                    {
                        continue;
                    }

#if OBFUSCATE
                    if (CheckSumStore.IsModified(filepath))
                    {
                        Log.LogError("File {0} was modified!" , filepath);
                        continue;
                    }
#endif

                    string key = Path.GetFileNameWithoutExtension(filepath);

#if DEBUG
                    Log.LogDebug("Loading Texture : " + filepath);
#endif

                    byte[] textureData = File.ReadAllBytes(filepath);

                    try
                    {
                        Texture2D testTexture = Utils.LoadImage(textureData);
                        if (testTexture != null)
                        {
                            TextureStore.textureDict[key] = textureData;
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.LogError($"Invalid texture {key}: {ex.Message}");
                    }
                }
            }

            catch (Exception e)
            {
                Log.LogError("Error loading Texture.");
                Log.LogError(e.GetType() + " " + e.Message);
            }
        }

        internal static void LoadLocalizedSprites(Utils.LanguageEnum? language = null)
        {
            ConfigEntry<bool> defaultTextureEntry;
            PluginCore.Instance.Config.TryGetEntry<bool>(new ConfigDefinition("PvZ_Fusion_Translator", "DefaultTextures"), out defaultTextureEntry);

            string spritesDir = GetAssetDir(AssetType.Sprites, language);
            if (!Directory.Exists(spritesDir))
            {
                Directory.CreateDirectory(spritesDir);
            }

            try
            {
                foreach (string filepath in Directory.EnumerateFiles(spritesDir, "*.png", SearchOption.AllDirectories))
                {
                    if (filepath.Contains("[Custom Textures]", StringComparison.OrdinalIgnoreCase) && defaultTextureEntry.Value)
                    {
                        continue;
                    }

                    string key = Path.GetFileNameWithoutExtension(filepath);

                    byte[] textureData = File.ReadAllBytes(filepath);

                    try
                    {
                        Texture2D testTexture = Utils.LoadImage(textureData);
                        if (testTexture != null)
                        {
                            TextureStore.spriteDict[key] = textureData;
                        }
                    }
                    catch { }
                }
            }
            catch (Exception e)
            {
                Log.LogError("Error loading Sprites.");
                Log.LogError(e.GetType() + " " + e.Message);
            }
        }

        internal static void LoadDefaultTextures()
        {
            if (PluginCore.Instance.configDefaultTextures.Value)
            {
                string textureDefaultDir = Path.Combine(PluginCore.Instance.modsDirectory, AssetType.Dumps.ToString(), "Default Textures [Do Not Remove]");
                if (!Directory.Exists(textureDefaultDir))
                {
                    Directory.CreateDirectory(textureDefaultDir);
                }
                try
                {
                    foreach (string filepath in Directory.EnumerateFiles(textureDefaultDir, "*.png", SearchOption.AllDirectories))
                    {

#if OBFUSCATE
                        if (CheckSumStore.IsModified(filepath))
                        {
                            Log.LogError("File {0} was modified!" , filepath);
                            continue;
                        }
#endif

                        byte[] textureData = File.ReadAllBytes(filepath);
                        string key = Path.GetFileNameWithoutExtension(filepath);

                        try
                        {
                            Texture2D testTexture = Utils.LoadImage(textureData);
                            if (testTexture != null)
                            {
                                TextureStore.textureDict[key] = textureData;
                            }
                        }
                        catch (Exception ex)
                        {
                            Log.LogError($"Invalid texture {key}: {ex.Message}");
                        }
                    }
                }

                catch (Exception e)
                {
                    Log.LogError("Error loading Texture.");
                    Log.LogError(e.GetType() + " " + e.Message);
                }
            }
        }

        internal static void LoadCustomTextures()
        {
            string texturePackDir = Path.Combine(PluginCore.Instance.modsDirectory, "[Custom Textures]");

            if (!Directory.Exists(texturePackDir))
            {
                Directory.CreateDirectory(texturePackDir);
            }
            try
            {
                foreach (string filepath in Directory.EnumerateFiles(texturePackDir, "*.png", SearchOption.AllDirectories))
                {
#if OBFUSCATE
                    if (CheckSumStore.IsModified(filepath))
                    {
                        Log.LogError("File {0} was modified!" , filepath);
                        continue;
                    }
#endif

                    byte[] textureData = File.ReadAllBytes(filepath);
                    string key = Path.GetFileNameWithoutExtension(filepath);

                    try
                    {
                        Texture2D testTexture = Utils.LoadImage(textureData);
                        if (testTexture != null)
                        {
                            TextureStore.textureDict[key] = textureData;
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.LogError($"Invalid texture {key}: {ex.Message}");
                    }
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
#if MULTI_LANGUAGE
            string stringDir = GetAssetDir(AssetType.Strings, Utils.Language);
#else
			string stringDir = GetAssetDir(AssetType.Strings);
#endif
            if (!Directory.Exists(stringDir))
            {
                Directory.CreateDirectory(stringDir);
            }

            string translationStringRegex = System.Text.Json.JsonSerializer.Serialize(StringStore.translationStringRegex, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });

            File.WriteAllText(Path.Combine(stringDir, "translation_regexs.json"), translationStringRegex);

            string translationString = System.Text.Json.JsonSerializer.Serialize(StringStore.translationString, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });

            File.WriteAllText(Path.Combine(stringDir, "translation_strings.json"), translationString);

#if MULTI_LANGUAGE
            if (TravelMgr_Patch.translatedTravelBuffs != null && TravelMgr_Patch.translatedTravelBuffs.Count > 0)
            {
                string travelBuffs = System.Text.Json.JsonSerializer.Serialize(TravelMgr_Patch.translatedTravelBuffs, new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                });
                File.WriteAllText(Path.Combine(stringDir, "travel_buffs.json"), travelBuffs);
            }

            if (NoticePauseMenu_Patch.changelogText != "")
            {
                File.WriteAllText(Path.Combine(stringDir, "changelog.txt"), NoticePauseMenu_Patch.changelogText);
            }

            if (AbyssBuffStore.abyssBuffData != null &&
                AbyssBuffStore.abyssBuffData.Count > 0)
            {
                string abyssBuffData = System.Text.Json.JsonSerializer.Serialize(AbyssBuffStore.abyssBuffData, new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                });
                File.WriteAllText(Path.Combine(stringDir, "abyss_buffs.json"), abyssBuffData);
            }

            SaveAlmanacFiles();
#endif
        }

        internal static void SaveAlmanacFiles()
        {
#if MULTI_LANGUAGE
            string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
            if (!Directory.Exists(almanacDir))
            {
                Directory.CreateDirectory(almanacDir);
            }

            Log.LogInfo($"[SaveAlmanacFiles] Saving to directory: {almanacDir}");

            if (AlmanacPlantMenu_Patch.almanacJson != "")
            {
                string filePath = Path.Combine(almanacDir, "LawnStringsTranslate.json");
                File.WriteAllText(filePath, AlmanacPlantMenu_Patch.almanacJson);
                Log.LogInfo($"[SaveAlmanacFiles] Saved LawnStringsTranslate.json, length: {AlmanacPlantMenu_Patch.almanacJson.Length}");
            }

            if (AlmanacZombieMenu_Patch.almanacJson != "")
            {
                string filePath = Path.Combine(almanacDir, "ZombieStringsTranslate.json");
                File.WriteAllText(filePath, AlmanacZombieMenu_Patch.almanacJson);
                Log.LogInfo($"[SaveAlmanacFiles] Saved ZombieStringsTranslate.json, length: {AlmanacZombieMenu_Patch.almanacJson.Length}");
            }

            // Online sync disabled for modded plants/zombies
#endif
        }

        public static void DumpJson()
        {
            string dumpDir = GetAssetDir(AssetType.Dumps);

            if (!Directory.Exists(dumpDir))
            {
                Directory.CreateDirectory(dumpDir);
            }
            if (TryLoadResourceText("LawnStrings", out string lawnStrings))
            {
                File.WriteAllText(Path.Combine(dumpDir, "LawnStrings.json"), lawnStrings);
            }
            if (TryLoadResourceText("ZombieStrings", out string zombieStrings))
            {
                File.WriteAllText(Path.Combine(dumpDir, "ZombieStrings.json"), zombieStrings);
            }
            if (TryLoadResourceText("AbyssBuffData", out string abyssBuffData))
            {
                File.WriteAllText(Path.Combine(dumpDir, "AbyssBuffData.json"), abyssBuffData);
            }

            DumpDetailStrings();

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            string stringDir = GetAssetDir(AssetType.Strings, Utils.Language);

            var izLevelData = Resources.LoadAll<TextAsset>("izleveldata");
            Dictionary<string, string> izLevelDataDump = new Dictionary<string, string>();

            string izTranslatedPath = Path.Combine(stringDir, "tips_iz.json");
            if (!File.Exists(izTranslatedPath))
            {
                File.WriteAllText(izTranslatedPath, JsonSerializer.Serialize(izLevelDataDump, options));
            }
            var izTranslatedTips = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(izTranslatedPath));

            foreach (var level in izLevelData)
            {
                string data = level.text;
                LevelData levelData = JsonUtility.FromJson<LevelData>(data);
                if (levelData.tips != null)
                {
                    izLevelDataDump.Add(level.name, levelData.tips);
                    if (izTranslatedTips.ContainsKey(level.name) && !StringStore.translationString.ContainsKey(levelData.tips))
                    {
                        StringStore.translationString.Add(levelData.tips, izTranslatedTips[level.name]);
                    }
                }
            }

            File.WriteAllText(Path.Combine(dumpDir, "tips_iz.json"), JsonSerializer.Serialize(izLevelDataDump, options));

            var fusionShowcaseData = Resources.LoadAll<TextAsset>("leveldata/explore");
            Dictionary<string, string> fusionShowcaseDataDump = new Dictionary<string, string>();

            string fsTranslatedPath = Path.Combine(stringDir, "tips_fs.json");
            if (!File.Exists(fsTranslatedPath))
            {
                File.WriteAllText(fsTranslatedPath, JsonSerializer.Serialize(fusionShowcaseDataDump, options));
            }
            var fsTranslatedTips = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(fsTranslatedPath));

            foreach (var level in fusionShowcaseData)
            {
                string data = level.text;
                LevelData levelData = JsonUtility.FromJson<LevelData>(data);
                if (levelData.tips != null)
                {
                    fusionShowcaseDataDump.Add(level.name, levelData.tips);
                    if (fsTranslatedTips.ContainsKey(level.name) && !StringStore.translationString.ContainsKey(levelData.tips))
                    {
                        StringStore.translationString.Add(levelData.tips, fsTranslatedTips[level.name]);
                    }
                }
            }

            File.WriteAllText(Path.Combine(dumpDir, "tips_fs.json"), JsonSerializer.Serialize(fusionShowcaseDataDump, options));
        }

        private static bool TryLoadResourceText(string resourceName, out string text)
        {
            TextAsset asset = Resources.Load<TextAsset>(resourceName);
            if (asset == null)
            {
                Log.LogWarning($"[DumpJson] Resource not found: {resourceName}");
                text = string.Empty;
                return false;
            }

            text = asset.text;
            return true;
        }

#if MULTI_LANGUAGE
        public static void DumpUntranslatedStrings(string key, string originalValue = null)
        {
            string dumpDir = GetAssetDir(AssetType.Dumps);
            string jsonFile = Path.Combine(dumpDir, "UntranslatedStrings.json");

            if (!Directory.Exists(dumpDir))
            {
                Directory.CreateDirectory(dumpDir);
            }

            if (!File.Exists(jsonFile))
            {
                File.WriteAllText(jsonFile, "{}");
            }

            string json = File.ReadAllText(jsonFile);
            var untranslatedStrings = JsonSerializer.Deserialize<Dictionary<string, string>>(json);

            string valueToDump = originalValue ?? key;
            if (!string.IsNullOrEmpty(valueToDump) && !untranslatedStrings.ContainsKey(key))
            {
                untranslatedStrings[key] = valueToDump;
                var options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                    WriteIndented = true
                };
                File.WriteAllText(jsonFile, JsonSerializer.Serialize(untranslatedStrings, options));
            }
        }
#endif

#if MULTI_LANGUAGE
        internal static void LoadLanguage()
        {
            try
            {
                ConfigEntry<string> languageEntry;
                PluginCore.Instance.Config.TryGetEntry<string>(new ConfigDefinition("PvZ_Fusion_Translator", "Language"), out languageEntry);
                string languageName = languageEntry.Value;
                if (Enum.TryParse(languageName, out Utils.LanguageEnum loadedLanguage))
                {
                    Utils.Language = loadedLanguage;
                }
                else
                {
                    Log.LogWarning($"Invalid language '{languageName}' found in preferences. Falling back to English.");
                    Utils.Language = Utils.LanguageEnum.English;
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
            try
            {
                ConfigEntry<string> languageEntry;
                PluginCore.Instance.Config.TryGetEntry<string>(new ConfigDefinition("PvZ_Fusion_Translator", "Language"), out languageEntry);
                languageEntry.Value = Utils.Language.ToString();
                PluginCore.Instance.Config.Save();
            }
            catch (Exception e)
            {
                Log.LogError("Error saving language setting.");
                Log.LogError($"{e.GetType()} {e.Message}");
            }
        }

        internal static void LoadChangelogText()
        {
            string stringDir = GetAssetDir(AssetType.Strings, Utils.Language);
            string changelogDir = Path.Combine(stringDir, "changelog.txt");
            string changelogText = "";
            if (!File.Exists(changelogDir))
            {
                File.WriteAllText(changelogDir, "");
            }

            changelogText = File.ReadAllText(changelogDir);
            NoticePauseMenu_Patch.changelogText = changelogText;
        }

        internal static void LoadIZStrings(string content)
        {
            try
            {
                var izLevelData = Resources.LoadAll<TextAsset>("izleveldata");
                Dictionary<string, string> izLevelDataDump = new Dictionary<string, string>();

                string izTranslatedPath = Path.Combine(GetAssetDir(AssetType.Strings, Utils.Language), "tips_iz.json");
                if (!File.Exists(izTranslatedPath))
                {
                    File.WriteAllText(izTranslatedPath, JsonSerializer.Serialize(izLevelDataDump, new JsonSerializerOptions { WriteIndented = true }));
                }
                var izTranslatedTips = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(izTranslatedPath));

                foreach (var level in izLevelData)
                {
                    string data = level.text;
                    LevelData levelData = JsonUtility.FromJson<LevelData>(data);
                    if(levelData.tips != null)
                    {
                        izLevelDataDump.Add(level.name, levelData.tips);
                        if(izTranslatedTips.ContainsKey(level.name) && !StringStore.izTipCollectionString.ContainsKey(levelData.tips))
                        {
                            StringStore.izLevelTipDictionary.Add(level.name, izTranslatedTips[level.name]);
                            StringStore.izTipCollectionString.Add(levelData.tips, izTranslatedTips[level.name]);
                        }
                    }
                }

                File.WriteAllText(izTranslatedPath, JsonSerializer.Serialize(izLevelDataDump, new JsonSerializerOptions { WriteIndented = true }));
            }
            catch (Exception e)
            {
                Log.LogError("Error loading IZ strings: " + e.Message);
            }
        }

        internal static void LoadFSStrings(string content)
        {
            try
            {
                var fusionShowcaseData = Resources.LoadAll<TextAsset>("leveldata/explore");
                Dictionary<string, string> fusionShowcaseDataDump = new Dictionary<string, string>();

                string fsTranslatedPath = Path.Combine(GetAssetDir(AssetType.Strings, Utils.Language), "tips_fs.json");
                if (!File.Exists(fsTranslatedPath))
                {
                    File.WriteAllText(fsTranslatedPath, JsonSerializer.Serialize(fusionShowcaseDataDump, new JsonSerializerOptions { WriteIndented = true }));
                }
                var fsTranslatedTips = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(fsTranslatedPath));

                foreach (var level in fusionShowcaseData)
                {
                    string data = level.text;
                    LevelData levelData = JsonUtility.FromJson<LevelData>(data);
                    if(levelData.tips != null)
                    {
                        fusionShowcaseDataDump.Add(level.name, levelData.tips);
                        if(fsTranslatedTips.ContainsKey(level.name) && !StringStore.fsTipCollectionString.ContainsKey(levelData.tips))
                        {
                            StringStore.fsLevelTipDictionary.Add(level.name, fsTranslatedTips[level.name]);
                            StringStore.fsTipCollectionString.Add(levelData.tips, fsTranslatedTips[level.name]);
                        }
                    }
                }

                File.WriteAllText(fsTranslatedPath, JsonSerializer.Serialize(fusionShowcaseDataDump, new JsonSerializerOptions { WriteIndented = true }));
            }
            catch (Exception e)
            {
                Log.LogError("Error loading FS strings: " + e.Message);
            }
        }

internal static void LoadDetailStrings(string content)
        {
            try
            {
                string detailStringsPath = Path.Combine(GetAssetDir(AssetType.Dumps), "DetailStrings.json");
                if (!File.Exists(detailStringsPath))
                {
                    DumpDetailStrings();
                }

                if (!File.Exists(detailStringsPath))
                {
                    Log.LogWarning("[LoadDetailStrings] DetailStrings.json not found after dump");
                    return;
                }

                string detailStringsJson = File.ReadAllText(detailStringsPath);
                var detailStringsDump = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(detailStringsJson);
                var translatedDetailStrings = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(content);

                foreach (var detailString in detailStringsDump)
                {
                    if (translatedDetailStrings.ContainsKey(detailString.Key))
                    {
                        AlmanacSelectMenu_Patch.detailTranslateStrings[detailString.Value] = translatedDetailStrings[detailString.Key];
                    }
                }
            }
            catch (Exception ex)
            {
                Log.LogError($"Error loading detail strings: {ex.Message}");
            }
        }

        internal static Dictionary<string, string> DumpDetailStrings()
        {
            Dictionary<string, string> detailStringsDump = new Dictionary<string, string>();
            try
            {
                if (!TryLoadResourceText("detailstrings", out string detailStringsData))
                {
                    return detailStringsDump;
                }
                var parsed = System.Text.Json.JsonSerializer.Deserialize<System.Text.Json.JsonElement>(detailStringsData);
                if (parsed.TryGetProperty("details", out var details) && details.ValueKind == System.Text.Json.JsonValueKind.Array)
                {
                    foreach (var detail in details.EnumerateArray())
                    {
                        string title = detail.TryGetProperty("title", out var titleProp) ? titleProp.GetString() : "";
                        string text = detail.TryGetProperty("text", out var textProp) ? textProp.GetString() : "";
                        if (!string.IsNullOrEmpty(title))
                        {
                            detailStringsDump[title] = text;
                        }
                    }
                }

                string dumpDir = GetAssetDir(AssetType.Dumps);
                if (!Directory.Exists(dumpDir))
                {
                    Directory.CreateDirectory(dumpDir);
                }
                var options = new System.Text.Json.JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
                File.WriteAllText(Path.Combine(dumpDir, "DetailStrings.json"), System.Text.Json.JsonSerializer.Serialize(detailStringsDump, options));
            }
            catch (Exception ex)
            {
                Log.LogError($"Error dumping detail strings: {ex.Message}");
            }
            return detailStringsDump;
        }
#endif
    }
}
