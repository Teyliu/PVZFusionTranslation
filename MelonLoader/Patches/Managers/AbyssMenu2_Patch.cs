using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Managers
{
	[HarmonyPatch(typeof(AbyssMenu2))]
	public static class AbyssMenu2_Patch
	{
		[HarmonyPatch(nameof(AbyssMenu2.Start))]
		[HarmonyPostfix]
		private static void Start(AbyssMenu2 __instance)
		{
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

			__instance.buffCountText.text = StringStore.TranslateText(__instance.buffCountText.text);
			__instance.buffCountText.font = fontAsset;

			__instance.money.text = StringStore.TranslateText(__instance.money.text);
			__instance.money.font = fontAsset;

			__instance.refreshText.text = StringStore.TranslateText(__instance.refreshText.text);
			__instance.refreshText.font = fontAsset;

			__instance.statistics.text = StringStore.TranslateText(__instance.statistics.text);
			__instance.statistics.font = fontAsset;

			Transform buffTextTransform = __instance.transform.FindChild("BuffText").transform;
			if (buffTextTransform != null) StringStore.TranslateTextTransform(buffTextTransform);

			Transform moneyTransform = __instance.transform.FindChild("Money").transform;
            if (moneyTransform != null) StringStore.TranslateTextTransform(moneyTransform);

			Transform buffCountTextTransform = __instance.transform.FindChild("BuffCountText").transform;
            if (buffCountTextTransform != null) StringStore.TranslateTextTransform(buffCountTextTransform);

			Transform refreshTextTransform = __instance.transform.FindChild("RefreshText").transform;
            if (refreshTextTransform != null) StringStore.TranslateTextTransform(refreshTextTransform);
		}

		[HarmonyPatch(nameof(AbyssMenu2.Awake))]
		[HarmonyPostfix]
		private static void Awake(AbyssMenu2 __instance)
		{
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

			__instance.buffCountText.text = StringStore.TranslateText(__instance.buffCountText.text);
			__instance.buffCountText.font = fontAsset;

			__instance.money.text = StringStore.TranslateText(__instance.money.text);
			__instance.money.font = fontAsset;

			__instance.refreshText.text = StringStore.TranslateText(__instance.refreshText.text);
			__instance.refreshText.font = fontAsset;

			__instance.statistics.text = StringStore.TranslateText(__instance.statistics.text);
			__instance.statistics.font = fontAsset;

			Transform buffTextTransform = __instance.transform.FindChild("BuffText").transform;
			if (buffTextTransform != null) StringStore.TranslateTextTransform(buffTextTransform);

			Transform moneyTransform = __instance.transform.FindChild("Money").transform;
            if (moneyTransform != null) StringStore.TranslateTextTransform(moneyTransform);

			Transform buffCountTextTransform = __instance.transform.FindChild("BuffCountText").transform;
            if (buffCountTextTransform != null) StringStore.TranslateTextTransform(buffCountTextTransform);

			Transform refreshTextTransform = __instance.transform.FindChild("RefreshText").transform;
            if (refreshTextTransform != null) StringStore.TranslateTextTransform(refreshTextTransform);
		}
	}
}
