﻿using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using BepInEx.Unity.IL2CPP.Utils;
using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using System;
using System.IO;
using System.Reflection;
using UnityEngine;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInProcess("PlantsVsZombiesRH.exe")]
public class Core : BasePlugin
{
	public string modsDirectory => Path.Combine(Paths.PluginPath, "PvZ_Fusion_Translator");

	private static DateTime dtStart;
	private static DateTime? dtStartToast;
	private static string toast_txt;

	public new static ManualLogSource Log;
	public static Core Instance { get; private set; }
	public static MonoBehaviour MonoInstance { get; private set; }

	private Coroutine replaceTextureRoutine = null;

	public ConfigEntry<bool> configDefaultTextures;
	public ConfigEntry<bool> configDefaultAudio;
	public ConfigEntry<string> configLanguage;

	public override void Load()
	{
		Log = base.Log;
		Instance = this;
		MonoInstance = AddComponent<UnityCoroutineHelper>();
		Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
		LoadConfig();

		FileLoader.LoadLanguage();

		AudioStore.Init();
		TextureStore.Init();
		StringStore.Init();
		FontStore.Init();

        InitCoroutine();
	}

	public override bool Unload()
	{
		if (replaceTextureRoutine != null)
		{
			MonoInstance.StopCoroutine(replaceTextureRoutine);
			Log.LogDebug("Coroutine Stopped");
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

	public void Update()
	{
		#if DEBUG
		ModFeatures.OnLateUpdate();
		#endif

		if (Input.GetKeyDown(KeyCode.Insert))
		{
			Utils.OpenSaveDirectory();
		}

		if (Input.GetKeyDown(KeyCode.Delete))
		{
			Utils.OpenTrello();
		}
	}

	public void OnGUI()
	{
		#if DEBUG
		if (dtStartToast != null)
		{
			GUI.Button(new Rect(10f, 10f, 200f, 20f), "\n" + toast_txt + "\n");
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
        bool defaultTextures = Config.TryGetEntry<bool>(new ConfigDefinition("PvZ_Fusion_Translator", "DefaultTextures"), out configDefaultTextures);

        if (Config.TryGetEntry<bool>(new ConfigDefinition(mainCategory, "DefaultAudio"), out configDefaultAudio) == false)
        {
            configDefaultAudio = Config.Bind(new ConfigDefinition(mainCategory, "DefaultAudio"), false, new ConfigDescription("Use Default Audio", new AcceptableValueList<bool>(true, false)));
        }
        bool defaultAudio = Config.TryGetEntry<bool>(new ConfigDefinition("PvZ_Fusion_Translator", "DefaultAudio"), out configDefaultAudio);

        if (Config.TryGetEntry<string>(new ConfigDefinition(mainCategory, "Language"), out configLanguage) == false)
        {
            configLanguage = Config.Bind(new ConfigDefinition(mainCategory, "Language"), "English", new ConfigDescription("Load the Game in this Language", new AcceptableValueList<string>("English", "French", "Italian", "German", "Spanish", "Portuguese", "Indonesian", "Vietnamese", "Javanese", "Russian", "Japanese", "Korean")));
        }
		bool language = Config.TryGetEntry<string>(new ConfigDefinition("PvZ_Fusion_Translator", "Language"), out configLanguage);
    }
}

public class UnityCoroutineHelper : MonoBehaviour
{
	public static UnityCoroutineHelper Instance { get; private set; }

	public void Awake()
	{
		Instance = this;
	}
}