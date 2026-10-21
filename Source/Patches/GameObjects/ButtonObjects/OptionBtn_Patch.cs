using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects;

[HarmonyPatch(typeof(OptionBtn))]
public static class OptionBtn_Patch
{
    [HarmonyPatch(nameof(OptionBtn.Awake)), HarmonyPostfix]
    private static void Awake(OptionBtn __instance)
    {
        var text1Transform = __instance.transform.GetChild(0)?.transform;

        if (text1Transform != null)
        {
            var text1 = text1Transform.GetComponent<TextMeshProUGUI>();
            text1 = StringStore.TranslateText(text1);
            text1.autoSizeTextContainer = false;
        }

        var textTransform = __instance.transform.GetChild(1)?.transform;

        if (textTransform != null)
        {
            var text = textTransform.GetComponent<TextMeshProUGUI>();
            text = StringStore.TranslateText(text);
            text.autoSizeTextContainer = false;
        }

        var text2Transform = __instance.transform.GetChild(2)?.transform;

        if (text2Transform == null)
            return;

        var text2 = text2Transform.GetComponent<TextMeshProUGUI>();
        text2 = StringStore.TranslateText(text2);
        text2.autoSizeTextContainer = false;
    }

    [HarmonyPatch("OnMouseUpAsButton"), HarmonyPostfix]
    private static void OnMouseUpAsButtonPostfix(OptionBtn __instance)
    {
        var text1Transform = __instance.transform.GetChild(0)?.transform;

        if (text1Transform != null)
        {
            var text1 = text1Transform.GetComponent<TextMeshProUGUI>();
            text1 = StringStore.TranslateText(text1);
            text1.autoSizeTextContainer = false;
        }

        var textTransform = __instance.transform.GetChild(1)?.transform;

        if (textTransform != null)
        {
            var text = textTransform.GetComponent<TextMeshProUGUI>();
            text = StringStore.TranslateText(text);
            text.autoSizeTextContainer = false;
        }

        var text2Transform = __instance.transform.GetChild(2)?.transform;

        if (text2Transform == null)
            return;

        var text2 = text2Transform.GetComponent<TextMeshProUGUI>();
        StringStore.TranslateText(text2);
    }
}
