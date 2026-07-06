using HarmonyLib;
using Il2CppGameLevel.EventNodes;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.BaseTextObjects;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor.GameLevel.EventNodes
{
    [HarmonyPatch(typeof(RuntimeEventNodeEditor))]
    public static class RuntimeEventNodeEditor_Patch
    {
        public static TMP_FontAsset fontAsset => FontStore.LoadTMPFont(Utils.Language.ToString());

        [HarmonyPatch(nameof(RuntimeEventNodeEditor.Update))]
        [HarmonyPostfix]
        public static void Update(RuntimeEventNodeEditor __instance)
        {
            // translate the new screens (3.7)
            TranslateFullTransform(__instance.nodeInfoPanel.transform);
            TranslateFullTransform(__instance.attributePanel.transform);
            TranslateFullTransform(__instance.canvas.transform);
            if(__instance.TryGetComponent<EventNodeContextMenu>(out EventNodeContextMenu eventNodeContextMenu))
            {
                TranslateFullTransform(eventNodeContextMenu.transform);
            }
        }
    
        public static void TranslateFullTransform(Transform transform)
        {
            if (transform == null) return;

            foreach(TextMeshProUGUI txt in transform.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = RuntimeNodeUI_Patch.TranslateCodeText(txt.text);
                txt.font = fontAsset;
            }

            foreach(TMP_InputField inputField in transform.GetComponentsInChildren<TMP_InputField>())
            {
                TMP_InputField_Patch.OnEnable(inputField);
                foreach(TextMeshProUGUI txt in inputField.GetComponentsInChildren<TextMeshProUGUI>(true))
                {
                    txt.text = RuntimeNodeUI_Patch.TranslateCodeText(txt.text);
                }
            }
        }
    }
}
