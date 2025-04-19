using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using TMPro;
using UnityEngine;


namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
	[HarmonyPatch(typeof(EndlessMgr))]
	public static class EndlessMgr_Patch
	{
		[HarmonyPatch(nameof(EndlessMgr.Awake))]
		[HarmonyPostfix]
		private static void Awake(EndlessMgr __instance)
		{
			Transform textTransform = __instance.transform.GetChild(2);
			if (textTransform != null && textTransform.gameObject.activeSelf)
			{
				TextMeshProUGUI textTMP = textTransform.GetComponent<TextMeshProUGUI>();
				if (textTMP != null)
				{
					textTMP = StringStore.TranslateText(textTMP);
				}
			}
		}
	}
}
