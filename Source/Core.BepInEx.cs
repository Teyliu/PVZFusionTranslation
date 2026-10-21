#if BEPINEX
global using AlmanacData;
global using BepInEx;
global using BepInEx.Configuration;
global using BepInEx.Logging;
global using BepInEx.Unity.IL2CPP;
global using BepInEx.Unity.IL2CPP.Utils;
global using Core;
global using GameLevel; // ReSharper disable once RedundantUsingDirective.Global
global using GameLevel.Abyss;
global using GameLevel.EventNodes;
global using GameLevel.RogueShooting;
global using PVPScaryPot;
global using RhythmGame;
global using RhythmGameEditor;
global using TMPro;
global using UnityEngine;
global using ZenGarden;
global using AudioImportLibAPI = AudioImportLib.BepInEx.API;
global using Il2CppAlmanacDataClass = AlmanacData.AlmanacData;
global using Il2CppLevelData = LevelData;
global using Il2CppPlantInfo = AlmanacData.PlantInfo;
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.Managers;
using PvZ_Fusion_Translator.Patches.Modes.Super_Editor;

namespace PvZ_Fusion_Translator;
#pragma warning disable CA1822 // ReSharper disable once ClassNeverInstantiated.Global
[BepInPlugin("PVZFusionTranslator_BepInEx", "PvZ Fusion Translator", "3.1.1"), BepInProcess("PlantsVsZombiesRH.exe")]
public class Core : BasePlugin
{
    public sealed class UnityCoroutineHelper : MonoBehaviour
    {
        // ReSharper disable once MemberHidesStaticFromOuterClass
        public static UnityCoroutineHelper Instance { get; private set; }

        public void Awake() => Instance = this;
    }

    public static string ModDirectory => Path.Combine(Paths.PluginPath, "PvZ_Fusion_Translator");

    public static bool IsInitialized { get; set; }

    public static Core Instance { get; private set; }

    public static MonoBehaviour MonoInstance { get; private set; }

    public ConfigEntry<bool> ConfigDefaultAudio, ConfigDefaultTextures, ConfigUseLocal;

    public ConfigEntry<string> ConfigLanguage;

    public new static ManualLogSource Log { get; private set; }

    private Coroutine _replaceTextureRoutine;

    private static DateTime? s_dtStartToast;

    private static string s_toastText;

    public static Coroutine Coroutine(System.Collections.IEnumerator enumerator) =>
        MonoInstance.StartCoroutine(enumerator);

    public override void Load()
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
        Log = base.Log;
        Utils.RegisterPlantIndices();
        MonoInstance = AddComponent<UnityCoroutineHelper>();
        HarmonyLib.Harmony.CreateAndPatchAll(System.Reflection.Assembly.GetExecutingAssembly());
        IsInitialized = true;
    }

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

    public static void ShowToast(string message)
    {
        s_toastText = message;
        s_dtStartToast = new(DateTime.Now.Ticks);
    }

    public void OnUpdate()
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

    public void OnGUI()
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
}
#endif
