using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using GameLevel.EventNodes;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Modes.Super_Editor.GameLevel.EventNodes
{
    [HarmonyPatch(typeof(NodeGroupUI))]
    public static class NodeGroupUI_Patch
    {
        [HarmonyPatch(nameof(NodeGroupUI.Initialize))]
        [HarmonyPatch(nameof(NodeGroupUI.UpdateTitle))]
        [HarmonyPatch(nameof(NodeGroupUI.ToggleFold))]
        [HarmonyPostfix]
        public static void Initialize(NodeGroupUI __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>(true))
            {
                txt.text = StringStore.translationString.ContainsKey(txt.text + "_code") ? StringStore.TranslateText(txt.text + "_code") : StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }
    }
}