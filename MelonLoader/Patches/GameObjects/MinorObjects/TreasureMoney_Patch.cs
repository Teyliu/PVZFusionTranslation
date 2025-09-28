using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects
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