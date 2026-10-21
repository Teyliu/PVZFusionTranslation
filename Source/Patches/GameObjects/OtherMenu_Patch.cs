using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(OtherMenu))]
public static class OtherMenu_Patch
{
    [HarmonyPatch(nameof(OtherMenu.UpdateText)), HarmonyPostfix]
    private static void UpdateText(OtherMenu __instance)
    {
        __instance.text1 = StringStore.TranslateText(__instance.text1);
        __instance.text2 = StringStore.TranslateText(__instance.text2);
    }
}
