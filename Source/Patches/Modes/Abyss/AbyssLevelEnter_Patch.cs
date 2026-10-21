#if false
using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Abyss;

[HarmonyPatch(typeof(AbyssLevelEnter))]
public static class AbyssLevelEnter_Patch
{
    [HarmonyPatch(nameof(AbyssLevelEnter.SetLevel)), HarmonyPostfix]
    private static void SetLevel(AbyssLevelEnter __instance) =>
        __instance.levelName = StringStore.TranslateText(__instance.levelName);
}
#endif
