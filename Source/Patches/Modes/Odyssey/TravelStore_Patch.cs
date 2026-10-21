using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey;

[HarmonyPatch(typeof(TravelStore))]
public static class TravelStore_Patch
{
    [HarmonyPatch(nameof(TravelStore.Start)), HarmonyPostfix]
    private static void Start(TravelStore __instance) => TranslateStoreText(__instance);

    [HarmonyPatch(nameof(TravelStore.Update)), HarmonyPostfix]
    private static void Update(TravelStore __instance) => TranslateStoreText(__instance);

    [HarmonyPatch(nameof(TravelStore.RefreshBuff)), HarmonyPostfix]
    private static void RefreshBuff(TravelStore __instance) => TranslateStoreText(__instance);

    [HarmonyPatch(nameof(TravelStore.SelectBuff)), HarmonyPostfix]
    private static void SelectBuff(TravelStore __instance, ref TravelStoreWindow window)
    {
        TranslateStoreText(__instance);

        foreach (var text in window.buttonText)
            text.text = StringStore.TranslateText(text.text);

        __instance.investText.text = TranslateInvestText(__instance.investText.text);
        __instance.investTextshadow.text = TranslateInvestText(__instance.investTextshadow.text);
    }

    public static void TranslateStoreText(TravelStore __instance)
    {
        __instance.investText.text = TranslateInvestText(__instance.investText.text);
        __instance.investTextshadow.text = TranslateInvestText(__instance.investTextshadow.text);

        foreach (var text in __instance.pointText)
            text.text = StringStore.TranslateText(text.text);

        foreach (var text in __instance.refreshText)
            text.text = StringStore.TranslateText(text.text);

        foreach (var text in __instance.transform.Find("Quit").GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateText("合上");
    }

    public static string TranslateInvestText(string investText)
    {
        if (!Utils.CheckForUntranslatedText(investText))
            return investText;

        var investStats = investText.Split("\n\n");

        var translatedInvestStats = investStats
           .Select(investStat => investStat.Split("\n"))
           .Select(lines => lines.Select(line => StringStore.TranslateColorText(line)).ToList())
           .Select(translatedLines => string.Join("\n", translatedLines))
           .ToList();

        return string.Join("\n\n", translatedInvestStats);
    }
}
