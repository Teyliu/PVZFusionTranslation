using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects
{
	[HarmonyPatch(typeof(Money))]
	public static class Money_Patch
	{
		[HarmonyPostfix]
		[HarmonyPatch(nameof(Money.Update))]
		private static void Update(Money __instance)
		{
			__instance.beanCount.text = StringStore.TranslateText(__instance.beanCount.text);
			__instance.beanCount2.text = StringStore.TranslateText(__instance.beanCount2.text);
		}
	}
}
