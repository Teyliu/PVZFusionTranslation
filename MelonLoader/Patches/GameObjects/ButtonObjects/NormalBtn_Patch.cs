using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects
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