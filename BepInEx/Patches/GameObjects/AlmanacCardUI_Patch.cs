using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(AlmanacCardUI))]
    public static class AlmanacCardUI_Patch
    {
        [HarmonyPatch(nameof(AlmanacCardUI.Awake))]
        [HarmonyPostfix]
        private static void Post_Awake(AlmanacCardUI __instance)
        {
            if (__instance != null && __instance.cost != null)
            {
                StringStore.TranslateTextUI(__instance.cost);
            }
        }
    }
}
