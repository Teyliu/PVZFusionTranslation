using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using MelonLoader;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects
{
	[HarmonyPatch(typeof(CustomLevelEnter))]
	public static class CustomLevelEnter_Patch
    {
		[HarmonyPatch(nameof(CustomLevelEnter.Start))]
		[HarmonyPostfix]
		private static void Show(CustomLevelEnter __instance)
		{
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach(TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
			{
				txt.text = StringStore.TranslateText(txt.text);
				txt.font = fontAsset;
            }
		}
	}
}
