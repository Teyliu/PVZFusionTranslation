#if FIX
using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects
{
    [HarmonyPatch(typeof(AbyssBuffButton))]
    public static class AbyssBuffButton_Patch
    {
        [HarmonyPatch(nameof(AbyssBuffButton.Start))]
        [HarmonyPostfix]
        private static void Start(AbyssBuffButton __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            __instance.description.text = StringStore.TranslateText(__instance.description.text);
            __instance.description.font = fontAsset;
        }
    }
}
#endif