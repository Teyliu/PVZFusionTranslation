using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(BaseWindow))]
    public static class BaseWindow_Patch
    {
        [HarmonyPatch(nameof(BaseWindow.SetDescription))]
        [HarmonyPrefix]
        private static void Pre_SetDescription(ref string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                text = StringStore.TranslateText(text);
            }
        }

        [HarmonyPatch(nameof(BaseWindow.Awake))]
        [HarmonyPostfix]
        private static void Post_Awake(BaseWindow __instance)
        {
            if (__instance != null)
            {
                if (__instance.title != null)
                    StringStore.TranslateTextUI(__instance.title);
                if (__instance.introduce != null)
                    StringStore.TranslateTextUI(__instance.introduce);
            }
        }
    }
}
