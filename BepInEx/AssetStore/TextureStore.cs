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

		private static HashSet<string> replacedTextures = new HashSet<string>();

		internal static void Init() => FileLoader.LoadTextures();

		internal static void Reload()
		{
			textureDict.Clear();
			spriteDict.Clear();
			replacedTextures.Clear();
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
			RestoreTextures();
#endif

			if (!Utils.customTextures)
			{
				FileLoader.LoadDefaultTextures();
			}

			FileLoader.LoadTextures();
			ReplaceTextures();

			yield return new WaitForSeconds(2f);

			ReplaceTextures();

			Log.LogInfo("Texture replacement completed.");
		}

		public static void ReplaceTextures()
		{
			Texture2D[] textures = Resources.FindObjectsOfTypeAll<Texture2D>();
			foreach (Texture2D texture in textures)
			{
				if (texture == null)
					continue;

				if (replacedTextures.Contains(texture.name))
					continue;

				if (texture.name.StartsWith("replaced_"))
				{
					replacedTextures.Add(texture.name.Replace("replaced_", ""));
					continue;
				}

				if (Utils.TryReplaceTexture2D(texture))
				{
					replacedTextures.Add(texture.name);
				}
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
