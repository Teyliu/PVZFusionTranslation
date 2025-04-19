using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
	[HarmonyPatch(typeof(CustomSettings))]
	public static class CustomSettings_Patch
	{
		[HarmonyPatch(nameof(CustomSettings.Awake))]
		[HarmonyPostfix]
		private static void Awake(CustomSettings __instance)
		{
			__instance.textMesh = StringStore.TranslateText(__instance.textMesh);
		}

		[HarmonyPatch(nameof(CustomSettings.ChangeText))]
		[HarmonyPostfix]
		private static void ChangeText(CustomSettings __instance)
		{
			__instance.textMesh = StringStore.TranslateText(__instance.textMesh);
		}
	}
}
