using HarmonyLib;
using System.Collections.Generic;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.BaseTextObjects;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Modes.Super_Editor.GameLevel.EventNodes
{
    [HarmonyPatch(typeof(RuntimeEventNodeEditor))]
    public static class RuntimeEventNodeEditor_Patch
    {
        [HarmonyPatch(nameof(RuntimeEventNodeEditor.AddNode))]
        [HarmonyPostfix]
        public static void AddNode(RuntimeEventNodeEditor __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (var nodeUI in __instance.nodeUIs)
            {
                string nodeName = nodeUI.key;
                RuntimeNodeUI node = nodeUI.Value;

                foreach (TextMeshProUGUI txt in node.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    txt.text = StringStore.translationString.ContainsKey(txt.text + "_code") ? StringStore.TranslateText(txt.text + "_code") : StringStore.TranslateText(txt.text);
                    txt.font = fontAsset;
                }
            }
        }

        [HarmonyPatch(nameof(RuntimeEventNodeEditor.Update))]
        [HarmonyPostfix]
        public static void Update(RuntimeEventNodeEditor __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (var node in __instance.nodeUIs)
            {
                RuntimeNodeUI nodeUI = node.value;

                if (nodeUI.Node.nodeType == "PlantTypeValueNode")
                {
                    Transform buttonTransform = nodeUI.transform.Find("Header/ValueEditContainer/Button(Clone)/Label");
                    if (buttonTransform == null) continue;
                    TextMeshProUGUI txt = buttonTransform.GetComponent<TextMeshProUGUI>();

                    if (!txt.gameObject.name.Contains("Label")) continue;
                    if (!Utils.CheckForUntranslatedText(txt.text)) continue;

                    string plantName = Utils.GetPlantNameFromAlmanac(nodeUI.Node.GetPortValue<PlantType>(nodeUI.Node.GetOutputPorts()[0].portName, PlantType.Nothing));
                    txt.text = (plantName != "") ? plantName : StringStore.TranslateText(txt.text);
                    txt.font = fontAsset;
                }
                else if (nodeUI.Node.nodeType == "ZombieTypeValueNode")
                {
                    Transform buttonTransform = nodeUI.transform.Find("Header/ValueEditContainer/Button(Clone)/Label");
                    if (buttonTransform == null) continue;
                    TextMeshProUGUI txt = buttonTransform.GetComponent<TextMeshProUGUI>();

                    if (!txt.gameObject.name.Contains("Label")) continue;
                    if (!Utils.CheckForUntranslatedText(txt.text)) continue;

                    string zombieName = Utils.GetZombieNameFromAlmanac(nodeUI.Node.GetPortValue<ZombieType>(nodeUI.Node.GetOutputPorts()[0].portName, ZombieType.Nothing));
                    txt.text = (zombieName != "") ? zombieName : StringStore.TranslateText(txt.text);
                    txt.font = fontAsset;
                }
                else if (nodeUI.Node.nodeType == "PlantTypeListStorageNode")
                {
                    Transform dropdownTransform = nodeUI.transform.Find("Header/ValueEditContainer/Dropdown(Clone)");
                    if (dropdownTransform == null) continue;

                    foreach (TextMeshProUGUI txt in dropdownTransform.GetComponentsInChildren<TextMeshProUGUI>())
                    {
                        if (!Utils.CheckForUntranslatedText(txt.text)) continue;

                        txt.text = StringStore.TranslateText(txt.text);
                        txt.font = fontAsset;
                    }
                }
            }
        }
    }
}