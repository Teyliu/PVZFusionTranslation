using TMPro;
using System.Collections.Generic;
using System.IO;

namespace PvZ_Fusion_Translator__BepInEx_.AssetStore
{
    public static class FontStore
    {
        internal static Dictionary<string, TMP_FontAsset> fontAssetDict = [];
        internal static Dictionary<string, TMP_FontAsset> fontAssetDictSecondary = [];

        internal static void Init()
        {
            // Clear existing dictionaries to prevent duplicate key errors
            fontAssetDict.Clear();
            fontAssetDictSecondary.Clear();
            
            string fontsDir = Path.Combine(PluginCore.Instance.modsDirectory, "[Custom Fonts]");

#if MULTI_LANGUAGE
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
                        if (!fontAssetDict.ContainsKey(fileName))
                        {
                            fontAssetDict.Add(fileName, fontAsset);
                        }

                        Log.LogInfo($"Font for language '{fileName}' loaded");
                    }
                }
            }

            InitFallback();
#else
			string defaultFontDir = Path.Combine("PvZ_Fusion_Translator", "[Custom Fonts]", "English.ttf");

			TMP_FontAsset defaultFont = FontHandler.LoadTMPFont(defaultFontDir, true);
			fontAssetDict.Add("English", defaultFont);
#endif
        }

        internal static void InitFallback()
        {
            string fontsDir = Path.Combine(PluginCore.Instance.modsDirectory, "[Custom Fonts]");
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
                                if (!fontAssetDictSecondary.ContainsKey(fileNameLanguage + "_Almanac"))
                                {
                                    fontAssetDictSecondary.Add(fileNameLanguage + "_Almanac", fontAssetDictSecondary[fileNameLanguage]);
                                }
                                fontAssetDictSecondary.Remove(fileNameLanguage);
                            }
                            else
                            {
                                if (!fontAssetDictSecondary.ContainsKey(fileNameLanguage + "_Fallback"))
                                {
                                    fontAssetDictSecondary.Add(fileNameLanguage + "_Fallback", fontAssetDictSecondary[fileNameLanguage]);
                                }
                                fontAssetDictSecondary.Remove(fileNameLanguage);
                            }
                            if (!fontAssetDictSecondary.ContainsKey(fileName))
                            {
                                fontAssetDictSecondary.Add(fileName, fallbackFont);
                            }
                        }
                        else
                        {
                            if (!fontAssetDictSecondary.ContainsKey(fileNameLanguage))
                            {
                                fontAssetDictSecondary.Add(fileNameLanguage, fallbackFont);
                            }
                        }
                    }
                }
            }
            AddFallback();
        }

        public static void AddFallback()
        {
            foreach (var lang in fontAssetDict.Keys)
            {
                TMP_FontAsset primaryFont = fontAssetDict[lang];
                if (primaryFont.fallbackFontAssetTable == null)
                {
                    primaryFont.fallbackFontAssetTable = new Il2CppSystem.Collections.Generic.List<TMP_FontAsset>();
                }

                if (fontAssetDictSecondary.TryGetValue(lang, out TMP_FontAsset fallback))
                {
                    primaryFont.fallbackFontAssetTable.Add(fallback);
                    Log.LogInfo("Fallback font for language '" + lang + "' added");
                    continue;
                }
                if (fontAssetDictSecondary.TryGetValue(lang + "_Almanac", out fallback))
                {
                    primaryFont.fallbackFontAssetTable.Add(fallback);
                    Log.LogInfo("Fallback font for language '" + lang + "' added");
                    continue;
                }
                if (fontAssetDictSecondary.TryGetValue(lang + "_Fallback", out fallback))
                {
                    primaryFont.fallbackFontAssetTable.Add(fallback);
                    Log.LogInfo("Fallback font for language '" + lang + "' added");
                    continue;
                }
            }
        }

#if MULTI_LANGUAGE
        public static TMP_FontAsset LoadTMPFont(string language)
        {
            if (fontAssetDict.TryGetValue(language, out TMP_FontAsset font))
            {
                return font;
            }
            return fontAssetDict.GetValueOrDefault("English");
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
            if (fontAssetDictSecondary.TryGetValue(language, out TMP_FontAsset almanacAsset))
            {
                return almanacAsset;
            }
            if (fontAssetDictSecondary.TryGetValue(language + "_Almanac", out almanacAsset))
            {
                return almanacAsset;
            }

            return fontAssetDict.GetValueOrDefault("English");
        }

#if MULTI_LANGUAGE
        public static void Reload()
        {
        }
#endif

    }
}