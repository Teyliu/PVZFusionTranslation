using Il2CppTMPro;
using MelonLoader;
using System.Reflection;
using UnityEngine;
using UnityEngine.TextCore.Text;

namespace PvZ_Fusion_Translator.AssetStore
{
	public static class FontStore
	{
		internal static Dictionary<string, TMP_FontAsset> fontAssetDict = [];
		internal static Dictionary<string, TMP_FontAsset> fontAssetDictSecondary = [];

		internal static void Init()
		{
			string fontsDir = Path.Combine(Core.Instance.modsDirectory, "[Custom Fonts]");

			AssetBundle assetBundle = Utils.GetAssetBundle(Path.Combine(fontsDir, "translation"));

			#if MULTI_LANGUAGE
			foreach (string file in assetBundle.GetAllAssetNames())
			{
				string fileName = Path.GetFileNameWithoutExtension(file);

				if (!fileName.EndsWith("_almanac") && !fileName.EndsWith("_fallback"))
				{
					TMP_FontAsset fontAsset = assetBundle.LoadAsset<TMP_FontAsset>(file);

					fontAssetDict.Add(fileName, fontAsset);

					Log.LogInfo($"Font for language '{fileName}' loaded");
				}
			}
				
			InitFallback(assetBundle);
			#else
			string defaultFontDir = Path.Combine("PvZ_Fusion_Translator", "[Custom Fonts]", "English.ttf");

			TMP_FontAsset defaultFont = FontHandler.LoadTMPFont(defaultFontDir, true);
			fontAssetDict.Add("English", defaultFont);
			#endif
		}

		internal static void InitFallback(AssetBundle assetBundle)
		{
			string fontsDir = Path.Combine(Core.Instance.modsDirectory, "[Custom Fonts]");

			foreach (string file in assetBundle.GetAllAssetNames())
			{ 
				string fileName = Path.GetFileNameWithoutExtension(file);

				if (fileName.EndsWith("_almanac") || fileName.EndsWith("_fallback"))
				{
					TMP_FontAsset fallbackFont = assetBundle.LoadAsset<TMP_FontAsset>(file);

					string fileNameLanguage = fileName.Replace("_fallback", "").Replace("_almanac", "");

					if (fontAssetDictSecondary.ContainsKey(fileNameLanguage))
					{
						if (fileName.EndsWith("_Fallback"))
						{
							fontAssetDictSecondary.Add(fileNameLanguage + "_almanac", fontAssetDictSecondary[fileNameLanguage]);
							fontAssetDictSecondary.Remove(fileNameLanguage);
						}
						else
						{
							fontAssetDictSecondary.Add(fileNameLanguage + "_fallback", fontAssetDictSecondary[fileNameLanguage]);
							fontAssetDictSecondary.Remove(fileNameLanguage);
						}
						fontAssetDictSecondary.Add(fileName, fallbackFont);
					}
					else
						fontAssetDictSecondary.Add(fileNameLanguage, fallbackFont);

					// Log.LogInfo($"Fallback font for language '{fileNameLanguage}' loaded");
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
				if (fontAssetDictSecondary.ContainsKey(lang + "_almanac"))
				{
					fontAssetDict[lang].fallbackFontAssetTable.Add(fontAssetDictSecondary[lang + "_almanac"]);
					Log.LogInfo("Fallback font for language '" + lang + "' added");
					continue;
				}
				if (fontAssetDictSecondary.ContainsKey(lang + "_fallback"))
				{
					fontAssetDict[lang].fallbackFontAssetTable.Add(fontAssetDictSecondary[lang + "_fallback"]);
					Log.LogInfo("Fallback font for language '" + lang + "' added");
					continue;
				}
			}
		}

		#if MULTI_LANGUAGE
		public static TMP_FontAsset LoadTMPFont(string language)
		{
			if (fontAssetDict.TryGetValue(language.ToLower(), out TMP_FontAsset font))
			{
				TMP_FontAsset fontAsset = font;
				if (fontAsset.fallbackFontAssetTable != null)
				{
					// Log.LogInfo("Fallback font for language '" + language + "' loaded. The name of the FB Font is" + fontAsset.fallbackFontAssetTable[0].name);
				}
				return fontAsset;
			}
			return fontAssetDict.GetValueOrDefault("english");
		}
		#else
		public static TMP_FontAsset LoadTMPFont()
		{
			TMP_FontAsset defaultFont = fontAssetDict["English"];
			return defaultFont;
		}
		#endif

		public static TMP_FontAsset LoadTMPFontAlmanac(string language)
		{
			if (fontAssetDictSecondary.ContainsKey(language))
			{
				if (fontAssetDictSecondary.TryGetValue(language, out TMP_FontAsset almanacAsset))
				{
					return almanacAsset;
				}
			}
			if (fontAssetDictSecondary.ContainsKey(language + "_almanac"))
			{
				if (fontAssetDictSecondary.TryGetValue(language + "_almanac", out TMP_FontAsset almanacAsset))
				{
					return almanacAsset;
				}
			}

			return fontAssetDict.GetValueOrDefault("english");
		}

		#if MULTI_LANGUAGE
		public static void Reload()
		{
			// Get the current language
			string currentLanguage = Utils.Language.ToString();

			// Load the font for the current language
			_ = LoadTMPFont(currentLanguage);
		}
		#endif

	}
}
