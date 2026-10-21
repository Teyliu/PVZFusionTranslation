global using UnityEngine;
#if MELONLOADER
global using MelonLoader;
global using MelonLoader.Logging;
global using MelonLoader.Utils;
global using Il2Cpp;
global using Il2CppAlmanacData;
global using Il2CppCore;
global using Il2CppGameLevel; // ReSharper disable once RedundantUsingDirective.Global
global using Il2CppGameLevel.Abyss;
global using Il2CppGameLevel.EventNodes;
global using Il2CppGameLevel.RogueShooting;
global using Il2CppPVPScaryPot;
global using Il2CppRhythmGame;
global using Il2CppRhythmGameEditor;
global using Il2CppTMPro;
global using Il2CppZenGarden;
global using AudioImportLibAPI = AudioImportLib.API;
global using Il2CppAlmanacDataClass = Il2CppAlmanacData.AlmanacData;
global using Il2CppLevelData = Il2Cpp.LevelData;
global using Il2CppPlantInfo = Il2CppAlmanacData.PlantInfo;
#elif BEPINEX
global using AlmanacData;
global using BepInEx;
global using BepInEx.Configuration;
global using BepInEx.Logging;
global using BepInEx.Unity.IL2CPP;
global using BepInEx.Unity.IL2CPP.Utils;
global using Core;
global using GameLevel;
global using GameLevel.Abyss;
global using GameLevel.EventNodes;
global using GameLevel.RogueShooting;
global using PVPScaryPot;
global using RhythmGame;
global using RhythmGameEditor;
global using TMPro;
global using ZenGarden;
global using AudioImportLibAPI = AudioImportLib.BepInEx.API;
global using Il2CppAlmanacDataClass = AlmanacData.AlmanacData;
global using Il2CppLevelData = LevelData;
global using Il2CppPlantInfo = AlmanacData.PlantInfo;
#endif
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.Managers;
using PvZ_Fusion_Translator.Patches.Modes.Super_Editor;

#if MELONLOADER
[assembly:
    MelonGame("LanPiaoPiao", "PlantsVsZombiesRH"),
    MelonInfo(
        typeof(PvZ_Fusion_Translator.Core),
        "PvZ Fusion Translator",
        "231.0.0",
        "dynaslash / arifrios1st / lancerx0 / JustNull / Dakosha / Mamoru-kun / cassidy / Teyliu / Emik"
    )]
#endif

namespace PvZ_Fusion_Translator;
#pragma warning disable CA1822 // ReSharper disable once ClassNeverInstantiated.Global
#if MELONLOADER
public class Core : MelonMod
#elif BEPINEX
[BepInPlugin("PVZFusionTranslator_BepInEx", "PvZ Fusion Translator", "3.1.1"), BepInProcess("PlantsVsZombiesRH.exe")]
public class Core : BasePlugin
#endif
{
#if BEPINEX
    public sealed class UnityCoroutineHelper : MonoBehaviour
    {
        // ReSharper disable once MemberHidesStaticFromOuterClass
        public static UnityCoroutineHelper Instance { get; private set; }

        public void Awake() => Instance = this;
    }
#endif
    public static string ModDirectory =>
#if MELONLOADER
        Path.Combine(MelonEnvironment.ModsDirectory, "PvZ_Fusion_Translator");
#elif BEPINEX
        Path.Combine(Paths.PluginPath, "PvZ_Fusion_Translator");
#endif
    public static bool IsInitialized { get; set; }

    public static Core Instance { get; private set; }
#if MELONLOADER
    public MelonPreferences_Entry<bool> ConfigDefaultAudio, ConfigDefaultTextures, ConfigUseLocal;

    public MelonPreferences_Entry<string> ConfigLanguage;

    private object _replaceTextureRoutine;
#elif BEPINEX
    public static MonoBehaviour MonoInstance { get; private set; }

    public ConfigEntry<bool> ConfigDefaultAudio, ConfigDefaultTextures, ConfigUseLocal;

    public ConfigEntry<string> ConfigLanguage;

    public new static ManualLogSource Log { get; private set; }

    private Coroutine _replaceTextureRoutine;
#endif
    private static DateTime? s_dtStartToast;

    private static string s_toastText;
#if MELONLOADER
    public static object Coroutine(System.Collections.IEnumerator enumerator) =>
        MelonCoroutines.Start(enumerator);
#elif BEPINEX
    public static Coroutine Coroutine(System.Collections.IEnumerator enumerator) =>
        MonoInstance.StartCoroutine(enumerator);
#endif
#if MELONLOADER
    public override void OnInitializeMelon()
#elif BEPINEX
    public override void Load()
#endif
    {
        Instance = this;
        LoadConfig();

        if (ModFeatures.IsMultiLanguage)
            FileLoader.LoadLanguage();

        _replaceTextureRoutine = Coroutine(TextureStore.ReplaceTexturesCoroutine());
        TextureStore.Init();
        StringStore.Init();
        AudioStore.Init();
        FontStore.Init();
#if MELONLOADER
        base.OnInitializeMelon();
#elif BEPINEX
        Log = base.Log;
        Utils.RegisterPlantIndices();
        MonoInstance = AddComponent<UnityCoroutineHelper>();
        HarmonyLib.Harmony.CreateAndPatchAll(System.Reflection.Assembly.GetExecutingAssembly());
#endif
        IsInitialized = true;
    }
#if MELONLOADER
    public override void OnLateInitializeMelon()
    {
        FileLoader.LoadTravelBuffs();
        Utils.RegisterPlantIndices();
    }

    public override void OnDeinitializeMelon()
    {
        MelonCoroutines.Stop(_replaceTextureRoutine);

        if (ModFeatures.IsMultiLanguage)
            FileLoader.SaveLanguage();
    }
#elif BEPINEX
    public override bool Unload()
    {
        if (_replaceTextureRoutine != null)
        {
            MonoInstance.StopCoroutine(_replaceTextureRoutine);
            Log.LogDebug("Coroutine Stopped");
        }

        FileLoader.SaveLanguage();
        return true;
    }
#endif
    public static void ShowToast(string message)
    {
        s_toastText = message;
        s_dtStartToast = new(DateTime.Now.Ticks);
    }
#if MELONLOADER
    public override void OnLateUpdate()
#elif BEPINEX
    public void OnUpdate()
#endif
    {
        if (ModFeatures.IsDebug)
            ModFeatures.OnLateUpdate();

        if (Input.GetKeyDown(KeyCode.Insert))
            Utils.OpenSaveDirectory();

        if (Input.GetKeyDown(KeyCode.PageUp))
            Utils.OpenOnlineAlmanac();

        TowerManager_Patch.UpdateText();

        if (CustomLevelMenu_Patch.RequestTimer <= 0)
            return;

        CustomLevelMenu_Patch.RequestTimer -= Time.deltaTime;

        if (CustomLevelMenu_Patch.RequestTimer < 0)
            CustomLevelMenu_Patch.RequestTimer = 0;
    }
#if MELONLOADER
    public override void OnGUI()
#elif BEPINEX
    public void OnGUI()
#endif
    {
        if (!ModFeatures.IsDebug)
            return;

        if (s_dtStartToast is null)
            return;

        GUI.Button(new(10, 10, 200, 20), $"\n{s_toastText}\n");
        var timeSpan = DateTime.Now - s_dtStartToast;
        TimeSpan t = new(0, 0, 0, 2);

        if (timeSpan > t)
            s_dtStartToast = null;
    }
#if MELONLOADER
    private void LoadConfig()
    {
        var category = MelonPreferences.CreateCategory("PvZ_Fusion_Translator", "Fusion Translator Settings");

        ConfigDefaultTextures = category.CreateEntry("DefaultTextures", false);
        ConfigDefaultAudio = category.CreateEntry("DefaultAudio", false);
        ConfigUseLocal = category.CreateEntry("UseLocal", false);
        ConfigLanguage = category.CreateEntry("Language", "English");

        MelonPreferences.Save();
    }
#elif BEPINEX
    private void LoadConfig()
    {
        const string MainCategory = "PvZ_Fusion_Translator";

        if (!Config.TryGetEntry(new(MainCategory, "DefaultTextures"), out ConfigDefaultTextures))
            ConfigDefaultTextures = Config.Bind(
                new(MainCategory, "DefaultTextures"),
                false,
                new("Use Default Textures + Translation Textures", new AcceptableValueList<bool>(true, false))
            );

        Debug.Assert(Config.TryGetEntry(new(MainCategory, "DefaultTextures"), out ConfigDefaultTextures));

        if (!Config.TryGetEntry(new(MainCategory, "DefaultAudio"), out ConfigDefaultAudio))
            ConfigDefaultAudio = Config.Bind(
                new(MainCategory, "DefaultAudio"),
                false,
                new("Use Default Audio", new AcceptableValueList<bool>(true, false))
            );

        Debug.Assert(Config.TryGetEntry(new(MainCategory, "DefaultAudio"), out ConfigDefaultAudio));

        if (!Config.TryGetEntry(new(MainCategory, "UseLocal"), out ConfigDefaultAudio))
            ConfigUseLocal = Config.Bind(
                new(MainCategory, "UseLocal"),
                false,
                new("Use Local", new AcceptableValueList<bool>(true, false))
            );

        Debug.Assert(Config.TryGetEntry(new(MainCategory, "DefaultAudio"), out ConfigDefaultAudio));

        string[] supportedLanguages =
        [
            "English", "French", "Italian", "German", "Spanish", "Portuguese", "Indonesian",
            "Vietnamese", "Javanese", "Russian", "Japanese", "Korean",
        ];

        if (!Config.TryGetEntry(new(MainCategory, "Language"), out ConfigLanguage))
            ConfigLanguage = Config.Bind(
                new(MainCategory, "Language"),
                "English",
                new("Load the Game in this Language", new AcceptableValueList<string>(supportedLanguages))
            );

        Debug.Assert(Config.TryGetEntry(new(MainCategory, "Language"), out ConfigLanguage));
    }
#endif
}
