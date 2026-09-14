using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.ButtonObjects
{
    [HarmonyPatch(typeof(AdvantureAwardButton))]
    public static class AdvantureAwardButton_Patch
    {
        [HarmonyPatch(nameof(AdvantureAwardButton.UpdateText))]
        [HarmonyPostfix]
        private static void Post_UpdateText(AdvantureAwardButton __instance)
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
