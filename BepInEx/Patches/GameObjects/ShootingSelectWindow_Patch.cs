using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(ShootingSelectWindow))]
    public static class ShootingSelectWindow_Patch
    {
        [HarmonyPatch(nameof(ShootingSelectWindow.InitPlantType))]
        [HarmonyPostfix]
        private static void InitCard(ShootingSelectWindow __instance)
        {
            Transform introduceTransform = __instance.transform.FindChild("Images").FindChild("Introduce");
            TextMeshProUGUI introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            introduceText.text = StringStore.TranslateText(introduceText.text);
            introduceText.font = fontAsset;
        }

        [HarmonyPatch(nameof(ShootingSelectWindow.OnAnimOver))]
        [HarmonyPostfix]
        private static void OnAnimOver(ShootingSelectWindow __instance)
        {
            Transform introduceTransform = __instance.transform.FindChild("Images").FindChild("Introduce");
            TextMeshProUGUI introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            introduceText.text = StringStore.TranslateText(introduceText.text);
            introduceText.font = fontAsset;
        }

        [HarmonyPatch(nameof(ShootingSelectWindow.SetUpgradePlantTypes))]
        [HarmonyPostfix]
        private static void SetUpgradePlantTypes(ShootingSelectWindow __instance)
        {
            Transform introduceTransform = __instance.transform.FindChild("Images").FindChild("Introduce");
            TextMeshProUGUI introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            introduceText.text = StringStore.TranslateText(introduceText.text);
            introduceText.font = fontAsset;
        }

        [HarmonyPatch(nameof(ShootingSelectWindow.GetMaxIndexInRoutes))]
        [HarmonyPostfix]
        private static void GetMaxIndexInRoutes(ShootingSelectWindow __instance)
        {
            Transform introduceTransform = __instance.transform.FindChild("Images").FindChild("Introduce");
            TextMeshProUGUI introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            introduceText.text = StringStore.TranslateText(introduceText.text);
            introduceText.font = fontAsset;
        }

        [HarmonyPatch(nameof(ShootingSelectWindow.Start))]
        [HarmonyPostfix]
        private static void Start(ShootingSelectWindow __instance)
        {
            Transform introduceTransform = __instance.transform.FindChild("Images").FindChild("Introduce");
            TextMeshProUGUI introduceText = introduceTransform.GetComponent<TextMeshProUGUI>();
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            introduceText.text = StringStore.TranslateText(introduceText.text);
            introduceText.font = fontAsset;
        }
    }
}
