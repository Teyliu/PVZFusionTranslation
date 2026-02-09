using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(OptionMenu))]
    public static class OptionMenu_Patch
    {
        [HarmonyPatch(nameof(OptionMenu.Awake))]
        [HarmonyPostfix]
        private static void Post_Awake(OptionMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>(true))
            {
                text.text = StringStore.TranslateText(text.text);
                text.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(OptionMenu.Start))]
        [HarmonyPostfix]
        private static void Post_Start(OptionMenu __instance)
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
