using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(GardenMoney))]
    public static class GardenMoney_Patch
    {
        [HarmonyPatch(nameof(GardenMoney.Update))]
        [HarmonyPostfix]
        private static void Post_Update(GardenMoney __instance)
        {
            if (__instance != null && __instance.textMesh != null)
            {
                StringStore.TranslateTextUI(__instance.textMesh);
            }
        }
    }
}
