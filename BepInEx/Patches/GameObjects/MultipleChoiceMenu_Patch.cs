using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(MultipleChoiceMenu))]
    public static class MultipleChoiceMenu_Patch
    {
        [HarmonyPatch(nameof(MultipleChoiceMenu.Awake))]
        [HarmonyPatch(nameof(MultipleChoiceMenu.UpdateWindow))]
        [HarmonyPatch(nameof(MultipleChoiceMenu.Refresh))]
        [HarmonyPatch(nameof(MultipleChoiceMenu.Cancel))]
        [HarmonyPostfix]
        public static void Awake(MultipleChoiceMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
            foreach (BaseWindow window in __instance.windows)
            {
                foreach (TextMeshProUGUI txt in window.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    txt.font = fontAsset;
                    txt.text = StringStore.translationString.ContainsKey(txt.text + "_MC") ? StringStore.TranslateText(txt.text + "_MC") : StringStore.TranslateText(txt.text);
                }
            }
        }
    }
}