using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(AdvantureLevelText))]
    public static class AdvantureLevelText_Patch
    {
        [HarmonyPatch(nameof(AdvantureLevelText.Start))]
        [HarmonyPostfix]
        private static void Post_Start(AdvantureLevelText __instance)
        {
            if (__instance != null)
            {
                var tmp = __instance.GetComponent<TextMeshProUGUI>();
                if (tmp != null)
                {
                    StringStore.TranslateTextUI(tmp);
                }
            }
        }
    }
}
