using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator;

public static class ModFeatures
{
    public enum ModType
    {
        ReloadStrings, ReloadTextures, ExportLevelStrings,
    }

    private sealed class ModFeature(string name, ModType modType, KeyCode keyCode, bool defaultValue = false)
    {
        // ReSharper disable once UnusedMember.Local
        public string Name { get; private set; } = name;

        // ReSharper disable once MemberCanBePrivate.Local
        public ModType ModType { get; } = modType;

        public KeyCode KeyCode { get; } = keyCode;

        // ReSharper disable once UnusedMember.Local
        public bool IsActive { get; set; } = defaultValue;

        public void ToggleFeature()
        {
            switch (ModType)
            {
                case ModType.ReloadStrings:
                    StringStore.Reload();
                    Core.ShowToast("Strings Reloaded!");
                    return;
                case ModType.ReloadTextures:
                    TextureStore.Reload();
                    Core.ShowToast("Textures Reloaded!");
                    return;
                case ModType.ExportLevelStrings:
                    var customMenu = UnityEngine.Object.FindObjectOfType<CustomMenu>();

                    if (!customMenu)
                        return;

                    if (!customMenu.isActiveAndEnabled)
                        return;

                    Patches.Modes.Super_Editor.GameLevel.LevelManager_Patch
                       .ExportLevelStrings(customMenu.LevelData);

                    Core.ShowToast("Dumped level strings!");
                    return;
                default: return;
            }
        }
    }

    public static bool IsDebug { get; } = IsDefined("PVZ_FUSION_TRANSLATOR_DEBUG");

    public static bool IsTesting { get; } = IsDefined("PVZ_FUSION_TRANSLATOR_TESTING");

    public static bool IsAudioTesting { get; } = IsDefined("PVZ_FUSION_TRANSLATOR_AUDIO_TESTING");

    public static bool IsMultiLanguage { get; } = IsDefined("PVZ_FUSION_TRANSLATOR_MULTI_LANGUAGE", true);

    private static readonly Dictionary<ModType, ModFeature> s_featureLists = new()
    {
        { ModType.ReloadStrings, new("Reload Strings", ModType.ReloadStrings, KeyCode.Home, true) },
        { ModType.ReloadTextures, new("Reload Textures", ModType.ReloadTextures, KeyCode.End, true) },
        {
            ModType.ExportLevelStrings,
            new("Export Level Strings", ModType.ExportLevelStrings, KeyCode.N, true)
        },
    };

    public static void ToggleFeature(ModType modType)
    {
        if (s_featureLists.TryGetValue(modType, out var list))
            list.ToggleFeature();
    }

    public static void OnLateUpdate()
    {
        foreach (var (_, feature) in s_featureLists)
            if (feature.KeyCode != KeyCode.None && Enum.IsDefined(feature.KeyCode))
                if (Input.GetKeyDown(feature.KeyCode))
                    feature.ToggleFeature();
    }

    private static bool IsDefined(string env, bool fallback = false)
    {
        var ret =
            Environment.GetEnvironmentVariable(env)?.ToUpperInvariant() is not "FALSE" and not "0" and var value &&
            (!string.IsNullOrWhiteSpace(value) || fallback);

        Log.LogInfo($"The feature '{env}' is {(ret ? "enabled" : "disabled")}.");
        return ret;
    }
}
