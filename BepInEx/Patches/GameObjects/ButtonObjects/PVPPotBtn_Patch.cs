using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.ButtonObjects
{
	[HarmonyPatch(typeof(PVPPotBtn))]
	public class PVPPotBtn_Patch
	{
		[HarmonyPostfix]
		[HarmonyPatch(nameof(PVPPotBtn.OnMouseUpAsButton))]
		public static void OnMouseUpAsButton(PVPPotBtn __instance)
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
			Transform sceneTextShadow = sceneText.transform.FindChild("text_1");
			if(sceneTextShadow != null)
			{
				TextMeshProUGUI sceneTextShadowTMP = sceneTextShadow.transform.GetComponent<TextMeshProUGUI>();
				if (sceneTextShadowTMP != null)
				{
					sceneTextShadowTMP.text = StringStore.TranslateText(sceneTextShadowTMP.text);
				}
			}

			if (__instance.name.Equals("ChangeBg_3") || __instance.name.Equals("ChangeBg_4"))
			{
				__instance.gameObject.SetActive(false);
				__instance.gameObject.SetActive(true);
			}
		}
	}
}
