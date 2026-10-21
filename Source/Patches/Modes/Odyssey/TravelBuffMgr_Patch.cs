#if false
using HarmonyLib;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey;

[HarmonyPatch(typeof(TravelBuffMgr))]
public static class TravelBuffMgr_Patch
{
    [HarmonyPatch(nameof(TravelBuffMgr.Awake)), HarmonyPostfix]
    private static void Awake(TravelBuffMgr __instance)
    {
        __instance.text = AssetStore.StringStore.TranslateText(__instance.text);
        __instance.text2 = AssetStore.StringStore.TranslateText(__instance.text2);
    }

    [HarmonyPatch(nameof(TravelBuffMgr.ShowText), typeof(int), typeof(int)), HarmonyPostfix]
    private static void ShowText(TravelBuffMgr __instance)
    {
        __instance.text = AssetStore.StringStore.TranslateText(__instance.text);
        __instance.text2 = AssetStore.StringStore.TranslateText(__instance.text2);
    }
}
#endif
