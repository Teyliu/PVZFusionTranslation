using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(RogueCardWindow))]
    public static class RogueCardWindow_Patch
    {
        [HarmonyPatch(nameof(RogueCardWindow.InitCard))]
        [HarmonyPostfix]
        private static void InitCard(RogueCardWindow __instance)
        {
            Transform introduceTransform = __instance.transform.FindChild("Images").FindChild("Introduce");
            TextMeshProUGUI introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            introduceText.text = StringStore.TranslateText(introduceText.text);
            introduceText.font = fontAsset;
        }

        [HarmonyPatch(nameof(RogueCardWindow.OnAnimOver))]
        [HarmonyPostfix]
        private static void OnAnimOver(RogueCardWindow __instance)
        {
            Transform introduceTransform = __instance.transform.FindChild("Images").FindChild("Introduce");
            TextMeshProUGUI introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            introduceText.text = StringStore.TranslateText(introduceText.text);
            introduceText.font = fontAsset;
        }
    }
}
