using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Il2Cpp;
using Il2CppRhythmGameEditor;
using Il2CppRhythmGame;
using HarmonyLib;
using UnityEngine;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor.RhythmGameEditor
{
    [HarmonyPatch(typeof(RhythmGameChartEditorUI))]
    public static class RhythmGameChartEditorUI_Patch
    {
        [HarmonyPatch(nameof(RhythmGameChartEditorUI.Awake))]
        [HarmonyPostfix]
        public static void Awake(RhythmGameChartEditorUI __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
            foreach(TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.font = fontAsset;
                if (!Utils.CheckForUntranslatedText(txt.text)) continue;
                txt.text = StringStore.TranslateText(txt.text);
            }

            foreach(TextMeshProUGUI txt in __instance.dropdown.GetComponentsInChildren<TextMeshProUGUI>(true))
            {
                txt.text = StringStore.TranslateText(txt.text);
            }
        }

        [HarmonyPatch(nameof(RhythmGameChartEditorUI.Start))]
        [HarmonyPostfix]
        public static void Start(RhythmGameChartEditorUI __instance)
        {
            Awake(__instance);
        }

        [HarmonyPatch(nameof(RhythmGameChartEditorUI.InitializeSubSystems))]
        [HarmonyPostfix]
        public static void InitializeSubSystems(RhythmGameChartEditorUI __instance)
        {
            Awake(__instance);
        }

        [HarmonyPatch(nameof(RhythmGameChartEditorUI.Update))]
        [HarmonyPostfix]
        public static void Update(RhythmGameChartEditorUI __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
            foreach(TextMeshProUGUI txt in __instance.transform.Find("TopPanel").GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.font = fontAsset;
                txt.text = StringStore.TranslateText(txt.text);
            }

            foreach(TheButton btn in __instance.transform.GetComponentsInChildren<TheButton>())
            {
                foreach(TextMeshProUGUI txt in btn.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    if (!Utils.CheckForUntranslatedText(txt.text)) continue;
                    txt.text = StringStore.TranslateText(txt.text);
                }
            }

            foreach(TextMeshProUGUI txt in __instance.dropdown.GetComponentsInChildren<TextMeshProUGUI>(true))
            {
                if (!Utils.CheckForUntranslatedText(txt.text)) continue;
                txt.text = Utils.RemoveSizeTags(StringStore.TranslateText(txt.text));
            }
        }

        [HarmonyPatch(nameof(RhythmGameChartEditorUI.UpdateUI))]
        [HarmonyPostfix]
        public static void UpdateUI(RhythmGameChartEditorUI __instance)
        {
            foreach(TextMeshProUGUI txt in __instance.dropdown.GetComponentsInChildren<TextMeshProUGUI>(true))
            {
                txt.text = StringStore.TranslateText(txt.text);
            }
        }

        [HarmonyPatch(nameof(RhythmGameChartEditorUI.UpdateSelectedNoteInfo))]
        [HarmonyPostfix]
        public static void UpdateSelectedNoteInfo(RhythmGameChartEditorUI __instance)
        {
            __instance.selectedNoteInfoText.text = StringStore.TranslateText(__instance.selectedNoteInfoText.text);
        }
    }
}
