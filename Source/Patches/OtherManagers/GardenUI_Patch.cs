using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.OtherManagers;

[HarmonyPatch(typeof(GardenUI))]
public static class GardenUI_Patch
{
    [HarmonyPatch(nameof(GardenUI.Update)), HarmonyPostfix]
    public static void Update(GardenUI __instance) =>
        __instance.currentPageText = StringStore.TranslateText(__instance.currentPageText);
}
