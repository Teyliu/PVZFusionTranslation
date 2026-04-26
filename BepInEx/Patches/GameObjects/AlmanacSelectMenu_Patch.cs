using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using AlmanacData;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(AlmanacSelectMenu))]
    public static class AlmanacSelectMenu_Patch
    {
        [HarmonyPatch(nameof(AlmanacSelectMenu.InitMenu))]
        [HarmonyPostfix]
        private static void InitMenu(AlmanacSelectMenu __instance)
        {
            if (__instance.mainTitle != null)
            {
                __instance.mainTitle.text = StringStore.TranslateText(__instance.mainTitle.text);
                __instance.mainTitle.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
            if (__instance.mainText != null)
            {
                __instance.mainText.text = StringStore.TranslateText(__instance.mainText.text);
                __instance.mainText.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
        }
    }
}