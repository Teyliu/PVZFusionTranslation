using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(CrisisZombieWindow))]
    public static class CrisisZombieWindow_Patch
    {
        [HarmonyPatch(nameof(CrisisZombieWindow.Start))]
        [HarmonyPostfix]
        private static void Start(CrisisZombieWindow __instance)
        {
            TranslateIntroduceText(__instance);
        }

        [HarmonyPatch(nameof(CrisisZombieWindow.SetZombieType))]
        [HarmonyPostfix]
        private static void SetZombieType(CrisisZombieWindow __instance)
        {
            TranslateIntroduceText(__instance);
        }

        private static void TranslateIntroduceText(CrisisZombieWindow instance)
        {
            Transform imagesTransform = instance.transform.Find("Images");
            if (imagesTransform == null)
            {
                return;
            }

            Transform introduceTransform = imagesTransform.Find("Introduce");
            if (introduceTransform == null)
            {
                return;
            }

            TextMeshProUGUI introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
            if (introduceText == null)
            {
                return;
            }

            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            introduceText.text = StringStore.TranslateText(introduceText.text);
            introduceText.font = fontAsset;
        }
    }
}
