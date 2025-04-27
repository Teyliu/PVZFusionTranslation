using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects
{
	[HarmonyPatch(typeof(UIButton))]
	public static class UIButton_Patch
    {
		[HarmonyPatch(nameof(UIButton.Start))]
		[HarmonyPostfix]
		private static void Start(UIButton __instance)
		{
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
            Transform txtTransform = __instance.transform.FindChild("text");
			StringStore.TranslateTextTransform(txtTransform);
        }
	}
}
