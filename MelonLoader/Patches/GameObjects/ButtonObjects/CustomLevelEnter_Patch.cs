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
		private static void Start(CustomLevelEnter __instance)
		{
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

			foreach(TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
			{
				string originalKey = StringStore.translationString.FirstOrDefault(x => x.Value == txt.text).Key;
				txt.text = (StringStore.translationString.ContainsKey(originalKey + "_IZ")) ? StringStore.TranslateText(originalKey + "_IZ") : StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
		}
	}
}
