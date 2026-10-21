using System.Collections;

namespace PvZ_Fusion_Translator.AssetStore;

public static class TextureStore
{
    internal static readonly Dictionary<string, byte[]> TextureDict = [], SpriteDict = [];

    internal static void Init() => FileLoader.LoadTextures();

    internal static void Reload()
    {
        TextureDict.Clear();

        if (ModFeatures.IsMultiLanguage)
            RestoreTextures();

        FileLoader.LoadTextures();
    }

    public static IEnumerator ReplaceTexturesCoroutine()
    {
        while (true)
        {
            ReplaceTextures();
            yield return new WaitForSeconds(0.5f); // Adjust this interval as needed
        } // ReSharper disable once IteratorNeverReturns
    }

    public static void ReplaceTextures()
    {
        foreach (var texture in Resources
           .FindObjectsOfTypeAll<Texture2D>()
           .Where(texture => !texture.name.StartsWith("replaced_")))
            Utils.TryReplaceTexture2D(texture);
    }

    public static void RestoreTextures()
    {
        Debug.Assert(ModFeatures.IsMultiLanguage, nameof(ModFeatures.IsMultiLanguage));

        Texture2D[] textures = Resources.FindObjectsOfTypeAll<Texture2D>();

        foreach (var texture in textures.Where(texture => texture != null))
            texture.name = texture.name.Replace("replaced_", "");
    }

    public static void LogAll()
    {
        Log.LogInfo("Logging all TextureStore entries.");

        foreach (var entry in TextureDict)
            Log.LogInfo("TextureDict Entry: " + entry.Key + " | " + entry.Value);
    }
}
