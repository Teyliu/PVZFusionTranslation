﻿using Il2CppTMPro;
using MelonLoader;
using PvZ_Fusion_Translator.AssetStore;
using System.Diagnostics;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.UI;

namespace PvZ_Fusion_Translator
{
	public class Utils
	{
		internal static bool TryReplaceTexture2D(Texture2D ogTexture)
		{
			if (ogTexture != null)
			{
				if (TextureStore.textureDict.TryGetValue(ogTexture.name, out string texturePath))
				{
					try
					{
						ImageConversion.LoadImage(ogTexture, File.ReadAllBytes(texturePath));

						Log.LogDebug("OK! Replaced Texture " + ogTexture.name);

						ogTexture.name = "replaced_" + ogTexture.name;
						return true;
					}
					catch (Exception ex)
					{
						Log.LogError("Failed to replace texture: " + ogTexture.name + " at path: " + texturePath);
						Log.LogError(ex.ToString());
					}
				}
			}
			return false;
		}

		internal static Texture2D LoadImage(string path)
		{
			if (!File.Exists(path))
			{
				throw new FileNotFoundException($"The image file at path '{path}' does not exist.");
			}

			byte[] array = File.ReadAllBytes(path);
			Texture2D texture2D = new(2, 2, GraphicsFormat.R8G8B8A8_UNorm, TextureCreationFlags.None, 1, IntPtr.Zero, null);
			ImageConversion.LoadImage(texture2D, array);
			return texture2D;
		}

		public static Color HexToColor(string hex)
		{

			hex = hex.Replace("#", "");

			float r = int.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber) / 255f;
			float g = int.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber) / 255f;
			float b = int.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber) / 255f;

			return new Color(r, g, b);
		}

		public static void OpenSaveDirectory()
		{
			string saveDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "AppData", "LocalLow", "LanPiaoPiao", "PlantsVsZombiesRH");
			Process.Start("explorer.exe", saveDirectory);
		}

		public static void OpenTrello()
		{
			string website = "https://trello.com/b/DcdT1kUp";
			Process.Start(new ProcessStartInfo(website) { UseShellExecute = true });
		}

		public static string RemoveColorTags(string text)
		{
			return Regex.Replace(text, @"<color=[^>]+>", "");
		}

        public static GameObject ConvertToTextMeshProUGUI(GameObject originalText, Transform parent, string name)
        {
            GameObject newObj = new GameObject(name);
            newObj.transform.position = originalText.transform.position;
            newObj.AddComponent<CanvasRenderer>();
            newObj.AddComponent<RectTransform>();
            newObj.AddComponent<TextMeshProUGUI>();
            newObj.transform.SetParent(parent);
            newObj.transform.localScale = Vector3.one;

            UnityEngine.Object.Destroy(originalText);
            return newObj;
        }

        public static void ConvertButtonText(Transform original, string name)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            Transform transform = original.FindChild(name);
            Transform textTransform = transform.FindChild("text");
            string text = textTransform.GetComponent<Text>().text;
            Color color = textTransform.GetComponent<Text>().color;

            TextMeshProUGUI newGoBackText = Utils.ConvertToTextMeshProUGUI(textTransform.gameObject, transform, "text2").GetComponent<TextMeshProUGUI>();
            newGoBackText.autoSizeTextContainer = true;
            newGoBackText.text = StringStore.TranslateText(text, false);
            newGoBackText.font = fontAsset;
            newGoBackText.color = color;
        }

#if MULTI_LANGUAGE
        internal static void ChangeLanguage(string language)
		{
			OldLanguage = Language;

			if (Enum.TryParse(language, out Utils.LanguageEnum lang))
			{
				Utils.Language = lang;
			}
			else
			{
				// Handle invalid language string
				Log.LogError($"Invalid language string: {language}");
			}
			
			WarningStore.isWarningMessageLoaded = false;
			FontStore.Reload();
			StringStore.Reload();
			TextureStore.Reload();
			FileLoader.SaveLanguage();
		}
		#endif

		#if MULTI_LANGUAGE
		public static Utils.LanguageEnum OldLanguage;
		#endif

		public static Utils.LanguageEnum Language;

		public static bool customTextures = !MelonPreferences.GetEntryValue<bool>("PvZ_Fusion_Translator", "DefaultTextures");
		public static bool customAudio = !MelonPreferences.GetEntryValue<bool>("PvZ_Fusion_Translator", "DefaultAudio");

        public enum LanguageEnum
		{
			// first column
			English,
			French,
			Italian,
			German,
			Spanish,
			Portuguese,

			// second column
			Javanese, //Filipino,
			Vietnamese,
			Indonesian,
			Russian,
			Japanese,
			Korean,

			// third column
			// Ukrainian,
			// Slovak,
			Polish,
			Hungarian,
			Arabic,

			LANG_END
		}

		public enum ToggleEnum
		{
			Textures,
			Audio,
			TOGGLE_END
		}
	}
}