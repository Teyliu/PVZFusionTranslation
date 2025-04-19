using PvZ_Fusion_Translator;
using System.Collections.Generic;
using System.IO;
using TMPro;

namespace PvZ_Fusion_Translator__BepInEx_.AssetStore
{
	public static class FontStore
	{
		internal static Dictionary<string, TMP_FontAsset> fontAssetDict = [];
		internal static Dictionary<string, TMP_FontAsset> fontAssetDictSecondary = [];

		internal static void Init()
		{
			string fontsDir = Path.Combine(Core.Instance.modsDirectory, "[Custom Fonts]");
			foreach (string file in Directory.GetFiles(fontsDir))
			{
				string fileName = Path.GetFileNameWithoutExtension(file);
				string fileExtension = Path.GetExtension(file);

				if (fileExtension == ".ttf" || fileExtension == ".otf")
				{
					if (!fileName.EndsWith("_Almanac") && !fileName.EndsWith("_Fallback"))
					{
						string fontPath = Path.Combine("PvZ_Fusion_Translator", "[Custom Fonts]", fileName + fileExtension);

						TMP_FontAsset fontAsset = FontHandler.LoadTMPFont(fontPath, true);
						fontAsset.name = fileName;
						fontAssetDict.Add(fileName, fontAsset);

						Log.LogInfo($"Font for language '{fileName}' loaded");
					}
				}
			}
			InitFallback();
		}

		internal static void InitFallback()
		{
			string fontsDir = Path.Combine(Core.Instance.modsDirectory, "[Custom Fonts]");
			foreach (string file in Directory.GetFiles(fontsDir))
			{
				string fileName = Path.GetFileNameWithoutExtension(file);
				string fileExtension = Path.GetExtension(file);

				if (fileExtension == ".ttf" || fileExtension == ".otf")
				{
					if (fileName.EndsWith("_Almanac") || fileName.EndsWith("_Fallback"))
					{
						string fallbackPath = Path.Combine("PvZ_Fusion_Translator", "[Custom Fonts]", fileName + fileExtension);
						TMP_FontAsset fallbackFont = FontHandler.LoadTMPFont(fallbackPath, true);
						fallbackFont.name = fileName;

						string fileNameLanguage = fileName.Replace("_Fallback", "").Replace("_Almanac", "");

						if (fontAssetDictSecondary.ContainsKey(fileNameLanguage))
						{
							if (fileName.EndsWith("_Fallback"))
							{
								fontAssetDictSecondary.Add(fileNameLanguage + "_Almanac", fontAssetDictSecondary[fileNameLanguage]);
								fontAssetDictSecondary.Remove(fileNameLanguage);
							}
							else
							{
								fontAssetDictSecondary.Add(fileNameLanguage + "_Fallback", fontAssetDictSecondary[fileNameLanguage]);
								fontAssetDictSecondary.Remove(fileNameLanguage);
							}
							fontAssetDictSecondary.Add(fileName, fallbackFont);
						}
						else
							fontAssetDictSecondary.Add(fileNameLanguage, fallbackFont);
					}
				}
			}
			AddFallback();
		}

		public static void AddFallback()
		{
			foreach (var lang in fontAssetDict.Keys)
			{
				if (fontAssetDict[lang].fallbackFontAssetTable == null)
				{
					fontAssetDict[lang].fallbackFontAssetTable = new Il2CppSystem.Collections.Generic.List<TMP_FontAsset>();
				}

				if (fontAssetDictSecondary.ContainsKey(lang))
				{
					fontAssetDict[lang].fallbackFontAssetTable.Add(fontAssetDictSecondary[lang]);
					Log.LogInfo("Fallback font for language '" + lang + "' added");
					continue;
				}
				if (fontAssetDictSecondary.ContainsKey(lang + "_Almanac"))
				{
					fontAssetDict[lang].fallbackFontAssetTable.Add(fontAssetDictSecondary[lang + "_Almanac"]);
					Log.LogInfo("Fallback font for language '" + lang + "' added");
					continue;
				}
				if (fontAssetDictSecondary.ContainsKey(lang + "_Fallback"))
				{
					fontAssetDict[lang].fallbackFontAssetTable.Add(fontAssetDictSecondary[lang + "_Fallback"]);
					Log.LogInfo("Fallback font for language '" + lang + "' added");
					continue;
				}
			}
		}
		public static TMP_FontAsset LoadTMPFont(string language)
		{
			if (fontAssetDict.TryGetValue(language, out TMP_FontAsset font))
			{
				return font;
			}
			return fontAssetDict.GetValueOrDefault("English");
		}
		public static TMP_FontAsset LoadTMPFontAlmanac(string language)
		{
			if (fontAssetDictSecondary.ContainsKey(language))
			{
				if (fontAssetDictSecondary.TryGetValue(language, out TMP_FontAsset almanacAsset))
				{
					return almanacAsset;
				}
			}
			if (fontAssetDictSecondary.ContainsKey(language + "_Almanac"))
			{
				if (fontAssetDictSecondary.TryGetValue(language + "_Almanac", out TMP_FontAsset almanacAsset))
				{
					return almanacAsset;
				}
			}
			return fontAssetDict.GetValueOrDefault("English");
		}

		public static void Reload()
		{
			// Get the current language
			string currentLanguage = Utils.Language.ToString();

			// Load the font for the current language
			_ = LoadTMPFont(currentLanguage);
		}
	}
}
