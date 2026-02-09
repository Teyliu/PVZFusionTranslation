using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(InGame_openBag))]
    public static class InGame_openBag_Patch
    {
        [HarmonyPatch(typeof(InGame_openBag), "ShowText", new Type[] { typeof(string) })]
        [HarmonyPrefix]
        private static void Prefix_ShowText(ref string text)
        {
            text = StringStore.TranslateText(text);
        }

        [HarmonyPatch(typeof(InGame_openBag), "ShowText", new Type[] { typeof(string), typeof(bool) })]
        [HarmonyPostfix]
        private static void Post_ShowText(InGame_openBag __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>(true))
            {
                text.text = StringStore.TranslateText(text.text);
                text.font = fontAsset;
            }
        }
    }
}
