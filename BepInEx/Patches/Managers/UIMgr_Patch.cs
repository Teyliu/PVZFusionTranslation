using HarmonyLib;
using System;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
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