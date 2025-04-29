#if FIX
using HarmonyLib;

using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.ButtonObjects
{
    [HarmonyPatch(typeof(SaveMenuBtn))]
    public static class SaveMenuBtn_Patch
    {
        [HarmonyPatch(nameof(SaveMenuBtn.OnMouseUpAsButton))]
        [HarmonyPostfix]
        private static void OnMouseUpAsButton(SaveMenuBtn __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            __instance.theName.text = StringStore.TranslateText(__instance.theName.text);
            __instance.theName.font = fontAsset;
        }
    }
}
#endif