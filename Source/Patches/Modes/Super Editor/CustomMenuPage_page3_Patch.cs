using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor;

[HarmonyPatch(typeof(CustomMenu_page3))]
public static class CustomMenuPagePage3Patch
{
    [HarmonyPatch(nameof(CustomMenu_page3.UpdateCardsText)), HarmonyPostfix]
    public static void UpdateCardsText(CustomMenu_page3 __instance)
    {
        var plantName = Utils.GetPlantNameFromAlmanac(__instance.nameText.text);
        __instance.nameText.text = plantName != "" ? plantName : StringStore.TranslateText(__instance.nameText.text);
    }

    [HarmonyPatch(nameof(CustomMenu_page3.UpdateAdvancedInfo)), HarmonyPostfix]
    public static void UpdateAdvancedInfo(CustomMenu_page3 __instance)
    {
        var plantName = Utils.GetPlantNameFromAlmanac(__instance.nameText.text);
        __instance.nameText.text = plantName != "" ? plantName : StringStore.TranslateText(__instance.nameText.text);
    }
}
