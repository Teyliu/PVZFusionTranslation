﻿using HarmonyLib;

using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.ButtonObjects
{
    [HarmonyPatch(typeof(EveBtn))]
	public static class EveBtn_Patch
	{
		[HarmonyPostfix]
		[HarmonyPatch(nameof(EveBtn.OnMouseUp))]
		private static void OnMouseUp(EveBtn __instance)
		{
			Transform sceneText = __instance.transform.FindChild("text");
			if(sceneText != null)
			{
				TextMeshProUGUI sceneTextTMP = sceneText.transform.GetComponent<TextMeshProUGUI>();
				if(sceneTextTMP != null)
				{
					sceneTextTMP.text = StringStore.TranslateText(sceneTextTMP.text);
				}
			}
			Transform sceneTextShadow = sceneText.transform.FindChild("text2");
			if(sceneTextShadow != null)
			{
				TextMeshProUGUI sceneTextShadowTMP = sceneTextShadow.transform.GetComponent<TextMeshProUGUI>();
				if (sceneTextShadowTMP != null)
				{
					sceneTextShadowTMP.text = StringStore.TranslateText(sceneTextShadowTMP.text);
				}
			}

			if (__instance.name.Equals("Balanced"))
			{
				__instance.gameObject.SetActive(false);
				__instance.gameObject.SetActive(true);
			}
		}
	}
}