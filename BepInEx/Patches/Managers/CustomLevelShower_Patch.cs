#if FIX
using HarmonyLib;

using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
    [HarmonyPatch(typeof(CustomLevelShower))]
    public static class CustomLevelShower_Patch
    {
        [HarmonyPatch(nameof(CustomLevelShower.Show))]
        [HarmonyPostfix]
        private static void Show(CustomLevelShower __instance)
        {
            foreach (Transform transform in __instance.pages)
            {
                StringStore.TranslateTextTransform(transform);
            }
        }
    }
}
#endif