using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.BaseTextObjects;
using UnityEngine;
using RhythmGameEditor;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Modes.Super_Editor.RhythmGameEditor
{
    [HarmonyPatch(typeof(RhythmGameChartEditorUI))]
    public static class RhythmGameChartEditorUI_Patch
    {
        [HarmonyPatch(nameof(RhythmGameChartEditorUI.Start))]
        [HarmonyPatch(nameof(RhythmGameChartEditorUI.BindUIEvents))]
        [HarmonyPatch(nameof(RhythmGameChartEditorUI.UpdateUI))]
        [HarmonyPatch(nameof(RhythmGameChartEditorUI.OpenFile))]
        [HarmonyPatch(nameof(RhythmGameChartEditorUI.UpdateSelectedNoteInfo))]
        [HarmonyPatch(nameof(RhythmGameChartEditorUI.UpdateTimeDisplay))]
        [HarmonyPatch(nameof(RhythmGameChartEditorUI.UpdateAutoScroll))]
        [HarmonyPostfix]
        public static void Start(RhythmGameChartEditorUI __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TMP_Dropdown dropdown in __instance.GetComponentsInChildren<TMP_Dropdown>(true))
            {
                TMP_Dropdown_Patch.CreateDropdownList(dropdown);
            }

            foreach (TMP_InputField input in __instance.GetComponentsInChildren<TMP_InputField>(true))
            {
                TMP_InputField_Patch.OnEnable(input);
            }

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>(true))
            {
                txt.text = StringStore.translationString.ContainsKey(txt.text + "_code") ? StringStore.TranslateText(txt.text + "_code") : StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }
    }
}