using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(NumberPopManager))]
    public static class NumberPopManager_Patch
    {
        [HarmonyPatch(nameof(NumberPopManager.SetPopUp))]
        [HarmonyPrefix]
        private static void Pre_SetPopUp(ref string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                text = StringStore.TranslateText(text);
            }
        }
    }
}
