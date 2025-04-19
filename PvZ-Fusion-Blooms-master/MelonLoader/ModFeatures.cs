#if DEBUG
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator
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

			public ModFeature(string Name, ModType ModType, KeyCode KeyCode, bool defaultValue = false)
			{
				this.Name = Name;
				this.ModType = ModType;
				this.KeyCode = KeyCode;
				this.IsActive = defaultValue;
			}

			public void ToggleFeature()
			{
				if (this.ModType == ModType.ReloadStrings)
				{
					StringStore.Reload();
					Core.ShowToast("Strings Reloaded!");
					return;
				}

				if (this.ModType == ModType.ReloadTextures)
				{
					TextureStore.Reload();
					Core.ShowToast("Textures Reloaded!");
					return;
				}
			}
		}

		private static Dictionary<ModType, ModFeature> featureLists = new()
		{
			{ModType.ReloadStrings,new ModFeature("Reload Strings",ModType.ReloadStrings,KeyCode.Home, true)},
			{ModType.ReloadTextures,new ModFeature("Reload Textures",ModType.ReloadTextures,KeyCode.End, true)},
		};


		public static void ToggleFeature(ModType ModType)
		{
			if (!featureLists.ContainsKey(ModType))
				return;

			featureLists[ModType].ToggleFeature();
		}

		public static void OnLateUpdate()
		{
			foreach (var (type, feature) in featureLists)
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