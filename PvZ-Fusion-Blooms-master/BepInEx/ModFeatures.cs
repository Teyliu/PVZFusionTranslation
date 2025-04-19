#if DEBUG
using System;
using System.Collections.Generic;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_
{
	public static class ModFeatures
	{
		public enum ModType
		{
			ReloadStrings,
			ReloadTextures,
		}

		private class ModFeature
		{
			public string Name { get; private set; }
			public ModType ModType { get; private set; }
			public KeyCode KeyCode { get; private set; }
			public bool IsActive { get; set; }

			public ModFeature(string name, ModType modType, KeyCode keyCode, bool defaultValue = false)
			{
				Name = name;
				ModType = modType;
				KeyCode = keyCode;
				IsActive = defaultValue;
			}

			public void ToggleFeature()
			{
				if (ModType == ModType.ReloadStrings)
				{
					StringStore.Reload();
					Core.ShowToast("Strings Reloaded!");
					return;
				}

				if (ModType == ModType.ReloadTextures)
				{
					TextureStore.Reload();
					Core.ShowToast("Textures Reloaded!");
					return;
				}
			}
		}

		private static readonly Dictionary<ModType, ModFeature> featureLists = new()
		{
			{ ModType.ReloadStrings, new ModFeature("Reload Strings", ModType.ReloadStrings, KeyCode.Home, true) },
			{ ModType.ReloadTextures, new ModFeature("Reload Textures", ModType.ReloadTextures, KeyCode.End, true) },
		};

		public static void ToggleFeature(ModType modType)
		{
			if (!featureLists.ContainsKey(modType))
				return;

			featureLists[modType].ToggleFeature();
		}

		public static void OnLateUpdate()
		{
			foreach (var feature in featureLists.Values)
			{
				if (feature.KeyCode != KeyCode.None && Enum.IsDefined(typeof(KeyCode), feature.KeyCode))
				{
					if (Input.GetKeyDown(feature.KeyCode))
					{
						feature.ToggleFeature();
					}
				}
			}
		}
	}
}
#endif