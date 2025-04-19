using PvZ_Fusion_Translator.AssetStore;
using System.Diagnostics;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

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

			LANG_END
		}
	}
}