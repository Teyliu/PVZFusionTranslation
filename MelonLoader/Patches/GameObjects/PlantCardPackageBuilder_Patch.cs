using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(PlantCardPackageBuilder))]
    public static class PlantCardPackageBuilder_Patch
    {
        [HarmonyPatch(nameof(PlantCardPackageBuilder.UpdateText))]
        [HarmonyPostfix]
        private static void UpdateText(PlantCardPackageBuilder __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            __instance.text.text = StringStore.TranslateText(__instance.text.text);
            __instance.text.font = fontAsset;
        }
    }
}