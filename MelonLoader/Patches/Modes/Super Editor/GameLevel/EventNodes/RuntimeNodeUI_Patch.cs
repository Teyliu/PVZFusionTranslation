using HarmonyLib;
using Il2CppGameLevel.EventNodes;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.BaseTextObjects;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor.GameLevel.EventNodes
{
    [HarmonyPatch(typeof(RuntimeNodeUI))]
    public static class RuntimeNodeUI_Patch
    {
        [HarmonyPatch(nameof(RuntimeNodeUI.Awake))]
        [HarmonyPatch(nameof(RuntimeNodeUI.CreatePorts))]
        [HarmonyPatch(nameof(RuntimeNodeUI.CreateValueEditUI))]
        [HarmonyPatch(nameof(RuntimeNodeUI.GetPortUI))]
        [HarmonyPatch(nameof(RuntimeNodeUI.UpdateDisplay))]
        [HarmonyPatch(nameof(RuntimeNodeUI.UpdateSelectionVisual))]
        [HarmonyPatch(nameof(RuntimeNodeUI.UpdateVisable))]
        [HarmonyPostfix]
        public static void Post_UpdateDisplay(RuntimeNodeUI __instance)
        {
            if (!__instance.isActiveAndEnabled) return;

            if (__instance.Node == null) return;

            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            __instance.titleText.text = TranslateCodeText(__instance.titleText.text);
            __instance.titleText.font = fontAsset;

            foreach(TextMeshProUGUI txt in __instance.inputPortsContainer.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = TranslateCodeText(txt.text);
                txt.font = fontAsset;
            }

            foreach(TextMeshProUGUI txt in __instance.outputPortsContainer.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = TranslateCodeText(txt.text);
                txt.font = fontAsset;
            }

            if (
                   __instance.GetComponentsInChildren<TMP_Dropdown>().Count == 0
                && __instance.GetComponentsInChildren<TMP_InputField>().Count == 0
                && __instance.Node.nodeType != "PlantTypeValueNode"
                && __instance.Node.nodeType != "SinglePlantTypeListNode"
                && __instance.Node.nodeType != "ZombieTypeValueNode"
            ) return;

            if (__instance.Node != null)
            {
                if(__instance.Node.nodeType == "PlantTypeValueNode")
                {
                    foreach(TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
                    {
                        if(txt.gameObject.name.Contains("Label"))
                        {
                            if (Utils.CheckForUntranslatedText(txt.text))
                            {
                                PlantTypeValueNode castedNode = __instance.Node.TryCast<PlantTypeValueNode>();
                                if (castedNode != null)
                                {
                                    string portName = castedNode.value_PortName;
                                    string plantName = Utils.GetPlantNameFromAlmanac(castedNode.value, removeTags: true);
                                    txt.text = (plantName != "") ? plantName : StringStore.TranslateText(txt.text);
                                    txt.font = fontAsset;
                                }
                            }
                        }
                    }
                }

                if(__instance.Node.nodeType == "SinglePlantTypeListNode")
                {
                    foreach(TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
                    {
                        if (txt.gameObject.name.Contains("Label"))
                        {
                            if (Utils.CheckForUntranslatedText(txt.text))
                            {
                                SinglePlantTypeListNode castedNode = __instance.Node.TryCast<SinglePlantTypeListNode>();
                                if (castedNode != null)
                                {
                                    string portName = castedNode.plantTypeList_PortName;
                                    string plantName = Utils.GetPlantNameFromAlmanac(castedNode.plantType, removeTags: true);
                                    txt.text = (plantName != "") ? plantName : StringStore.TranslateText(txt.text);
                                    txt.font = fontAsset;
                                }
                            }
                        }
                    }
                }

                if(__instance.Node.nodeType == "ZombieTypeValueNode")
                {
                    foreach(TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
                    {
                        if(txt.gameObject.name.Contains("Label"))
                        {
                            if(Utils.CheckForUntranslatedText(txt.text))
                            {
                                ZombieTypeValueNode castedNode = __instance.Node.TryCast<ZombieTypeValueNode>();
                                if(castedNode != null)
                                {
                                    string portName = castedNode.value_PortName;
                                    string zombieName = Utils.GetZombieNameFromAlmanac(castedNode.value, removeTags: true);
                                    txt.text = (zombieName != "") ? zombieName : StringStore.TranslateText(txt.text);
                                    txt.font = fontAsset;
                                }
                            }
                        }
                    }
                }
            }

            if(__instance.GetComponentsInChildren<TMP_Dropdown>().Count > 0)
            {
                foreach(TMP_Dropdown dropdown in __instance.GetComponentsInChildren<TMP_Dropdown>())
                {
                    TMP_Dropdown_Patch.CreateDropdownList(dropdown);
                }
            }

            if(__instance.GetComponentsInChildren<TMP_InputField>().Count > 0)
            {
                foreach(TMP_InputField inputField in __instance.GetComponentsInChildren<TMP_InputField>())
                {
                    TMP_InputField_Patch.OnEnable(inputField);
                    foreach(TextMeshProUGUI txt in inputField.GetComponentsInChildren<TextMeshProUGUI>(true))
                    {
                        txt.text = TranslateCodeText(txt.text);
                    }
                }
            }
        }
    
        public static string TranslateCodeText(string originalText)
        {
            return StringStore.translationString.ContainsKey(originalText + "_code") ? StringStore.TranslateText(originalText + "_code") : StringStore.TranslateText(originalText);
        }
    }
}
