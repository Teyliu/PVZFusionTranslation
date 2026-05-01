using Il2Cpp;
using Il2CppGameLevel;
using HarmonyLib;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Il2CppGameLevel.EventNodes;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor.GameLevel.EventNodes
{
    [HarmonyPatch(typeof(RuntimeEventNodeEditor))]
    public static class RuntimeEventNodeEditor_Patch
    {
        [HarmonyPatch(nameof(RuntimeEventNodeEditor.AddNode))]
        [HarmonyPostfix]
        public static void AddNode(RuntimeEventNodeEditor __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach(var nodeUI in __instance.nodeUIs)
            {
                string nodeName = nodeUI.key;
                RuntimeNodeUI node = nodeUI.Value;

                foreach(TextMeshProUGUI txt in node.GetComponentsInChildren<TextMeshProUGUI>())
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

            foreach(var node in __instance.nodeUIs)
            {
                RuntimeNodeUI nodeUI = node.value;

                if(nodeUI.Node.nodeType == "PlantTypeValueNode")
                {
                    Transform buttonTransform = nodeUI.transform.Find("Header/ValueEditContainer/Button(Clone)/Label");
                    TextMeshProUGUI txt = buttonTransform.GetComponent<TextMeshProUGUI>();

                    if (!txt.gameObject.name.Contains("Label")) continue;
                    if (!Utils.CheckForUntranslatedText(txt.text)) continue;

                    string plantName = Utils.GetPlantNameFromAlmanac(nodeUI.Node.GetPortValue<PlantType>(nodeUI.Node.GetOutputPorts()[0].portName, PlantType.Nothing));
                    txt.text = (plantName != "") ? plantName : StringStore.TranslateText(txt.text);
                    txt.font = fontAsset;
                }
                else if(nodeUI.Node.nodeType == "ZombieTypeValueNode")
                {
                    Transform buttonTransform = nodeUI.transform.Find("Header/ValueEditContainer/Button(Clone)/Label");
                    TextMeshProUGUI txt = buttonTransform.GetComponent<TextMeshProUGUI>();

                    if (!txt.gameObject.name.Contains("Label")) continue;
                    if (!Utils.CheckForUntranslatedText(txt.text)) continue;

                    string zombieName = Utils.GetZombieNameFromAlmanac(nodeUI.Node.GetPortValue<ZombieType>(nodeUI.Node.GetOutputPorts()[0].portName, ZombieType.Nothing));
                    txt.text = (zombieName != "") ? zombieName : StringStore.TranslateText(txt.text);
                    txt.font = fontAsset;
                }
            }
        }
    }
}
