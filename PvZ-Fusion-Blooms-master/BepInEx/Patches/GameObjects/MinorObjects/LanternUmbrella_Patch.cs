using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects
{
	[HarmonyPatch(typeof(LanternUmbrella))]
	public class LanternUmbrella_Patch
	{
		[HarmonyPostfix]
		[HarmonyPatch(nameof(LanternUmbrella.Update))]
		private static void Update(LanternUmbrella __instance)
		{
			__instance.energyText = StringStore.TranslateText(__instance.energyText);
			__instance.energyTextShadow = StringStore.TranslateText(__instance.energyTextShadow);
		}
	}
}
