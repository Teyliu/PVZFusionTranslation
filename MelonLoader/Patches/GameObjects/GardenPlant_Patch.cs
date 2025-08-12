using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(GardenPlant))]
    public static class GardenPlant_Patch
    {
        [HarmonyPatch(nameof(GardenPlant.Start))]
        [HarmonyPostfix]
        private static void Start(GardenPlant __instance)
        {
            __instance.infoText.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            __instance.infoText.text = StringStore.TranslateText(__instance.infoText.text);
        }

        [HarmonyPatch(nameof(GardenPlant.UpdateInfo))]
        [HarmonyPostfix]
        private static void UpdateInfo(GardenPlant __instance)
        {
            
            __instance.infoText.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            __instance.infoText.text = StringStore.TranslateText(__instance.infoText.text);
        }
    }
}