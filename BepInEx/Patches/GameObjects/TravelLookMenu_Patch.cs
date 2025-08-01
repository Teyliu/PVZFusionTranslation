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
        [HarmonyPatch(nameof(TravelLookMenu.Start))]
        [HarmonyPostfix]
        private static void Postfix_Start(TravelLookMenu __instance)
        {
            Transform quitButtonTransform = __instance.transform.Find("Quit");
            if (quitButtonTransform != null)
            {
                TextMeshProUGUI[] allTexts = quitButtonTransform.GetComponentsInChildren<TextMeshProUGUI>(true);

                foreach (var textComp in allTexts)
                {
                    if (textComp != null && textComp.text == StringStore.TranslateText("关闭"))
                    {
                        textComp.text = StringStore.TranslateText("关闭_close");

                        TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
                        textComp.font = fontAsset;
                    }
                }
            }
        }
    }
}