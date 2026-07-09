using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using BepInEx.Unity.IL2CPP.Utils;
using TMPro;
using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using System;
using System.IO;
using System.Reflection;
using UnityEngine;

[BepInPlugin("PVZFusionTranslator_BepInEx", "PvZ Fusion Translator", "3.6.1.3")]
[BepInProcess("PlantsVsZombiesRH.exe")]
public class PluginCore : BasePlugin
{
	public string modsDirectory => Path.Combine(Paths.PluginPath, "PvZ_Fusion_Translator");

	private static DateTime dtStart;
	private static DateTime? dtStartToast;
	private static string toast_txt;

	public static bool IsInitialized { get; private set; } = false;

	public new static ManualLogSource Log;
	public static PluginCore Instance { get; private set; }
	public static MonoBehaviour MonoInstance { get; private set; }

	private Coroutine replaceTextureRoutine = null;

	public ConfigEntry<bool> configDefaultTextures;
	public ConfigEntry<bool> configDefaultAudio;
	public ConfigEntry<string> configLanguage;
	public ConfigEntry<bool> configUseLocal;
	public ConfigEntry<bool> configEnableDllUpdate;

    private static float lastCheck = 0f;
	private static float checkTime = 0f;
    private static float checkInterval = 2f;
    private static bool stringreloaded = false;

    public override void Load()
    {
        Log = base.Log;
        Instance = this;
        LoadConfig();
        MonoInstance = AddComponent<UnityCoroutineHelper>();
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
        dtStart = DateTime.Now;

        // TODO: Get game version for DllStore - may need adjustment for BepInEx
        FileLoader.LoadLanguage();

        AudioStore.Init();
        TextureStore.Init();
        TextureStore.ReplaceTextures();
        Utils.RebuildAllSpriteRenderers();
        StringStore.Init();
        FontStore.Init();
        Utils.RegisterPlantIndices();
        Utils.CacheAlmanacData();
        TravelMgr_Patch.DumpTravelBuffs();

        replaceTextureRoutine = MonoInstance.StartCoroutine(TextureStore.ReplaceTexturesCoroutine());

		IsInitialized = true;
    }

	public override bool Unload()
	{
		if (replaceTextureRoutine != null)
		{
			MonoInstance.StopCoroutine(replaceTextureRoutine);
			Log.LogInfo("Coroutine Stopped");
		}
        FileLoader.SaveLanguage();
        
        #if OBFUSCATE && !RELEASE
		CheckSumStore.ConvertMD5Json();
		#endif

		return true;
	}
	public void InitCoroutine()
	{
		replaceTextureRoutine = MonoInstance.StartCoroutine(TextureStore.ReplaceTexturesCoroutine());
	}
	public static void ShowToast(string message)
	{
		toast_txt = message;
		dtStartToast = DateTime.Now;
	}

	public void OnUpdate()
	{
		ModFeatures.OnLateUpdate();

		if (Input.GetKeyDown(KeyCode.Semicolon))
		{
			Log.LogInfo("Semicolon press - reloading strings");
			StringStore.Reload();
			ShowToast("Strings Reloaded!");
		}

		if (Input.GetKeyDown(KeyCode.Insert))
		{
			Log.LogInfo("Insert press");
			Utils.OpenSaveDirectory();
		}

		if (Input.GetKeyDown(KeyCode.Delete))
		{
			Log.LogInfo("del del");
			Utils.OpenOnlineAlmanac();
        }
        if (TowerManager.Instance != null)
        {
            TowerManager_Patch.UpdateText();
        }
        if (Input.GetKeyDown(KeyCode.RightShift))
		{
			stringreloaded = !stringreloaded;
		}
		PluginCore.DebugStringReload();
    }

	public static void DebugStringReload()
	{
        if (stringreloaded)
        {
            checkTime += Time.deltaTime;
            if (checkTime >= checkInterval)
            {
                StringStore.Reload();
                ShowToast("Strings Reloaded!");
                checkTime = 0f;
            }
        }
    }

    public void OnGUI()
	{
		#if MULTI_LANGUAGE
		if (dtStartToast != null)
		{
			try
			{
                GUI.Button(new Rect(10f, 10f, 200f, 20f), "\n" + toast_txt + "\n");
            }
			catch(Exception e)
			{
				Log.LogError(e);
			}

            TimeSpan? timeSpan = DateTime.Now - dtStartToast;
			TimeSpan t = new TimeSpan(0, 0, 2);
			if (timeSpan > t)
			{
				dtStartToast = null;
			}
		}
		#endif
	}

	private void LoadConfig()
	{
		string mainCategory = "PvZ_Fusion_Translator";

		if(Config.TryGetEntry<bool>(new ConfigDefinition(mainCategory, "DefaultTextures"), out configDefaultTextures) == false)
		{
            configDefaultTextures = Config.Bind(new ConfigDefinition(mainCategory, "DefaultTextures"), false, new ConfigDescription("Use Default Textures + Translation Textures", new AcceptableValueList<bool>(true, false)));
        }

        if (Config.TryGetEntry<bool>(new ConfigDefinition(mainCategory, "DefaultAudio"), out configDefaultAudio) == false)
        {
            configDefaultAudio = Config.Bind(new ConfigDefinition(mainCategory, "DefaultAudio"), false, new ConfigDescription("Use Default Audio", new AcceptableValueList<bool>(true, false)));
        }

        if (Config.TryGetEntry<string>(new ConfigDefinition(mainCategory, "Language"), out configLanguage) == false)
        {
            configLanguage = Config.Bind(new ConfigDefinition(mainCategory, "Language"), "English", new ConfigDescription("Load the Game in this Language", new AcceptableValueList<string>("English", "French", "Italian", "German", "Spanish", "Portuguese", "Indonesian", "Vietnamese", "Javanese", "Russian", "Japanese", "Korean")));
        }

		if(Config.TryGetEntry<bool>(new ConfigDefinition(mainCategory, "UseLocal"), out configUseLocal) == false)
		{
			configUseLocal = Config.Bind(new ConfigDefinition(mainCategory, "UseLocal"), false, new ConfigDescription("Use Local Translation Data", new AcceptableValueList<bool>(true, false)));
		}

		if(Config.TryGetEntry<bool>(new ConfigDefinition(mainCategory, "EnableDllUpdate"), out configEnableDllUpdate) == false)
		{
			configEnableDllUpdate = Config.Bind(new ConfigDefinition(mainCategory, "EnableDllUpdate"), true, new ConfigDescription("Enable DLL update functionality", new AcceptableValueList<bool>(true, false)));
		}
	}
}

public class UnityCoroutineHelper : MonoBehaviour
{
	public static UnityCoroutineHelper Instance { get; private set; }

	public void Awake()
	{
		Instance = this;
	}

	public void Update()
	{
		ModFeatures.OnLateUpdate();

		if (Input.GetKeyDown(KeyCode.Insert))
		{
			Log.LogInfo("Insert press");
			Utils.OpenSaveDirectory();
		}

		if (Input.GetKeyDown(KeyCode.Delete))
		{
			Log.LogInfo("del del");
			Utils.OpenOnlineAlmanac();
		}

		if (Input.GetKeyDown(KeyCode.Home))
		{
			Log.LogInfo("Home press - reloading strings");
			StringStore.Reload();
			PluginCore.ShowToast("Strings Reloaded!");
		}
	}
}