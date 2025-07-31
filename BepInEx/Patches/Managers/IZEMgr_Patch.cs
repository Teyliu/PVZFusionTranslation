using HarmonyLib;

using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
    [HarmonyPatch(typeof(IZBottomMenu))]
	public static class IZEMgr_Patch
	{
		[HarmonyPatch(nameof(IZBottomMenu.ChangeString))]
		[HarmonyPostfix]
		public static void Start(IZBottomMenu __instance)
		{
			TextMeshProUGUI[] array =
            [
                    __instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>(),
					__instance.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>(),
			];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = StringStore.TranslateText(array[i]);
				array[i].text = array[i].text.Replace("\n", " ");
			}
		}
	}
}