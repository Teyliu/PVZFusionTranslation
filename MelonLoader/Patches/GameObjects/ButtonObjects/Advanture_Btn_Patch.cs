using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects
{
	[HarmonyPatch(typeof(Advanture_Btn))]
	public static class Advanture_Btn_Patch
	{
		[HarmonyPatch(nameof(Advanture_Btn.Start))]
		[HarmonyPostfix]
		private static void Start(Advanture_Btn __instance)
		{
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                string originalKey = StringStore.translationString.FirstOrDefault(x => x.Value == txt.text).Key;
                txt.text = (StringStore.translationString.ContainsKey(originalKey + "_MG")) ? StringStore.TranslateText(originalKey + "_MG") : StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }
	}
}
