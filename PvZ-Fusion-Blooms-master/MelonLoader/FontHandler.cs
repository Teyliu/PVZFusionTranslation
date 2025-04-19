using Il2CppTMPro;
using MelonLoader.Utils;
using UnityEngine;

namespace PvZ_Fusion_Translator
{
	public static class FontHandler
	{
		public static Font LoadFont(this string pathFromModsFolder, bool throwException)
		{
			string fontFilePath = Path.Combine(MelonEnvironment.ModsDirectory, pathFromModsFolder);
			if (!File.Exists(fontFilePath))
			{
				if (throwException)
					Log.LogWarning($"Font not found at path: '{fontFilePath}'.");
				return null;
			}
			Font font = new();
			Font.Internal_CreateFontFromPath(font, fontFilePath);
			return font;
		}

		public static TMP_FontAsset ConvertToTMP(this Font font)
		{
			TMP_FontAsset fontAsset = TMP_FontAsset.CreateFontAsset(font);
			if (fontAsset == null)
			{
				Log.LogWarning($"Failed to create TMP_FontAsset from font '{font.name}'.");
				return null;
			}
			return fontAsset;
		}

		public static TMP_FontAsset LoadTMPFont(this string pathFromModsFolder, bool throwException)
		{
			Font font = pathFromModsFolder.LoadFont(throwException);
			if (!font)
				return null;
			TMP_FontAsset fontAsset = font.ConvertToTMP();
			return fontAsset;
		}
	}
}