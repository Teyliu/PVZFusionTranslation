using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Starbound;

[HarmonyPatch(typeof(AdvantureMenu2))]
public static class AdvantureMenu2_Patch
{
    [HarmonyPatch(nameof(AdvantureMenu2.Awake)), HarmonyPostfix]
    private static void Awake(AdvantureMenu2 __instance)
    {
        foreach (var text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateText(text.text);
    }

    [HarmonyPatch(nameof(AdvantureMenu2.AdjustDifficulty)), HarmonyPostfix]
    private static void AdjustDifficulty(AdvantureMenu2 __instance) =>
        __instance.difficulty.text = StringStore.TranslateText(__instance.difficulty.text);
}
