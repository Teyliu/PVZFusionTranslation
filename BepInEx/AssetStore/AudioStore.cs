using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using UnityEngine;
using AudioImportLib.BepInEx;
using BepInEx.Logging;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Reflection;
using System.IO;
using BepInEx;
using BepInEx.Configuration;

namespace PvZ_Fusion_Translator__BepInEx_
{
    internal class AudioStore
    {
        public static Dictionary<string, AudioClip> AudioClips = [];
        public static Dictionary<string, (string, string)> AudioClipNames = [];
        public static ManualLogSource Log = Core.Log;

        public static ConfigEntry<bool> LogSounds;
        public static ConfigEntry<string> category;

        private static bool overrideEnabled;
        public static string customAudioPath = Path.Combine(Paths.PluginPath, "PvZ_Fusion_Translator", "[Custom Audios]");
        private static readonly string[] allowedExts = [".wav", ".mp3", ".ogg"];

#if AUDIO_TESTING
		public Canvas Canvas { get; set; }
		public RectTransform songRectTransform { get; private set; }
#endif

        public static void Init()
        {
            LoadAudios();
        }
        public static void LoadAudios()
        {
            try
            {
                if (!Directory.Exists(customAudioPath))
                    Directory.CreateDirectory(customAudioPath);

                string[] audioFiles = Directory.GetFiles(customAudioPath, "*", SearchOption.AllDirectories);
                var ovrClip = audioFiles.SingleOrDefault(f => Path.GetFileNameWithoutExtension(f) == "REPLACE_ALL");
                if (ovrClip == null)
                {
                    foreach (string file in audioFiles)
                    {
                        if (!allowedExts.Contains(Path.GetExtension(file)))
                            continue;

                        AudioClip clip = AudioImportLib.BepInEx.API.LoadAudioClip(file);
                        AudioClips.Add(clip.name, clip);
                        Log.LogInfo("Added Override: " + clip.name);
                    }
                }
                else
                {
                    AudioClip clip = AudioImportLib.BepInEx.API.LoadAudioClip(ovrClip);
                    AudioClips.Add(clip.name, clip);
                    overrideEnabled = true;
                    Log.LogInfo("Added Override: " + clip.name);
                }
            }
            catch (Exception ex)
            {
                Log.LogError($"Error loading audio clips: {ex.Message}");
            }
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

        [HarmonyPatch(typeof(UnityEngine.AudioSource), "Play", [])]
        public class AudioSource_Patch
        {
            public static void Prefix(UnityEngine.AudioSource __instance)
            {
                if(Utils.customAudio)
				{
					if (__instance.clip == null)
                    return;

					string audioClipName = __instance.clip.name;

					if (AudioStore.AudioClips.TryGetValue(audioClipName, out AudioClip replaceClip))
					{
						__instance.pitch = 1;
						__instance.clip = replaceClip;
					}
				}
            }
        }
    }
}