using Il2Cpp;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using JetBrains.Annotations;
using MelonLoader;
using MelonLoader.TinyJSON;
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.GameObjects;
using PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects;
using PvZ_Fusion_Translator.Patches.Modes.Odyssey;
using PvZ_Fusion_Translator.Patches.OtherManagers;
using System.Text.Encodings.Web;
using System.Text.Json;
using UnityEngine;

namespace PvZ_Fusion_Translator
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

		internal static void LoadStrings() => LoadStrings(Utils.Language);

		internal static void LoadStrings(Utils.LanguageEnum language)
		{
			string stringDir = GetAssetDir(AssetType.Strings, Utils.Language);

			if(!Utils.useLocal)
			{
				// load translationStrings
				string translationStringsContent = Utils.GetDataFromWeb($"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language.ToString()}/Strings/translation_strings.json").Result;
			
				if(translationStringsContent != null)
				{
					LoadTranslationStrings(translationStringsContent);
				}
				else
				{
					string translationStringsPath = Path.Combine(GetAssetDir(AssetType.Strings, Utils.Language), "translation_strings.json");
					if(File.Exists(translationStringsPath))
					{
						LoadTranslationStrings(File.ReadAllText(translationStringsPath));
					}
				}

				// load translationRegexs
				string translationRegexsContent = Utils.GetDataFromWeb($"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language.ToString()}/Strings/translation_regexs.json").Result;
			
				if(translationRegexsContent != null)
				{
					LoadTranslationRegexs(translationRegexsContent);
				}
				else
				{
					string translationRegexsPath = Path.Combine(GetAssetDir(AssetType.Strings, Utils.Language), "translation_regexs.json");
					if(File.Exists(translationRegexsPath))
					{
						LoadTranslationRegexs(File.ReadAllText(translationRegexsPath));
					}
				}

				// load travel_buffs
				string travelBuffsContent = Utils.GetDataFromWeb($"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language.ToString()}/Strings/travel_buffs.json").Result;
			
				if(travelBuffsContent != null)
				{
					TravelMgr_Patch.translatedTravelBuffs = JsonSerializer.Deserialize<Dictionary<string, SortedDictionary<int, string>>>(travelBuffsContent);
				}
				else
				{
					string travelBuffsPath = Path.Combine(GetAssetDir(AssetType.Strings, Utils.Language), "travel_buffs.json");
					if(File.Exists(travelBuffsPath))
					{
						TravelMgr_Patch.translatedTravelBuffs = JsonSerializer.Deserialize<Dictionary<string, SortedDictionary<int, string>>>(File.ReadAllText(travelBuffsPath));
					}
				}

				// load tips
				string izTipsContent = Utils.GetDataFromWeb($"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language.ToString()}/Strings/tips_iz.json").Result;
			
				if(izTipsContent != null)
				{
					LoadIZStrings(izTipsContent);
				}
				else
				{
					string izTipsPath = Path.Combine(GetAssetDir(AssetType.Strings, Utils.Language), "tips_iz.json");
					if(File.Exists(izTipsPath))
					{
						LoadIZStrings(File.ReadAllText(izTipsPath));
					}
				}

				string fsTipsContent = Utils.GetDataFromWeb($"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language.ToString()}/Strings/tips_fs.json").Result;
			
				if(fsTipsContent != null)
				{
					LoadFSStrings(fsTipsContent);
				}
				else
				{
					string fsTipsPath = Path.Combine(GetAssetDir(AssetType.Strings, Utils.Language), "tips_fs.json");
					if(File.Exists(fsTipsPath))
					{
						LoadFSStrings(File.ReadAllText(fsTipsPath));
					}
				}

				// load almanacs
				string plantAlmanacContent = Utils.GetDataFromWeb($"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language.ToString()}/Almanac/LawnStringsTranslate.json").Result;
			
				if(plantAlmanacContent != null)
				{
					AlmanacPlantMenu_Patch.almanacJson = plantAlmanacContent;
				}
				else
				{
					string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
					string path = Path.Combine(almanacDir, "LawnStringsTranslate.json");
					if(File.Exists(path))
					{
						AlmanacPlantMenu_Patch.almanacJson = File.ReadAllText(path);
					}
				}

				string zombieAlmanacContent = Utils.GetDataFromWeb($"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language.ToString()}/Almanac/ZombieStringsTranslate.json").Result;
			
				if(zombieAlmanacContent != null)
				{
					AlmanacZombieMenu_Patch.almanacJson = zombieAlmanacContent;
				}
				else
				{
					string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
					string path = Path.Combine(almanacDir, "ZombieStringsTranslate.json");
					if(File.Exists(path))
					{
						AlmanacZombieMenu_Patch.almanacJson = File.ReadAllText(path);
					}
				}

				Patches.Modes.Abyss.AbyssBuffMenu_Patch.LoadAbyssBuffData();

				SaveStrings();
				DumpJson();
			}
			else
			{
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
							LoadTranslationStrings(jsonString);
						}
						else if (fileName.EndsWith("_regexs"))
						{
							LoadTranslationRegexs(jsonString);
						}
						else if(fileName.EndsWith("travel_buffs"))
						{
							TravelMgr_Patch.translatedTravelBuffs = JsonSerializer.Deserialize<Dictionary<string, SortedDictionary<int, string>>>(jsonString);
						}
						else if(fileName.EndsWith("tips_iz"))
						{
							LoadIZStrings(jsonString);
						}
						else if(fileName.EndsWith("tips_fs"))
						{
							LoadFSStrings(jsonString);
						}
					}

					string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
					string plantAlmanacPath = Path.Combine(almanacDir, "LawnStringsTranslate.json");
					if(File.Exists(plantAlmanacPath))
					{
						AlmanacPlantMenu_Patch.almanacJson = File.ReadAllText(plantAlmanacPath);
					}

					string zombieAlmanacPlant = Path.Combine(almanacDir, "ZombieStringsTranslate.json");
					if(File.Exists(zombieAlmanacPlant))
					{
						AlmanacZombieMenu_Patch.almanacJson = File.ReadAllText(zombieAlmanacPlant);
					}

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
			Dictionary<string, string> dictionary = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(content);
			foreach (var (key, value) in dictionary)
			{
				StringStore.translationString[key] = value;
			}
		}

		internal static void LoadTranslationRegexs(string content)
		{
			Dictionary<string, string> dictionary = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(content);
			foreach (var (key, value) in dictionary)
			{
				StringStore.translationStringRegex[key] = value;
			}
			Zombie_Patch.LoadHPStrings();
		}

		internal static void LoadIZStrings(string content)
		{
			var izDump = DumpIZStrings();
			var izLevelData = izDump.Item1;
			var izLevelDataDump = izDump.Item2;

			var izTranslatedTips = JsonSerializer.Deserialize<Dictionary<string, string>>(content);

            foreach (var level in izLevelData) 
			{
				string data = level.text;
				LevelData levelData = JsonUtility.FromJson<LevelData>(data);
				if(levelData.tips != null)
				{
					if(izTranslatedTips.ContainsKey(level.name) && !StringStore.izTipCollectionString.ContainsKey(levelData.tips))
					{
                        StringStore.izTipCollectionString.Add(levelData.tips, izTranslatedTips[level.name]);
                    }
                }
            }
		}

		internal static void LoadFSStrings(string content)
		{
			var fusionShowcaseDump = DumpFSStrings();
			var fusionShowcaseData = fusionShowcaseDump.Item1;
			var fusionShowcaseDataDump = fusionShowcaseDump.Item2;

            var fsTranslatedTips = JsonSerializer.Deserialize<Dictionary<string, string>>(content);

            foreach (var level in fusionShowcaseData)
            {
                string data = level.text;
                LevelData levelData = JsonUtility.FromJson<LevelData>(data);
                if (levelData.tips != null)
                {
                    if (fsTranslatedTips.ContainsKey(level.name) && !StringStore.fsTipCollectionString.ContainsKey(levelData.tips))
                    {
                        StringStore.fsTipCollectionString.Add(levelData.tips, fsTranslatedTips[level.name]);
                    }
                }
            }
		}

		internal static void LoadChangelogText()
		{
			string stringDir = FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language);
            string changelogDir = Path.Combine(stringDir, "changelog.txt");
            string changelogText = File.ReadAllText(changelogDir);

            if(!Utils.useLocal)
            {
                string changelogContent = Utils.GetDataFromWeb($"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language.ToString()}/Strings/changelog.txt").Result;
			
				if(changelogContent != null)
				{
					changelogText = changelogContent;
				}
            }

			NoticePauseMenu_Patch.changelogText = changelogText;
		}

		public static bool loadDefaultTextures = MelonPreferences.GetEntryValue<bool>("PvZ_Fusion_Translator", "DefaultTextures");
		internal static void LoadTextures()
		{
			// Default or Custom Texturse -> English Textures -> Localized Textures
			try
			{
				
				if (Utils.customTextures)
				{
                    LoadCustomTextures();
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
			string textureDir = GetAssetDir(AssetType.Textures, language);

			if (!Directory.Exists(textureDir))
			{
				Directory.CreateDirectory(textureDir);
			}
			try
			{
				foreach (string filepath in Directory.EnumerateFiles(textureDir, "*.png", SearchOption.AllDirectories))
				{
					if (filepath.Contains("[Custom Textures]", StringComparison.OrdinalIgnoreCase) && loadDefaultTextures)
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

					Texture2D texture2D = Utils.LoadImage(filepath);
					TextureStore.textureDict[Path.GetFileNameWithoutExtension(filepath)] = filepath;
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
            string textureDir = GetAssetDir(AssetType.Sprites, language);

            if (!Directory.Exists(textureDir))
            {
                Directory.CreateDirectory(textureDir);
            }
            try
            {
                foreach (string filepath in Directory.EnumerateFiles(textureDir, "*.png", SearchOption.AllDirectories))
                {
                    if (filepath.Contains("[Custom Textures]", StringComparison.OrdinalIgnoreCase) && loadDefaultTextures)
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
                    Log.LogDebug("Loading File (Sprite): " + filepath);
					#endif

                    Texture2D texture2D = Utils.LoadImage(filepath);
                    TextureStore.spriteDict[Path.GetFileNameWithoutExtension(filepath)] = filepath;
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
			if(Utils.customTextures == false)
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

                        Texture2D texture2D = Utils.LoadImage(filepath);
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

					Texture2D texture2D = Utils.LoadImage(filepath);
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

			// save regexs

			string translationStringRegex = System.Text.Json.JsonSerializer.Serialize(StringStore.translationStringRegex, new JsonSerializerOptions
			{
				WriteIndented = true,
				Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
			});

			File.WriteAllText(Path.Combine(stringDir, "translation_regexs.json"), translationStringRegex);

			// save strings

			string translationString = System.Text.Json.JsonSerializer.Serialize(StringStore.translationString, new JsonSerializerOptions
			{
				WriteIndented = true,
				Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
			});

			File.WriteAllText(Path.Combine(stringDir, "translation_strings.json"), translationString);

			// save iz tips

			string izTipCollectionString = System.Text.Json.JsonSerializer.Serialize(StringStore.izTipCollectionString, new JsonSerializerOptions
			{
				WriteIndented = true,
				Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
			});

			File.WriteAllText(Path.Combine(stringDir, "tips_iz.json"), izTipCollectionString);

			// save fs tips

			string fsTipCollectionString = System.Text.Json.JsonSerializer.Serialize(StringStore.fsTipCollectionString, new JsonSerializerOptions
			{
				WriteIndented = true,
				Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
			});

			File.WriteAllText(Path.Combine(stringDir, "tips_fs.json"), fsTipCollectionString);

			// save travel buffs

			string travelBuffs = System.Text.Json.JsonSerializer.Serialize(TravelMgr_Patch.translatedTravelBuffs, new JsonSerializerOptions
			{
				WriteIndented = true,
				Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
			});

			File.WriteAllText(Path.Combine(stringDir, "travel_buffs.json"), travelBuffs);

			// save changelog

			if(NoticePauseMenu_Patch.changelogText != "")
			{
				File.WriteAllText(Path.Combine(stringDir, "changelog.txt"), NoticePauseMenu_Patch.changelogText);
			}

			// save abyss buffs

			if(Patches.Modes.Abyss.AbyssBuffMenu_Patch.abyssBuffData != new Dictionary<string, string>())
			{
				string abyssBuffData = System.Text.Json.JsonSerializer.Serialize(Patches.Modes.Abyss.AbyssBuffMenu_Patch.abyssBuffData, new JsonSerializerOptions
				{
					WriteIndented = true,
					Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
				});
				File.WriteAllText(Path.Combine(stringDir, "abyss_buffs.json"), abyssBuffData);
			}

			// save almanacs

			string almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);

			if(AlmanacPlantMenu_Patch.almanacJson != "")
			{
				string plantAlmanac = System.Text.Json.JsonSerializer.Serialize(AlmanacPlantMenu_Patch.almanacJson, new JsonSerializerOptions
				{
					WriteIndented = true,
					Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
				});

				File.WriteAllText(Path.Combine(almanacDir, "LawnStringsTranslate.json"), AlmanacPlantMenu_Patch.almanacJson);
			}

			if(AlmanacZombieMenu_Patch.almanacJson != "")
			{
				string zombieAlmanac = System.Text.Json.JsonSerializer.Serialize(AlmanacZombieMenu_Patch.almanacJson, new JsonSerializerOptions
				{
					WriteIndented = true,
					Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
				});

				File.WriteAllText(Path.Combine(almanacDir, "ZombieStringsTranslate.json"), AlmanacZombieMenu_Patch.almanacJson);
			}
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

			// dump iz tips
			var izDump = DumpIZStrings();
			var izLevelData = izDump.Item1;
			var izLevelDataDump = izDump.Item2;

            File.WriteAllText(Path.Combine(dumpDir, "tips_iz.json"), JsonSerializer.Serialize(izLevelDataDump, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            }));

            // dump fusion showcase tips
            var fusionShowcaseDump = DumpIZStrings();
			var fusionShowcaseData = izDump.Item1;
			var fusionShowcaseDataDump = izDump.Item2;

            File.WriteAllText(Path.Combine(dumpDir, "tips_fs.json"), JsonSerializer.Serialize(fusionShowcaseDataDump, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            }));

            Dictionary<Achievement, AchievementObject> achievementsList = new Dictionary<Achievement, AchievementObject>();
			foreach (Il2CppSystem.Collections.Generic.KeyValuePair<Achievement, Il2CppSystem.Tuple<string, string>> entry in AchievementClip.achievementsText)
			{
				achievementsList.Add(entry.Key, new AchievementObject(entry.Key, entry.Value.Item1, entry.Value.Item2));
			}
			File.WriteAllText(Path.Combine(dumpDir, "AchievementsText.json"), JsonSerializer.Serialize(achievementsList, new JsonSerializerOptions
			{
				WriteIndented = true,
				Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
			}));
        }

		public static ValueTuple<Il2CppArrayBase<TextAsset>, Dictionary<string, string>> DumpIZStrings()
		{
			var izLevelData = Resources.LoadAll<TextAsset>("izleveldata");
			Dictionary<string, string> izLevelDataDump = new Dictionary<string, string>();
			foreach (var level in izLevelData) 
			{
				string data = level.text;
				LevelData levelData = JsonUtility.FromJson<LevelData>(data);
				if(levelData.tips != null)
				{
					izLevelDataDump.Add(level.name, levelData.tips);
                }
            }
			return new ValueTuple<Il2CppArrayBase<TextAsset>, Dictionary<string, string>>(izLevelData, izLevelDataDump);
		}

		public static ValueTuple<Il2CppArrayBase<TextAsset>, Dictionary<string, string>> DumpFSStrings()
		{
			var fusionShowcaseData = Resources.LoadAll<TextAsset>("leveldata/explore");
            Dictionary<string, string> fusionShowcaseDataDump = new Dictionary<string, string>();
			foreach (var level in fusionShowcaseData)
            {
                string data = level.text;
                LevelData levelData = JsonUtility.FromJson<LevelData>(data);
                if (levelData.tips != null)
                {
                    fusionShowcaseDataDump.Add(level.name, levelData.tips);
                }
            }
			return new ValueTuple<Il2CppArrayBase<TextAsset>, Dictionary<string, string>>(fusionShowcaseData, fusionShowcaseDataDump);
		}

		#if DEBUG
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
		#endif
		

		#if MULTI_LANGUAGE
		internal static void LoadLanguage()
		{
			try
			{
				// Load the language preference as a string and parse it into the enum
				string languageName = MelonPreferences.GetEntryValue<string>("PvZ_Fusion_Translator", "Language");
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
				MelonPreferences.SetEntryValue("PvZ_Fusion_Translator", "Language", Utils.Language.ToString());

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
		#endif
	}
}