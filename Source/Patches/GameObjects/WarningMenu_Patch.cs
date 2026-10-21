using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(WarningMenu))]
public static class WarningMenu_Patch
{
    [HarmonyPatch(nameof(WarningMenu.Start)), HarmonyPostfix]
    private static void Start(WarningMenu __instance) => TranslateInvestmentWarning(__instance);

    [HarmonyPatch(nameof(WarningMenu.EnableChallengeMode)), HarmonyPostfix]
    private static void EnableChallengeMode(WarningMenu __instance) => TranslateInvestmentWarning(__instance);

    [HarmonyPatch(nameof(WarningMenu.Cancel)), HarmonyPostfix]
    private static void Cancel(WarningMenu __instance) => TranslateInvestmentWarning(__instance);

    public static void TranslateInvestmentWarning(WarningMenu __instance)
    {
        var normalModeTransform = __instance.transform.Find("Normal");
        var challengeModeTransform = __instance.transform.Find("Challenge");

        if (normalModeTransform != null)
        {
            var text = normalModeTransform.Find("text").GetComponent<TextMeshProUGUI>();
            var textShadow = normalModeTransform.Find("text (1)").GetComponent<TextMeshProUGUI>();

            text.text = StringStore.TranslationString.ContainsKey("普通模式_IV")
                ? StringStore.TranslateText("普通模式_IV")
                : Utils.RemoveColorTags(StringStore.TranslateText(text.text));

            text.alignment = TextAlignmentOptions.Center;
            text.autoSizeTextContainer = true;
            textShadow.text = Utils.RemoveColorTags(text.text);
            textShadow.alignment = TextAlignmentOptions.Center;
            textShadow.autoSizeTextContainer = true;
        }

        if (challengeModeTransform != null)
        {
            var text = challengeModeTransform.Find("text").GetComponent<TextMeshProUGUI>();
            var textShadow = challengeModeTransform.Find("text (1)").GetComponent<TextMeshProUGUI>();

            text.text = StringStore.TranslationString.ContainsKey("诅咒模式_IV")
                ? StringStore.TranslateText("诅咒模式_IV")
                : Utils.RemoveColorTags(StringStore.TranslateText(text.text));

            text.alignment = TextAlignmentOptions.Center;
            text.autoSizeTextContainer = true;
            textShadow.text = Utils.RemoveColorTags(text.text);
            textShadow.alignment = TextAlignmentOptions.Center;
            textShadow.autoSizeTextContainer = true;
        }

        if (__instance.tutor != null)
            foreach (var text in __instance.tutor.GetComponentsInChildren<TextMeshProUGUI>()
               .Where(text => text.gameObject.name == "text1"))
            {
                text.text = StringStore.TranslateText(text.text);

                if (text.transform.parent.Find("text").TryGetComponent<TextMeshProUGUI>(out var textShadow))
                    textShadow.text = Utils.RemoveColorTags(text.text);
            }

        if (__instance.challenge == null)
            return;

        foreach (var text in __instance.challenge.GetComponentsInChildren<TextMeshProUGUI>()
           .Where(text => text.gameObject.name == "text1"))
        {
            text.text = StringStore.TranslateText(text.text);

            if (text.transform.parent.Find("text").TryGetComponent<TextMeshProUGUI>(out var textShadow))
                textShadow.text = Utils.RemoveColorTags(text.text);
        }
    }
}
