using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System.IO;

namespace PvZ_Fusion_Translator__BepInEx_.AssetStore
{
	public static class TextureStore
	{
		internal static Dictionary<string, string> textureDict = [];

		internal static Dictionary<string, string> spriteDict = [];

		internal static void Init() => FileLoader.LoadTextures();

		internal static void Reload()
		{
			textureDict.Clear();
			#if MULTI_LANGUAGE
			RestoreTextures();
			#endif
			if(!Utils.customTextures)
			{
				FileLoader.LoadDefaultTextures();
			}
			FileLoader.LoadTextures();
		}

		public static IEnumerator ReplaceTexturesCoroutine()
		{
            if (!Utils.customTextures)
            {
                FileLoader.LoadDefaultTextures();
            }

			// Run texture replacement 3 times at startup, then stop
			for (int i = 0; i < 3; i++)
			{
				ReplaceTextures();
				yield return new WaitForSeconds(1f);  // Wait 1 second between checks
			}

			Log.LogInfo("Texture replacement completed. Stopping periodic checks to save memory.");
		}

		public static void ReplaceTextures()
		{
			Texture2D[] textures = Resources.FindObjectsOfTypeAll<Texture2D>();
			foreach (Texture2D texture in textures)
			{
				if (texture.name.StartsWith("replaced_"))
					continue;

				Utils.TryReplaceTexture2D(texture);
			}
		}

		#if MULTI_LANGUAGE
		public static void RestoreTextures()
		{
			Texture2D[] textures = Resources.FindObjectsOfTypeAll<Texture2D>();
			foreach (Texture2D texture in textures)
			{
				if (texture != null)
				{
					texture.name = texture.name.Replace("replaced_", "");
				}
			}
		}
		#endif

		public static void LogAll()
		{
			Log.LogInfo("Logging all TextureStore entries.");
			foreach (KeyValuePair<string, string> entry in textureDict)
			{
				Log.LogInfo("TextureDict Entry: " + entry.Key + " | " + entry.Value);
			}
		}
	}
}
