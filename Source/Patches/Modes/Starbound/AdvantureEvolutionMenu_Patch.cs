using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Starbound;

[HarmonyPatch(typeof(AdvantureEvolutionMenu))]
public static class AdvantureEvolutionMenu_Patch
{
    [HarmonyPatch(nameof(AdvantureMenu.Awake)), HarmonyPostfix]
    public static void Awake(AdvantureEvolutionMenu __instance)
    {
        foreach (var text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateColorText(text.text);

        var baseWindow = __instance.transform.Find("BaseWindow");
        var advancedWindow = __instance.transform.Find("AdvancedWindow");

        if (baseWindow != null)
            foreach (var text in baseWindow.GetComponentsInChildren<TextMeshProUGUI>()
               .Where(text => text.gameObject.name.Contains("Name")))
                text.text = Utils.GetPlantNameFromAlmanac(__instance.thePlantType);

        if (advancedWindow == null)
            return;

        foreach (var text in advancedWindow.GetComponentsInChildren<TextMeshProUGUI>()
           .Where(text => text.gameObject.name.Contains("Name")))
            text.text = Utils.GetPlantNameFromAlmanac(__instance.thePlantType);
    }

    [HarmonyPatch(nameof(AdvantureEvolutionMenu.UpdateText)), HarmonyPostfix]
    public static void UpdateText(AdvantureEvolutionMenu __instance)
    {
        foreach (var text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateColorText(text.text);
    }

    [HarmonyPatch(nameof(AdvantureEvolutionMenu.RollEvolution)), HarmonyPostfix]
    public static void RollEvolution(AdvantureEvolutionMenu __instance)
    {
        foreach (var text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateColorText(text.text);
    }

    [HarmonyPatch(nameof(AdvantureEvolutionMenu.RollEvolutionGood)), HarmonyPostfix]
    public static void RollEvolutionGood(AdvantureEvolutionMenu __instance)
    {
        foreach (var text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateColorText(text.text);
    }
}
