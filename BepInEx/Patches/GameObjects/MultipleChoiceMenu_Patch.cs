using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using System.Collections.Generic;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(MultipleChoiceMenu))]
    public static class MultipleChoiceMenu_Patch
    {
        [HarmonyPatch(nameof(MultipleChoiceMenu.RegisterOption))]
        [HarmonyPrefix]
        private static void RegisterOption_Pre(ref string title, ref string text)
        {
            title = StringStore.TranslateText(title);
            text = StringStore.TranslateText(text);
        }

        [HarmonyPatch(nameof(MultipleChoiceMenu.Refresh))]
        [HarmonyPostfix]
        private static void Refresh(MultipleChoiceMenu __instance)
        {
            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
                text.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
        }
    }
}