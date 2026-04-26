using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(ActionCard))]
    public static class ActionCard_Patch
    {
        [HarmonyPatch(nameof(ActionCard.ClickedEvent))]
        [HarmonyPostfix]
        private static void ClickedEvent(ActionCard __instance)
        {
            if (__instance.cardText != null)
            {
                __instance.cardText.text = StringStore.TranslateText(__instance.cardText.text);
                __instance.cardText.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
        }
    }
}