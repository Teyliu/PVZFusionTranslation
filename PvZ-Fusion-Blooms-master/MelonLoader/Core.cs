using MelonLoader;
using MelonLoader.Utils;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

[assembly: MelonInfo(typeof(PvZ_Fusion_Translator.Core), "PvZ Fusion Translator", "231.0.0", "dynaslash / arifrios1st / lancerx0", null)]
[assembly: MelonGame("LanPiaoPiao", "PlantsVsZombiesRH")]

namespace PvZ_Fusion_Translator
{
	public class Core : MelonMod
	{
		private static DateTime dtStart;
		private static DateTime? dtStartToast;
		private static string toast_txt;
		public static Core Instance { get; private set; }

		object replaceTextureRoutine = null;

		public override void OnEarlyInitializeMelon() => dtStart = DateTime.Now;

		public override void OnInitializeMelon()
		{
			base.OnInitializeMelon();
			Instance = this;
			Config();
			#if MULTI_LANGUAGE
			FileLoader.LoadLanguage();
			#endif
			TextureStore.Init();
			StringStore.Init();
			AudioStore.Init();
			FontStore.Init();
		}

		public override void OnLateInitializeMelon()
		{
			dtStart = DateTime.Now;
			replaceTextureRoutine = MelonCoroutines.Start(TextureStore.ReplaceTexturesCoroutine());
		}

		public override void OnDeinitializeMelon()
		{
			MelonCoroutines.Stop(replaceTextureRoutine);
			#if MULTI_LANGUAGE
			FileLoader.SaveLanguage();
			#endif
			#if OBFUSCATE && !RELEASE
			CheckSumStore.ConvertMD5Json();
			#endif
		}

		public static void ShowToast(string message)
		{
			toast_txt = message;
			dtStartToast = new DateTime?(DateTime.Now);
		}
		
		public override void OnLateUpdate()
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

		public override void OnGUI()
		{
			#if DEBUG
			if (dtStartToast != null)
			{
				GUI.Button(new Rect(10f, 10f, 200f, 20f), "\n" + toast_txt + "\n");
				TimeSpan? timeSpan = DateTime.Now - dtStartToast;
				TimeSpan t = new(0, 0, 0, 2);
				if (timeSpan > t)
				{
					dtStartToast = null;
				}
			}
			#endif
		}

		public String modsDirectory => Path.Combine(MelonEnvironment.ModsDirectory, "PvZ_Fusion_Translator");

		public MelonPreferences_Entry<bool> configDefaultTextures;
		public MelonPreferences_Entry<bool> configDefaultAudio;
		public MelonPreferences_Entry<string> configLanguage;

		private void Config()
		{
			var category = MelonPreferences.CreateCategory("PvZ_Fusion_Translator", "Fusion Translator Settings");

			configDefaultTextures = category.CreateEntry("DefaultTextures", false);
			configDefaultAudio = category.CreateEntry("DefaultAudio", false);
			configLanguage = category.CreateEntry("Language", "English");

			MelonPreferences.Save();
		}
	}
}