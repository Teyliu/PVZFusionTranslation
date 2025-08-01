using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(FruitNinjaSelectWindow))]
    public static class FruitNinjaSelectWindow_Patch
    {
        [HarmonyPatch(nameof(FruitNinjaSelectWindow.SetType))]
        [HarmonyPostfix]
        private static void SetType(FruitNinjaSelectWindow __instance)
        {
            Transform introduceTransform = __instance.transform.FindChild("Images").FindChild("Introduce");
            TextMeshProUGUI introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            introduceText.text = StringStore.TranslateText(introduceText.text);
            introduceText.font = fontAsset;
        }

        [HarmonyPatch(nameof(FruitNinjaSelectWindow.OnAnimOver))]
        [HarmonyPostfix]
        private static void OnAnimOver(FruitNinjaSelectWindow __instance)
        {
            Transform introduceTransform = __instance.transform.FindChild("Images").FindChild("Introduce");
            TextMeshProUGUI introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            introduceText.text = StringStore.TranslateText(introduceText.text);
            introduceText.font = fontAsset;
        }
    }
}
