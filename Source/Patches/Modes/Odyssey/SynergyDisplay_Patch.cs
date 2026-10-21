using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey;

[HarmonyPatch(typeof(SynergyDisplay))]
public static class SynergyDisplay_Patch
{
    [HarmonyPatch(nameof(SynergyDisplay.Start)), HarmonyPostfix]
    public static void Start(SynergyDisplay __instance) =>
        __instance.text.text = TranslateInvestDisplay(__instance.text.text);

    public static string TranslateInvestDisplay(string originalText)
    {
        var parts = originalText.Split("\n\n");
        var translatedParts = parts.Select(part => StringStore.TranslateColorText(part)).ToList();
        return string.Join("\n\n", translatedParts);
    }
}
