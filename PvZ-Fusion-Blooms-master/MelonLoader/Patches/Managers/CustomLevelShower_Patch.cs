#if FIX
using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Managers
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