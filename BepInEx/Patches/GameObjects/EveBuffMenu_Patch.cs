using System.Text.RegularExpressions;
using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(EveBuffMenu))]
    public static class EveBuffMenu_Patch
    {
        [HarmonyPatch(nameof(EveBuffMenu.Start))]
        [HarmonyPostfix]
        private static void Start(EveBuffMenu __instance)
        {
            foreach (EveOptionWindow window in __instance.windows)
            {
                EveOptionWindow_Patch.TranslateEveOptionWindow(window);
            }

            foreach (TextMeshProUGUI text in __instance.quitButton.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText("合上");
            }
        }

        [HarmonyPatch(nameof(EveBuffMenu.InitWindows))]
        [HarmonyPostfix]
        private static void InitWindows(EveBuffMenu __instance)
        {
            foreach (EveOptionWindow window in __instance.windows)
            {
                EveOptionWindow_Patch.TranslateEveOptionWindow(window);
            }
        }
    }
}