using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(TravelLookMenu))]
    public static class TravelLookMenu_Patch
    {
        public static string savedAssetString = "";

        [HarmonyPatch(nameof(TravelLookMenu.Start))]
        [HarmonyPostfix]
        private static void Postfix_Start(TravelLookMenu __instance)
        {
            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }

            Transform quitButtonTransform = __instance.transform.Find("Quit");
            foreach (TextMeshProUGUI txt in quitButtonTransform.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText("合上");
                txt.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }

            __instance.treasureText.text = StringStore.TranslateText(__instance.treasureText.text);
            savedAssetString = __instance.treasureText.text;
        }

        [HarmonyPatch(nameof(TravelLookMenu.Update))]
        [HarmonyPostfix]
        private static void Update(TravelLookMenu __instance)
        {
            if (savedAssetString != __instance.treasureText.text)
            {
                __instance.treasureText.text = StringStore.TranslateText(__instance.treasureText.text);
                savedAssetString = __instance.treasureText.text;
            }
        }
    }
}