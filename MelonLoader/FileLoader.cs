﻿using Il2Cpp;
using MelonLoader;
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects;
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
						Zombie_Patch.LoadHPStrings();
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
			if (Utils.Language != Utils.LanguageEnum.English)
			{
				LoadLocalizedTextures(Utils.LanguageEnum.English);
			}
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
			File.WriteAllText(Path.Combine(dumpDir, "LawnStrings.json"), LawnStrings);
			File.WriteAllText(Path.Combine(dumpDir, "ZombieStrings.json"), ZombieStrings);

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