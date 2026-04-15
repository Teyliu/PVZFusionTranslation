using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System.IO;

namespace PvZ_Fusion_Translator__BepInEx_
{
	public static class TextureStore
	{
		internal static Dictionary<string, byte[]> textureDict = new Dictionary<string, byte[]>();

		internal static Dictionary<string, byte[]> spriteDict = new Dictionary<string, byte[]>();

		internal static void Init() => FileLoader.LoadTextures();

		internal static void Reload()
		{
			textureDict.Clear();
			spriteDict.Clear();
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
			yield return null;

#if MULTI_LANGUAGE
			// Restore all textures first (remove "replaced_" prefix)
			RestoreTextures();
#endif

			// Load default textures first if needed
            if (!Utils.customTextures)
            {
                FileLoader.LoadDefaultTextures();
            }

			// Load all language textures
            FileLoader.LoadTextures();

			// Replace existing textures
			ReplaceTextures();

			Log.LogInfo("Texture replacement completed.");
		}

		public static void ReplaceTextures()
		{
			Texture2D[] textures = Resources.FindObjectsOfTypeAll<Texture2D>();
			foreach (Texture2D texture in textures)
			{
				// Skip already replaced textures
				if (texture.name.StartsWith("replaced_"))
					continue;

				Utils.TryReplaceTexture2D(texture);
			}

			Utils.RebuildAllSpriteRenderers();
		}

#if MULTI_LANGUAGE
		public static void RestoreTextures()
		{
			Texture2D[] textures = Resources.FindObjectsOfTypeAll<Texture2D>();
			foreach (Texture2D texture in textures)
			{
				if (texture != null && texture.name.StartsWith("replaced_"))
				{
					texture.name = texture.name.Replace("replaced_", "");
				}
			}
		}
#endif

		public static void LogAll()
		{
			Log.LogInfo("Logging all TextureStore entries.");
			foreach (var entry in textureDict)
			{
				Log.LogInfo("TextureDict Entry: " + entry.Key);
			}
		}
	}
}
