using HarmonyLib;
using System;
using System.Collections.Generic;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using Unity.VisualScripting;
using UnityEngine;
using System.Text.RegularExpressions;
using UnityEngine.UI;
using PvZ_Fusion_Translator__BepInEx_;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(AbyssMenu))]
    public static class AbyssMenu_Patch
    {
        [HarmonyPatch(nameof(AbyssMenu.Awake))]
        [HarmonyPostfix]
        private static void Awake(AbyssMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.levelInfo)
            {
                txt.text = StringStore.TranslateText(txt.text, false);
                txt.font = fontAsset;
            }

            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
                text.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(AbyssMenu.UpdateLevelInfo))]
        [HarmonyPostfix]
        private static void UpdateLevelInfo(AbyssMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.levelInfo)
            {
                txt.text = StringStore.TranslateText(txt.text, pattern: "第(\\d+)关\n场景：([^\\s]+)\n总波数：(\\d+)波\n特殊环境：([^\\s]+)\n难度：(\\d+)");
                txt.font = fontAsset;
            }
        }
    }
}
