using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey;

[HarmonyPatch(typeof(TravelInvestMenu))]
public static class TravelInvestMenu_Patch
{
    [HarmonyPatch(nameof(TravelInvestMenu.Start)), HarmonyPostfix]
    private static void Start(TravelInvestMenu __instance)
    {
        var titleText = __instance.transform.Find("Title");
        var shadowText = titleText.GetComponent<TextMeshProUGUI>();

        var regularText = titleText.transform.Find("Title2").GetComponent<TextMeshProUGUI>();
        regularText.text = StringStore.TranslateText(regularText.text);

        shadowText.text = Utils.RemoveColorTags(regularText.text);
    }

    [HarmonyPatch(nameof(TravelInvestMenu.RefreshBuff)), HarmonyPostfix]
    private static void RefreshBuff(TravelInvestMenu __instance, ref TravelBuffOptionButton option) =>
        TravelBuffOptionButton_Patch.TranslateOptionButton(option);
}
