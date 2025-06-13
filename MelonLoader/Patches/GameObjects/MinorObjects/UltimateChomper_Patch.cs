using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(UltimateChomper), nameof(UltimateChomper.UpdateText))]
    public static class UltimateChomper_Patch
    {
        [HarmonyPostfix]
        public static void UpdateText(UltimateChomper __instance)
        {
            StringStore.TranslateText(__instance.killingText);
            StringStore.TranslateText(__instance.killingTextShadow);
        }
    }
}