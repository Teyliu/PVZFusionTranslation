using HarmonyLib;
using MelonLoader;
using MelonLoader.Utils;
using System.Reflection;
using UnityEngine;

namespace PvZ_Fusion_Translator.AssetStore
{
    internal class AudioStore
	{
		public static Dictionary<string, AudioClip> AudioClips = [];
		public static Dictionary<string, (string, string)> AudioClipNames = [];

		public static bool LogSounds;

		private static bool overrideEnabled;
		private static readonly string customAudioPath = Path.Combine(MelonEnvironment.ModsDirectory, "PvZ_Fusion_Translator", "[Custom Audios]");
		private static readonly string[] allowedExts = [".wav", ".mp3", ".ogg"];

		#if AUDIO_TESTING
		public Canvas Canvas { get; set; }
		public RectTransform songRectTransform { get; private set; }
		#endif
		
		public static void Init()
		{
			bool loadCustomAudio = MelonPreferences.GetEntryValue<bool>("PvZ_Fusion_Translator", "DefaultAudio");
			if (loadCustomAudio)
			{
				return;
			}
			else
			{
				LoadAudios();
			}
		}
		public static void LoadAudios()
		{
			if (!Directory.Exists(customAudioPath))
				Directory.CreateDirectory(customAudioPath);

			var category = MelonPreferences.CreateCategory("Audio Replace", "");
			category.CreateEntry("LogSounds", false);
			LogSounds = category.GetEntry<bool>("LogSounds").Value;
			MelonPreferences.Save();

			string[] audioFiles = Directory.GetFiles(customAudioPath, "*", SearchOption.AllDirectories);
			var ovrClip = audioFiles.SingleOrDefault(f => Path.GetFileNameWithoutExtension(f) == "REPLACE_ALL");
			if (ovrClip == null)
			{
				foreach (string file in audioFiles)
				{
					if (!allowedExts.Contains(Path.GetExtension(file)))
						continue;

					AudioClip clip = AudioImportLib.API.LoadAudioClip(file);
					AudioClips.Add(clip.name, clip);
					Log.LogInfo("Added Override: " + clip.name);
				}
			}
			else
			{
				AudioClip clip = AudioImportLib.API.LoadAudioClip(ovrClip);
				AudioClips.Add(clip.name, clip);
				overrideEnabled = true;
				Log.LogInfo("Added Override: " + clip.name);
			}

			Type audioSourceType = typeof(AudioSource);
			string sourceMethodName = "Play";
			MethodInfo prefixMethod = typeof(AudioStore).GetMethod("AudioPlayPatch", BindingFlags.Static | BindingFlags.Public);
			if (prefixMethod == null)
			{
				Log.LogError($"Couldn't find method named \"AudioPlayPatch\" in type <{typeof(Core)}>.");
				return;
			}
			_ = Core.Instance.HarmonyInstance.Patch(AccessTools.Method(audioSourceType, sourceMethodName), new HarmonyMethod(prefixMethod));
			Core.Instance.HarmonyInstance.Patch(AccessTools.Method(audioSourceType, sourceMethodName, [typeof(ulong)]), new HarmonyMethod(prefixMethod));
		}

		#if AUDIO_TESTING
		public static void InitializeCanvas()
		{

			Transform canvasTransform; 

			if (canvas != null) return; // Prevent duplicate canvas creation

			canvas = new GameObject("AudioSourceCanvas").AddComponent<Canvas>();
			canvas.renderMode = RenderMode.ScreenSpaceOverlay;

			CanvasScaler scaler = canvas.gameObject.AddComponent<CanvasScaler>();
			scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
			scaler.referenceResolution = new Vector2(1920, 1080);

			canvas.gameObject.AddComponent<GraphicRaycaster>();

			// Add a RectTransform for positioning text
			GameObject songTextObject = new GameObject("SongText");
			songTextObject.transform.SetParent(canvas.transform);

			songRectTransform = songTextObject.AddComponent<RectTransform>();
			songRectTransform.anchorMin = new Vector2(1, 1); // Top-right corner
			songRectTransform.anchorMax = new Vector2(1, 1);
			songRectTransform.pivot = new Vector2(1, 1);
			songRectTransform.anchoredPosition = new Vector2(-20, -20); // Adjust margin

			// Add a TextMeshPro component for the text
			var textComponent = songTextObject.AddComponent<TextMeshProUGUI>();
			textComponent.alignment = TextAlignmentOptions.Right;
			textComponent.fontSize = 24;
			textComponent.color = Color.white;
			textComponent.text = "Current Song: None"; // Placeholder
		}


		public static void AudioSources()
		{
			if (!Directory.Exists(customAudioPath))
				Directory.CreateDirectory(customAudioPath);
			string path = Path.Combine(customAudioPath, "audio_source.json");
			if (!File.Exists(path))
			{
				Log.LogError($"LawnStringsTranslate.json file not found at path: {path}");
				return;
			}
			string json;
			json = File.ReadAllText(path);

			AudioClipNames = JsonSerializer.Deserialize<Dictionary<string, (string, string)>>(json);
		}

		public static (string, string) GetAudioSource(string clipName)
		{
			if (AudioClipNames.TryGetValue(clipName, out var audioSource))
			{
				return audioSource;
			}
			else
			{
				return ("Music", "Source Unknown");
			}
		}

		
		public static void UpdateAudioSourceText(string clipName, string sourceName)
		{
			if (songRectTransform == null) InitializeCanvas();

			var textComponent = songRectTransform.GetComponent<TextMeshProUGUI>();
			if (textComponent != null)
			{
				textComponent.text = $"Current Song: {clipName}\nSource: {sourceName}";
			}
		}
		#endif


		public static void AudioPlayPatch(AudioSource __instance)
		{
			if (__instance.clip == null)
				return;

			if (LogSounds)
				MelonLogger.Msg($"Playing \"{__instance.clip.name}\" from object \"{__instance.gameObject.name}\"");

			string audioClipName = overrideEnabled ? "REPLACE_ALL" : __instance.clip.name;
			if (AudioClips.TryGetValue(audioClipName, out AudioClip replaceClip))
			{
				__instance.pitch = 1;
				__instance.clip = replaceClip;
			}

			#if AUDIO_TESTING
			// Update the displayed audio source
			var (name, source) = GetAudioSource(__instance.clip.name);
			UpdateAudioSourceText(name, source);
			#endif
		}
	}
}
