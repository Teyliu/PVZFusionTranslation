using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(SelectYourPlants))]
	public static class SelectYourPlants_Patch
	{
		[HarmonyPatch(nameof(SelectYourPlants.Awake))]
		[HarmonyPostfix]
		private static void Awake(SelectYourPlants __instance)
		{
			__instance.TextMeshProUGUI = StringStore.TranslateText(__instance.TextMeshProUGUI);
			__instance.TextMeshProUGUI.autoSizeTextContainer = true;

			__instance.TextMeshProUGUI2 = StringStore.TranslateText(__instance.TextMeshProUGUI2);
			__instance.TextMeshProUGUI2.autoSizeTextContainer = true;
		}
	}
}
