using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(UIProgress2))]
	public static class UIProgress2_Patch
	{
		[HarmonyPatch(nameof(UIProgress2.Update))]
		[HarmonyPostfix]
		private static void Update(UIProgress2 __instance)
		{
			__instance.t.text = StringStore.TranslateText(__instance.t.text);
		}
	}
}