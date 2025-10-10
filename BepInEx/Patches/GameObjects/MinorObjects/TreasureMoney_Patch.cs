using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects
{
	[HarmonyPatch(typeof(TreasureMoney))]
	public static class TreasureMoney_Patch
    {
		[HarmonyPostfix]
		[HarmonyPatch(nameof(TreasureMoney.Update))]
		private static void Update(TreasureMoney __instance)
		{
			__instance.text = StringStore.TranslateText(__instance.text);
		}
	}
}
