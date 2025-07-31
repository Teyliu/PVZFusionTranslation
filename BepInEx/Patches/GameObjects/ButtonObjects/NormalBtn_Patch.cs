using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.ButtonObjects
{
	[HarmonyPatch(typeof(NormalBtn))]
	public class NormalBtn_Patch
    {
		[HarmonyPostfix]
		[HarmonyPatch(nameof(NormalBtn.OnMouseUpAsButton))]
		public static void OnMouseUpAsButton(NormalBtn __instance)
		{
            Transform banTransform = __instance.transform.GetChild(0);
			if (banTransform != null)
			{
				banTransform.GetComponent<TextMeshPro>().text = StringStore.TranslateText(banTransform.GetComponent<TextMeshPro>().text);
			}
        }
	}
}