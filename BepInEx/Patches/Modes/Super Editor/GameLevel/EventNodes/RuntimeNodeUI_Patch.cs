using HarmonyLib;
using System.Collections.Generic;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.BaseTextObjects;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Modes.Super_Editor.GameLevel.EventNodes
{
    [HarmonyPatch(typeof(RuntimeNodeUI))]
    public static class RuntimeNodeUI_Patch
    {
        [HarmonyPatch(nameof(RuntimeNodeUI.Awake))]
        [HarmonyPatch(nameof(RuntimeNodeUI.Initialize))]
        [HarmonyPatch(nameof(RuntimeNodeUI.CreatePorts))]
        [HarmonyPatch(nameof(RuntimeNodeUI.CreateTravelEntryEditUI), new System.Type[] { typeof(RectTransform), typeof(GetTravelEntryNode) })]
        [HarmonyPatch(nameof(RuntimeNodeUI.CreateStringInputField))]
        [HarmonyPatch(nameof(RuntimeNodeUI.CreatePorts))]
        [HarmonyPostfix]
        public static void Awake(RuntimeNodeUI __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            if (__instance.dropdownPrefab != null)
            {
                if (__instance.dropdownPrefab.TryGetComponent<TMP_Dropdown>(out TMP_Dropdown dropdown))
                {
                    TMP_Dropdown_Patch.CreateDropdownList(dropdown);
                }
            }

            if (__instance.valueInputField != null)
            {
                TMP_InputField_Patch.OnEnable(__instance.valueInputField);
                foreach (TextMeshProUGUI txt in __instance.valueInputField.GetComponentsInChildren<TextMeshProUGUI>(true))
                {
                    txt.text = StringStore.translationString.ContainsKey(txt.text + "_code") ? StringStore.TranslateText(txt.text + "_code") : StringStore.TranslateText(txt.text);
                }
            }

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.translationString.ContainsKey(txt.text + "_code") ? StringStore.TranslateText(txt.text + "_code") : StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(RuntimeNodeUI.UpdateDisplay))]
        [HarmonyPostfix]
        public static void UpdateDisplay(RuntimeNodeUI __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            if (__instance.Node.nodeType == "PlantTypeValueNode")
            {
                foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    if (txt.gameObject.name.Contains("Label"))
                    {
                        string plantName = Utils.GetPlantNameFromAlmanac(__instance.Node.GetPortValue<PlantType>(__instance.Node.nodeName, PlantType.Nothing));
                        txt.text = (plantName != "") ? plantName : StringStore.TranslateText(txt.text);
                        txt.font = fontAsset;
                    }
                }
            }

            if (__instance.Node.nodeType == "ZombieTypeValueNode")
            {
                foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    if (txt.gameObject.name.Contains("Label"))
                    {
                        string zombieName = Utils.GetZombieNameFromAlmanac(__instance.Node.GetPortValue<ZombieType>(__instance.Node.nodeName, ZombieType.Nothing));
                        txt.text = (zombieName != "") ? zombieName : StringStore.TranslateText(txt.text);
                        txt.font = fontAsset;
                    }
                }
            }

            if (__instance.dropdownPrefab != null)
            {
                if (__instance.dropdownPrefab.TryGetComponent<TMP_Dropdown>(out TMP_Dropdown dropdown))
                {
                    TMP_Dropdown_Patch.CreateDropdownList(dropdown);
                }
            }

            if (__instance.valueInputField != null)
            {
                TMP_InputField_Patch.OnEnable(__instance.valueInputField);
                foreach (TextMeshProUGUI txt in __instance.valueInputField.GetComponentsInChildren<TextMeshProUGUI>(true))
                {
                    txt.text = StringStore.translationString.ContainsKey(txt.text + "_code") ? StringStore.TranslateText(txt.text + "_code") : StringStore.TranslateText(txt.text);
                }
            }
        }

        [HarmonyPatch(nameof(RuntimeNodeUI.UpdateSelectionVisual))]
        [HarmonyPostfix]
        public static void UpdateSelectionVisual(RuntimeNodeUI __instance)
        {
            UpdateDisplay(__instance);
        }
    }
}