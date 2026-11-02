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
global using UnityEngine;
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.Managers;
using PvZ_Fusion_Translator.Patches.Modes.Super_Editor;

[assembly:
    MelonGame("LanPiaoPiao", "PlantsVsZombiesRH"),
    MelonInfo(
        typeof(PvZ_Fusion_Translator.Core),
        "PvZ Fusion Translator",
        "231.0.0",
        "dynaslash / arifrios1st / lancerx0 / JustNull / Dakosha / Mamoru-kun / cassidy / Teyliu / Emik / sunfun"
    )]

namespace PvZ_Fusion_Translator;
#pragma warning disable CA1822 // ReSharper disable once ClassNeverInstantiated.Global
public class Core : MelonMod
{
    public static string ModDirectory =>
        Path.Combine(MelonEnvironment.ModsDirectory, "PvZ_Fusion_Translator");

    public static bool IsInitialized { get; set; }

    public static Core Instance { get; private set; }

    public MelonPreferences_Entry<bool> ConfigDefaultAudio, ConfigDefaultTextures, ConfigUseLocal;

    public MelonPreferences_Entry<string> ConfigLanguage;

    private object _replaceTextureRoutine;

    private static DateTime? s_dtStartToast;

    private static string s_toastText;

    public static object Coroutine(System.Collections.IEnumerator enumerator) =>
        MelonCoroutines.Start(enumerator);

    public override void OnInitializeMelon()
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
        base.OnInitializeMelon();
        IsInitialized = true;
    }

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

    public static void ShowToast(string message)
    {
        s_toastText = message;
        s_dtStartToast = new(DateTime.Now.Ticks);
    }

    public override void OnLateUpdate()
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

    public override void OnGUI()
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
        var category = MelonPreferences.CreateCategory("PvZ_Fusion_Translator", "Fusion Translator Settings");

        ConfigDefaultTextures = category.CreateEntry("DefaultTextures", false);
        ConfigDefaultAudio = category.CreateEntry("DefaultAudio", false);
        ConfigUseLocal = category.CreateEntry("UseLocal", false);
        ConfigLanguage = category.CreateEntry("Language", "English");

        MelonPreferences.Save();
    }
}
#endif
