using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor.RhythmGame;

[HarmonyPatch(typeof(RhythmGameChartEditorUI))]
public static class RhythmGameChartEditorUI_Patch
{
    [HarmonyPatch(nameof(RhythmGameChartEditorUI.Awake)), HarmonyPostfix]
    public static void Awake(RhythmGameChartEditorUI __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.font = fontAsset;

            if (!Utils.CheckForUntranslatedText(txt.text))
                continue;

            txt.text = StringStore.TranslateText(txt.text);
        }

        foreach (var txt in __instance.dropdown.GetComponentsInChildren<TextMeshProUGUI>(true))
            txt.text = StringStore.TranslateText(txt.text);
    }

    [HarmonyPatch(nameof(RhythmGameChartEditorUI.Start)), HarmonyPostfix]
    public static void Start(RhythmGameChartEditorUI __instance) => Awake(__instance);

    [HarmonyPatch(nameof(RhythmGameChartEditorUI.InitializeSubSystems)), HarmonyPostfix]
    public static void InitializeSubSystems(RhythmGameChartEditorUI __instance) => Awake(__instance);

    [HarmonyPatch(nameof(RhythmGameChartEditorUI.Update)), HarmonyPostfix]
    public static void Update(RhythmGameChartEditorUI __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.transform.Find("TopPanel").GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.font = fontAsset;
            txt.text = StringStore.TranslateText(txt.text);
        }

        foreach (var txt in __instance.transform.GetComponentsInChildren<TheButton>()
           .SelectMany(
                b => b.GetComponentsInChildren<TextMeshProUGUI>().Where(t => Utils.CheckForUntranslatedText(t.text))
            ))
            txt.text = StringStore.TranslateText(txt.text);

        foreach (var txt in __instance.dropdown.GetComponentsInChildren<TextMeshProUGUI>(true)
           .Where(txt => Utils.CheckForUntranslatedText(txt.text)))
            txt.text = Utils.RemoveSizeTags(StringStore.TranslateText(txt.text));
    }

    [HarmonyPatch(nameof(RhythmGameChartEditorUI.UpdateUI)), HarmonyPostfix]
    public static void UpdateUI(RhythmGameChartEditorUI __instance)
    {
        foreach (var txt in __instance.dropdown.GetComponentsInChildren<TextMeshProUGUI>(true))
            txt.text = StringStore.TranslateText(txt.text);
    }

    [HarmonyPatch(nameof(RhythmGameChartEditorUI.UpdateSelectedNoteInfo)), HarmonyPostfix]
    public static void UpdateSelectedNoteInfo(RhythmGameChartEditorUI __instance) =>
        __instance.selectedNoteInfoText.text = StringStore.TranslateText(__instance.selectedNoteInfoText.text);
}
