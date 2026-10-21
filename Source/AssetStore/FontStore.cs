namespace PvZ_Fusion_Translator.AssetStore;

public static class FontStore
{
    internal static readonly Dictionary<string, TMP_FontAsset> FontAssetDict = [], FontAssetDictSecondary = [];

    internal static void Init()
    {
        var fontsDir = Path.Combine(Core.ModDirectory, "[Custom Fonts]");
        var assetBundle = Utils.GetAssetBundle(Path.Combine(fontsDir, "translation"));

        if (ModFeatures.IsMultiLanguage)
        {
            foreach (var file in assetBundle.GetAllAssetNames())
            {
                var fileName = Path.GetFileNameWithoutExtension(file);

                if (fileName.EndsWith("_almanac") || fileName.EndsWith("_fallback"))
                    continue;

                var fontAsset = assetBundle.LoadAsset<TMP_FontAsset>(file);
                FontAssetDict.Add(fileName, fontAsset);
                Log.LogInfo($"Font for language '{fileName}' loaded");
            }

            InitFallback(assetBundle);
        }
        else
        {
            var defaultFontDir = Path.Combine("[Custom Fonts]", "English.ttf");
            var defaultFont = FontHandler.LoadTMPFont(defaultFontDir, true);
            FontAssetDict.Add("English", defaultFont);
        }
    }

    internal static void InitFallback(AssetBundle assetBundle)
    {
        foreach (var file in assetBundle.GetAllAssetNames())
        {
            var fileName = Path.GetFileNameWithoutExtension(file);

            if (!fileName.EndsWith("_almanac") && !fileName.EndsWith("_fallback"))
                continue;

            var fallbackFont = assetBundle.LoadAsset<TMP_FontAsset>(file);
            var fileNameLanguage = fileName.Replace("_fallback", "").Replace("_almanac", "");
            Utils.TryAdd(FontAssetDictSecondary, fileName, fallbackFont);

            if (ModFeatures.IsDebug)
                Log.LogInfo($"Fallback font for language '{fileNameLanguage}' loaded");
        }

        AddFallback();
    }

    public static void AddFallback()
    {
        foreach (var lang in FontAssetDict.Keys)
        {
            FontAssetDict[lang].fallbackFontAssetTable ??= new();

            if (FontAssetDictSecondary.TryGetValue(lang, out var value))
            {
                FontAssetDict[lang].fallbackFontAssetTable.Add(value);
                Log.LogInfo("Fallback font for language '" + lang + "' added");
                continue;
            }

            if (FontAssetDictSecondary.TryGetValue(lang + "_almanac", out var valueAlmanac))
            {
                FontAssetDict[lang].fallbackFontAssetTable.Add(valueAlmanac);
                Log.LogInfo("Fallback font for language '" + lang + "' added");
                continue;
            }

            if (!FontAssetDictSecondary.TryGetValue(lang + "_fallback", out var valueFallback))
                continue;

            FontAssetDict[lang].fallbackFontAssetTable.Add(valueFallback);
            Log.LogInfo("Fallback font for language '" + lang + "' added");
        }
    }

    public static TMP_FontAsset LoadTMPFont(string language)
    {
        Debug.Assert(ModFeatures.IsMultiLanguage, nameof(ModFeatures.IsMultiLanguage));

        if (!FontAssetDict.TryGetValue(language.ToLower(), out var font))
            return FontAssetDict.GetValueOrDefault("english");

        if (ModFeatures.IsDebug && font.fallbackFontAssetTable != null)
            Log.LogInfo(
                $"Fallback font for language '{language}' loaded. The name of the FB Font is{font.fallbackFontAssetTable[0].name}"
            );

        return font;
    }

    public static TMP_FontAsset LoadTMPFont()
    {
        Debug.Assert(ModFeatures.IsMultiLanguage, nameof(ModFeatures.IsMultiLanguage));
        var defaultFont = FontAssetDict["English"];
        return defaultFont;
    }

    public static TMP_FontAsset LoadTMPFontAlmanac(string language) =>
        FontAssetDictSecondary.TryGetValue(language.ToLower(), out var first) ? first :
        FontAssetDictSecondary.TryGetValue(language.ToLower() + "_almanac", out var second) ? second :
        FontAssetDict.GetValueOrDefault("english");

    public static void Reload()
    {
        Debug.Assert(ModFeatures.IsMultiLanguage, nameof(ModFeatures.IsMultiLanguage));
        // Get the current language and load its corresponding font.
        _ = LoadTMPFont(Utils.Language.ToString());
    }
}
