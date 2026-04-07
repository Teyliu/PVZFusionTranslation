using BepInEx.Configuration;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.OtherManagers;
using PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using UnityEngine;
using UnityEngine.Rendering;
using PvZ_Fusion_Translator.Patches.GameObjects;

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
            return Path.Combine(Core.Instance.modsDirectory, languagePath, assetType.ToString());
        }
        // private static string GetAssetDir(AssetType assetType) => Path.Combine(Core.Instance.modsDirectory, assetType.ToString());

#if MULTI_LANGUAGE
        internal static void LoadStrings() => LoadStrings(Utils.Language);

        internal static void LoadStrings(Utils.LanguageEnum language)
#else
		internal static void LoadStrings(bool isLog = false)
#endif
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
                            var loaded = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, SortedDictionary<int, string>>>(jsonString);
                            TravelMgr_Patch.translatedTravelBuffs = loaded;
                        }
                        catch
                        {
                            var flexibleLoaded = TravelMgr_Patch.LoadTravelBuffsFlexible(jsonString);
                            if (flexibleLoaded != null)
                            {
                                TravelMgr_Patch.translatedTravelBuffs = flexibleLoaded;
                            }
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
                        AbyssBuffMenu_Patch.LoadAbyssBuffData();
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
        }

        internal static void LoadAlmanac()
        {
            try
            {
#if MULTI_LANGUAGE
                string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
                if (!Directory.Exists(almanacDir))
                {
                    Directory.CreateDirectory(almanacDir);
                }

                if (!Utils.useLocal)
                {
                    string plantAlmanacContent = Utils.GetDataFromWeb($"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language.ToString()}/Almanac/LawnStringsTranslate.json").Result;
                    if (plantAlmanacContent != null)
                    {
                        AlmanacPlantMenu_Patch.almanacJson = plantAlmanacContent;
                    }
                    else
                    {
                        string path = Path.Combine(almanacDir, "LawnStringsTranslate.json");
                        if (File.Exists(path))
                        {
                            AlmanacPlantMenu_Patch.almanacJson = File.ReadAllText(path);
                        }
                    }

                    string zombieAlmanacContent = Utils.GetDataFromWeb($"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language.ToString()}/Almanac/ZombieStringsTranslate.json").Result;
                    if (zombieAlmanacContent != null)
                    {
                        AlmanacZombieMenu_Patch.almanacJson = zombieAlmanacContent;
                    }
                    else
                    {
                        string path = Path.Combine(almanacDir, "ZombieStringsTranslate.json");
                        if (File.Exists(path))
                        {
                            AlmanacZombieMenu_Patch.almanacJson = File.ReadAllText(path);
                        }
                    }

                    string moddedPlantContent = Utils.GetDataFromWeb($"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language.ToString()}/Almanac/ModdedPlantsTranslate.json").Result;
                    if (!string.IsNullOrEmpty(moddedPlantContent) && !string.IsNullOrEmpty(AlmanacPlantMenu_Patch.almanacJson))
                    {
                        try
                        {
                            var plantData = System.Text.Json.JsonSerializer.Deserialize<System.Text.Json.JsonElement>(moddedPlantContent);
                            if (plantData.TryGetProperty("plants", out var plants) && plants.ValueKind == System.Text.Json.JsonValueKind.Array)
                            {
                                AlmanacPlantMenu_Patch.almanacJson = AlmanacPlantMenu_Patch.almanacJson + "\n" + moddedPlantContent;
                            }
                        }
                        catch
                        {
                            string moddedPath = Path.Combine(almanacDir, "ModdedPlantsTranslate.json");
                            if (File.Exists(moddedPath))
                            {
                                string localModded = File.ReadAllText(moddedPath);
                                AlmanacPlantMenu_Patch.almanacJson = AlmanacPlantMenu_Patch.almanacJson + "\n" + localModded;
                            }
                        }
                    }
                    else
                    {
                        string moddedPath = Path.Combine(almanacDir, "ModdedPlantsTranslate.json");
                        if (File.Exists(moddedPath))
                        {
                            AlmanacPlantMenu_Patch.almanacJson = AlmanacPlantMenu_Patch.almanacJson + "\n" + File.ReadAllText(moddedPath);
                        }
                    }

                    string moddedZombieContent = Utils.GetDataFromWeb($"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language.ToString()}/Almanac/ModdedZombiesTranslate.json").Result;
                    if (!string.IsNullOrEmpty(moddedZombieContent) && !string.IsNullOrEmpty(AlmanacZombieMenu_Patch.almanacJson))
                    {
                        try
                        {
                            var zombieData = System.Text.Json.JsonSerializer.Deserialize<System.Text.Json.JsonElement>(moddedZombieContent);
                            if (zombieData.TryGetProperty("zombies", out var zombies) && zombies.ValueKind == System.Text.Json.JsonValueKind.Array)
                            {
                                AlmanacZombieMenu_Patch.almanacJson = AlmanacZombieMenu_Patch.almanacJson + "\n" + moddedZombieContent;
                            }
                        }
                        catch
                        {
                            string moddedPath = Path.Combine(almanacDir, "ModdedZombiesTranslate.json");
                            if (File.Exists(moddedPath))
                            {
                                string localModded = File.ReadAllText(moddedPath);
                                AlmanacZombieMenu_Patch.almanacJson = AlmanacZombieMenu_Patch.almanacJson + "\n" + localModded;
                            }
                        }
                    }
                    else
                    {
                        string moddedPath = Path.Combine(almanacDir, "ModdedZombiesTranslate.json");
                        if (File.Exists(moddedPath))
                        {
                            AlmanacZombieMenu_Patch.almanacJson = AlmanacZombieMenu_Patch.almanacJson + "\n" + File.ReadAllText(moddedPath);
                        }
                    }
                }
                else
                {
                    string plantPath = Path.Combine(almanacDir, "LawnStringsTranslate.json");
                    if (File.Exists(plantPath))
                    {
                        AlmanacPlantMenu_Patch.almanacJson = File.ReadAllText(plantPath);
                    }

                    string zombiePath = Path.Combine(almanacDir, "ZombieStringsTranslate.json");
                    if (File.Exists(zombiePath))
                    {
                        AlmanacZombieMenu_Patch.almanacJson = File.ReadAllText(zombiePath);
                    }

                    string moddedPlantPath = Path.Combine(almanacDir, "ModdedPlantsTranslate.json");
                    if (File.Exists(moddedPlantPath))
                    {
                        string moddedContent = File.ReadAllText(moddedPlantPath);
                        if (!string.IsNullOrEmpty(moddedContent) && AlmanacPlantMenu_Patch.almanacJson != "")
                        {
                            AlmanacPlantMenu_Patch.almanacJson = AlmanacPlantMenu_Patch.almanacJson + "\n" + moddedContent;
                        }
                    }

                    string moddedZombiePath = Path.Combine(almanacDir, "ModdedZombiesTranslate.json");
                    if (File.Exists(moddedZombiePath))
                    {
                        string moddedContent = File.ReadAllText(moddedZombiePath);
                        if (!string.IsNullOrEmpty(moddedContent) && AlmanacZombieMenu_Patch.almanacJson != "")
                        {
                            AlmanacZombieMenu_Patch.almanacJson = AlmanacZombieMenu_Patch.almanacJson + "\n" + moddedContent;
                        }
                    }
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
                if (!Utils.useLocal)
                {
                    string travelBuffsContent = Utils.GetDataFromWeb($"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language.ToString()}/Strings/travel_buffs.json").Result;
                    if (travelBuffsContent != null)
                    {
                        try
                        {
                            TravelMgr_Patch.translatedTravelBuffs = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, SortedDictionary<int, string>>>(travelBuffsContent);
                        }
                        catch
                        {
                            TravelMgr_Patch.translatedTravelBuffs = TravelMgr_Patch.LoadTravelBuffsFlexible(travelBuffsContent);
                        }
                    }
                    else
                    {
                        string travelBuffsPath = Path.Combine(GetAssetDir(AssetType.Strings, Utils.Language), "travel_buffs.json");
                        if (File.Exists(travelBuffsPath))
                        {
                            try
                            {
                                TravelMgr_Patch.translatedTravelBuffs = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, SortedDictionary<int, string>>>(File.ReadAllText(travelBuffsPath));
                            }
                            catch
                            {
                                TravelMgr_Patch.translatedTravelBuffs = TravelMgr_Patch.LoadTravelBuffsFlexible(File.ReadAllText(travelBuffsPath));
                            }
                        }
                    }
                }
                else
                {
                    string travelBuffsPath = Path.Combine(GetAssetDir(AssetType.Strings, Utils.Language), "travel_buffs.json");
                    if (File.Exists(travelBuffsPath))
                    {
                        try
                        {
                            TravelMgr_Patch.translatedTravelBuffs = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, SortedDictionary<int, string>>>(File.ReadAllText(travelBuffsPath));
                        }
                        catch
                        {
                            TravelMgr_Patch.translatedTravelBuffs = TravelMgr_Patch.LoadTravelBuffsFlexible(File.ReadAllText(travelBuffsPath));
                        }
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

            // Default or Custom Texturse -> English Textures -> Localized Textures
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
            if (Utils.Language != Utils.LanguageEnum.English)
            {
                LoadLocalizedTextures(Utils.LanguageEnum.English);
            }
            LoadLocalizedTextures(Utils.Language);
#else
			LoadLocalizedTextures();
#endif

            Log.LogInfo("Textures loaded successfully.");
        }

		internal static void LoadLocalizedTextures(Utils.LanguageEnum? language = null)
		{
			ConfigEntry<bool> defaultTextureEntry;
			Core.Instance.Config.TryGetEntry<bool>(new ConfigDefinition("PvZ_Fusion_Translator", "DefaultTextures"), out defaultTextureEntry);

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

#if DEBUG
                    Log.LogDebug("Loading File : " + filepath);
#endif

                    // Only store filepath, load texture on-demand to save memory
                    TextureStore.textureDict[Path.GetFileNameWithoutExtension(filepath)] = filepath;
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
			if (Core.Instance.configDefaultTextures.Value)
			{
				string textureDefaultDir = Path.Combine(Core.Instance.modsDirectory, AssetType.Dumps.ToString(), "Default Textures [Do Not Remove]");
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

                        // Only store filepath, load texture on-demand to save memory
                        TextureStore.textureDict[Path.GetFileNameWithoutExtension(filepath)] = filepath;
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
			string texturePackDir = Path.Combine(Core.Instance.modsDirectory, "[Custom Textures]");

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

                    // Only store filepath, load texture on-demand to save memory
                    TextureStore.textureDict[Path.GetFileNameWithoutExtension(filepath)] = filepath;
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

            if (AbyssBuffMenu_Patch.abyssBuffData != null && 
                AbyssBuffMenu_Patch.abyssBuffData.Count > 0)
            {
                string abyssBuffData = System.Text.Json.JsonSerializer.Serialize(AbyssBuffMenu_Patch.abyssBuffData, new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                });
                File.WriteAllText(Path.Combine(stringDir, "abyss_buffs.json"), abyssBuffData);
            }

            string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
            if (!Directory.Exists(almanacDir))
            {
                Directory.CreateDirectory(almanacDir);
            }

            if (AlmanacPlantMenu_Patch.almanacJson != "")
            {
                File.WriteAllText(Path.Combine(almanacDir, "LawnStringsTranslate.json"), AlmanacPlantMenu_Patch.almanacJson);
            }

            if (AlmanacZombieMenu_Patch.almanacJson != "")
            {
                File.WriteAllText(Path.Combine(almanacDir, "ZombieStringsTranslate.json"), AlmanacZombieMenu_Patch.almanacJson);
            }
#endif
        }

        public static void DumpJson()
        {
            string dumpDir = GetAssetDir(AssetType.Dumps);

            if (!Directory.Exists(dumpDir))
            {
                Directory.CreateDirectory(dumpDir);
            }
            string LawnStrings = Resources.Load<TextAsset>("LawnStrings").text;
            string ZombieStrings = Resources.Load<TextAsset>("ZombieStrings").text;
            string AbyssBuffData = Resources.Load<TextAsset>("AbyssBuffData").text;
            File.WriteAllText(Path.Combine(dumpDir, "LawnStrings.json"), LawnStrings);
            File.WriteAllText(Path.Combine(dumpDir, "ZombieStrings.json"), ZombieStrings);
            File.WriteAllText(Path.Combine(dumpDir, "AbyssBuffData.json"), AbyssBuffData);

            Dictionary<Achievement, AchievementObject> achievementsList = new Dictionary<Achievement, AchievementObject>();
            foreach (var entry in AchievementClip.achievementsText)
            {
                var key = entry.Key;
                var value = entry.Value;
                achievementsList.Add(key, new AchievementObject(key, value.Item1, value.Item2));
            }
            File.WriteAllText(Path.Combine(dumpDir, "AchievementsText.json"), JsonSerializer.Serialize(achievementsList, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            }));

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

//#if DEBUG
        public static void DumpUntranslatedStrings(string text)
        {
            string dumpDir = GetAssetDir(AssetType.Dumps);
            string jsonFile = Path.Combine(dumpDir, "UntranslatedStrings.json");

            if (!Directory.Exists(dumpDir))
            {
                Directory.CreateDirectory(dumpDir);
            }

            if (!File.Exists(jsonFile))
            {
                File.WriteAllText(jsonFile, "{}"); // Initialize empty JSON object
            }

            string json = File.ReadAllText(jsonFile);
            var untranslatedStrings = JsonSerializer.Deserialize<Dictionary<string, string>>(json);

            if (!untranslatedStrings.ContainsKey(text))
            {
                untranslatedStrings[text] = text;
                var options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                    WriteIndented = true
                };
                File.WriteAllText(jsonFile, JsonSerializer.Serialize(untranslatedStrings, options));
            }
        }
//#endif

#if MULTI_LANGUAGE
        internal static void LoadLanguage()
        {
            try
            {
                // Load the language preference as a string and parse it into the enum
                ConfigEntry<string> languageEntry;
                Core.Instance.Config.TryGetEntry<string>(new ConfigDefinition("PvZ_Fusion_Translator", "Language"), out languageEntry);
                string languageName = languageEntry.Value;
                if (Enum.TryParse(languageName, out Utils.LanguageEnum loadedLanguage))
                {
                    Utils.Language = loadedLanguage;
                }
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
            try
            {
                // Save the current language as a string
                ConfigEntry<string> languageEntry;
                Core.Instance.Config.TryGetEntry<string>(new ConfigDefinition("PvZ_Fusion_Translator", "Language"), out languageEntry);
                languageEntry.Value = Utils.Language.ToString();
                Core.Instance.Config.Save();
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

            if(!Utils.useLocal)
            {
                try
                {
                    string changelogContent = Utils.GetDataFromWeb($"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language.ToString()}/Strings/changelog.txt").Result;
                    if(changelogContent != null)
                    {
                        changelogText = changelogContent;
                    }
                }
                catch
                {
                    Log.LogWarning("Could not fetch online changelog, using local version.");
                }
            }

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
#endif
    }
}
