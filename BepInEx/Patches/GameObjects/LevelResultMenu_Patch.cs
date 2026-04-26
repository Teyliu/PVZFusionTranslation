using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(LevelResultMenu))]
    public static class LevelResultMenu_Patch
    {
        [HarmonyPatch(nameof(LevelResultMenu.ShowResult))]
        [HarmonyPostfix]
        private static void ShowResult(LevelResultMenu __instance, BoardStatistics stats)
        {
            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
                text.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
        }
    }
}