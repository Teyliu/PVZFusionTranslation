namespace PvZ_Fusion_Translator;

public static class FontHandler
{
    public static Font LoadFont(string pathFromModFolder, bool throwException)
    {
        var fontFilePath = Path.Combine(Core.ModDirectory, pathFromModFolder);

        if (!File.Exists(fontFilePath))
        {
            if (throwException)
                Log.LogWarning($"Font not found at path: '{fontFilePath}'.");

            return null;
        }

        Font font = new();
        Font.Internal_CreateFontFromPath(font, fontFilePath);
        return font;
    }

    public static TMP_FontAsset ConvertToTMP(this Font font)
    {
        var fontAsset = TMP_FontAsset.CreateFontAsset(font);

        if (fontAsset != null)
            return fontAsset;

        Log.LogWarning($"Failed to create TMP_FontAsset from font '{font.name}'.");
        return null;
    }

    public static TMP_FontAsset LoadTMPFont(string pathFromModFolder, bool throwException)
    {
        var font = LoadFont(pathFromModFolder, throwException);

        if (!font)
            return null;

        var fontAsset = font.ConvertToTMP();
        return fontAsset;
    }
}
