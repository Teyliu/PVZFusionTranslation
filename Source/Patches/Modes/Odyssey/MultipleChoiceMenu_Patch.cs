using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey;

[HarmonyPatch(typeof(MultipleChoiceMenu))]
public static class MultipleChoiceMenu_Patch
{
    public static TMP_FontAsset FontAsset => FontStore.LoadTMPFont(Utils.Language.ToString());

    [HarmonyPatch(nameof(MultipleChoiceMenu.Awake)), HarmonyPatch(nameof(MultipleChoiceMenu.Cancel)),
     HarmonyPatch(nameof(MultipleChoiceMenu.Refresh)), HarmonyPatch(nameof(MultipleChoiceMenu.TurnPage)),
     HarmonyPatch(nameof(MultipleChoiceMenu.UpdateWindow)), HarmonyPostfix]
    public static void Awake(MultipleChoiceMenu __instance)
    {
        foreach (var window in __instance.windows)
        {
            TranslateWindowText(window.title);
            TranslateWindowText(window.introduce);
        }

        foreach (var txt in __instance.GetComponentsInChildren<TheButton>()
           .SelectMany(button => button.GetComponentsInChildren<TextMeshProUGUI>()))
        {
            txt.text = StringStore.TranslationString.ContainsKey(txt.text + "_MC")
                ? StringStore.TranslateText(txt.text + "_MC")
                : StringStore.TranslateText(txt.text);

            txt.font = FontAsset;
        }
    }

    public static void TranslateWindowText(TextMeshProUGUI txt)
    {
        txt.font = FontAsset;

        if (StringStore.CustomLevelString.TryGetValue(txt.text, out var value))
            txt.text = value;
        else if (Utils.GetPlantNameFromAlmanac(txt.text) != "")
            txt.text = Utils.GetPlantNameFromAlmanac(txt.text);
        else
            txt.text = StringStore.TranslationString.ContainsKey(txt.text + "_MC")
                ? StringStore.TranslateText(txt.text + "_MC")
                : StringStore.TranslateText(txt.text);
    }
}
