using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Managers
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
