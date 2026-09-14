using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(CustomPlantManager))]
    public static class CustomPlantManager_Patch
    {
        [HarmonyPatch(nameof(CustomPlantManager.Update))]
        [HarmonyPostfix]
        private static void Post_Update(CustomPlantManager __instance)
        {
            if (__instance != null && __instance.abilityText != null)
            {
                StringStore.TranslateTextUI(__instance.abilityText);
            }
        }
    }
}
