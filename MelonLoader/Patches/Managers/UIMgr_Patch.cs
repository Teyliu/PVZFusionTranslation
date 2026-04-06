using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Managers
{
	[HarmonyPatch(typeof(UIMgr))]
	public class UIMgr_Patch
	{
		[HarmonyPatch(nameof(UIMgr.EnterLoseMenu))]
		[HarmonyPostfix]
		private static void EnterLoseMenu(UIMgr __instance)
		{
			LoseMenu loseMenu = GameObject.FindObjectOfType<LoseMenu>();
			loseMenu.title.text = StringStore.TranslateText(loseMenu.title.text);
		}
	}
}