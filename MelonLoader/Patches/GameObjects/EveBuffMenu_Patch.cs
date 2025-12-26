using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator.Patches.GameObjects
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
            foreach(EveOptionWindow window in __instance.windows)
            {
                EveOptionWindow_Patch.TranslateEveOptionWindow(window);
            }
        }
    }
}
