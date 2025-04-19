using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using System;
using TMPro;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
	[HarmonyPatch(typeof(OppositeBuffManager))]
	public static class OppositeBuffManager_Patch
	{
		[HarmonyPatch(nameof(OppositeBuffManager.SetText), new Type[] { typeof(TextMeshProUGUI), typeof(BuffType), typeof(int)})]
		[HarmonyPostfix]
		private static void SetText(OppositeBuffManager __instance, ref TextMeshProUGUI text)
		{
			StringStore.TranslateTextUI(text);
		}

		[HarmonyPatch(nameof(OppositeBuffManager.Awake))]
		[HarmonyPostfix]
		private static void Awake(OppositeBuffManager __instance)
		{
			StringStore.TranslateTextUI(__instance.textA_bad[0]);
			StringStore.TranslateTextUI(__instance.textA_bad[1]);
			StringStore.TranslateTextUI(__instance.textB_bad[0]);
			StringStore.TranslateTextUI(__instance.textB_bad[1]);
		}
	}
}
