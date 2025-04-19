using HarmonyLib;
using TMPro;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.ButtonObjects
{
	[HarmonyPatch(typeof(InGameBtn))]
	public static class InGameBtn_Patch
	{
		[HarmonyPatch(nameof(InGameBtn.Update))]
		[HarmonyPostfix]
		private static void Update(InGameBtn __instance)
		{
			Transform sceneText = __instance.transform.FindChild("SceneText");
			if(sceneText != null)
			{
				TextMeshProUGUI sceneTextTMP = sceneText.transform.GetComponent<TextMeshProUGUI>();
				if(sceneTextTMP != null)
				{
					sceneTextTMP = AssetStore.StringStore.TranslateText(sceneTextTMP);
				}
				Transform sceneTextShadow = sceneText.transform.FindChild("SceneText");
				if(sceneTextShadow != null)
				{
					TextMeshProUGUI sceneTextShadowTMP = sceneTextShadow.transform.GetComponent<TextMeshProUGUI>();
					if (sceneTextShadowTMP != null)
					{
						sceneTextShadowTMP = AssetStore.StringStore.TranslateText(sceneTextShadowTMP);
					}
				}
			}
		}
	}
}
