using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.BaseTextObjects;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor.GameLevel.EventNodes;

[HarmonyPatch(typeof(RuntimeNodeUI))]
public static class RuntimeNodeUI_Patch
{
    [HarmonyPatch(nameof(RuntimeNodeUI.Awake)), HarmonyPatch(nameof(RuntimeNodeUI.CreatePorts)),
     HarmonyPatch(nameof(RuntimeNodeUI.CreateValueEditUI)), HarmonyPatch(nameof(RuntimeNodeUI.GetPortUI)),
     HarmonyPatch(nameof(RuntimeNodeUI.UpdateDisplay)), HarmonyPatch(nameof(RuntimeNodeUI.UpdateSelectionVisual)),
     HarmonyPatch(nameof(RuntimeNodeUI.UpdateVisable)), HarmonyPostfix]
    public static void Post_UpdateDisplay(RuntimeNodeUI __instance)
    {
        if (!__instance.isActiveAndEnabled)
            return;

        if (__instance.Node == null)
            return;

        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        __instance.titleText.text = TranslateCodeText(__instance.titleText.text);
        __instance.titleText.font = fontAsset;

        foreach (var txt in __instance.inputPortsContainer.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = TranslateCodeText(txt.text);
            txt.font = fontAsset;
        }

        foreach (var txt in __instance.outputPortsContainer.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = TranslateCodeText(txt.text);
            txt.font = fontAsset;
        }

        if (
            __instance.GetComponentsInChildren<TMP_Dropdown>().Count == 0 &&
            __instance.GetComponentsInChildren<TMP_InputField>().Count == 0 &&
            __instance.Node.nodeType != "PlantTypeValueNode" &&
            __instance.Node.nodeType != "SinglePlantTypeListNode" &&
            __instance.Node.nodeType != "ZombieTypeValueNode"
        )
            return;

        if (__instance.Node != null)
        {
            if (__instance.Node.nodeType == "PlantTypeValueNode")
                foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
                    if (txt.gameObject.name.Contains("Label"))
                        if (Utils.CheckForUntranslatedText(txt.text))
                        {
                            var castedNode = __instance.Node.TryCast<PlantTypeValueNode>();

                            if (castedNode == null)
                                continue;

                            _ = castedNode.value_PortName;
                            var plantName = Utils.GetPlantNameFromAlmanac(castedNode.value, true);
                            txt.text = plantName != "" ? plantName : StringStore.TranslateText(txt.text);
                            txt.font = fontAsset;
                        }

            if (__instance.Node.nodeType == "SinglePlantTypeListNode")
                foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
                    if (txt.gameObject.name.Contains("Label"))
                        if (Utils.CheckForUntranslatedText(txt.text))
                        {
                            var castedNode = __instance.Node.TryCast<SinglePlantTypeListNode>();

                            if (castedNode == null)
                                continue;

                            _ = castedNode.plantTypeList_PortName;
                            var plantName = Utils.GetPlantNameFromAlmanac(castedNode.plantType, true);
                            txt.text = plantName != "" ? plantName : StringStore.TranslateText(txt.text);
                            txt.font = fontAsset;
                        }

            if (__instance.Node.nodeType == "ZombieTypeValueNode")
                foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
                    if (txt.gameObject.name.Contains("Label"))
                        if (Utils.CheckForUntranslatedText(txt.text))
                        {
                            var castedNode = __instance.Node.TryCast<ZombieTypeValueNode>();

                            if (castedNode == null)
                                continue;

                            _ = castedNode.value_PortName;
                            var zombieName = Utils.GetZombieNameFromAlmanac(castedNode.value, true);
                            txt.text = zombieName != "" ? zombieName : StringStore.TranslateText(txt.text);
                            txt.font = fontAsset;
                        }
        }

        if (__instance.GetComponentsInChildren<TMP_Dropdown>().Count > 0)
            foreach (var dropdown in __instance.GetComponentsInChildren<TMP_Dropdown>())
                TMP_Dropdown_Patch.CreateDropdownList(dropdown);

        if (__instance.GetComponentsInChildren<TMP_InputField>().Count <= 0)
            return;

        foreach (var inputField in __instance.GetComponentsInChildren<TMP_InputField>())
        {
            TMP_InputField_Patch.OnEnable(inputField);

            foreach (var txt in inputField.GetComponentsInChildren<TextMeshProUGUI>(true))
                txt.text = TranslateCodeText(txt.text);
        }
    }

    public static string TranslateCodeText(string originalText) =>
        StringStore.TranslationString.ContainsKey(originalText + "_code")
            ? StringStore.TranslateText(originalText + "_code")
            : StringStore.TranslateText(originalText);
}
