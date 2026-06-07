using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
    [HarmonyPatch(typeof(SaveMenu))]
    public static class SaveMenu_Patch
    {
        [HarmonyPatch(nameof(SaveMenu.Start))]
        [HarmonyPostfix]
        private static void Start(SaveMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            if (__instance.menuTitle != null)
            {
                __instance.menuTitle.text = StringStore.TranslateText(__instance.menuTitle.text);
                __instance.menuTitle.font = fontAsset;
            }
        }
    }
}
