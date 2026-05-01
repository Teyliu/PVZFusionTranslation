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
    [HarmonyPatch(typeof(RuntimeNodeUI))]
    public static class RuntimeNodeUI_Patch
    {
        [HarmonyPatch(nameof(RuntimeNodeUI.Awake))]
        [HarmonyPostfix]
        public static void Awake(RuntimeNodeUI __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach(TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.translationString.ContainsKey(txt.text + "_code") ? StringStore.TranslateText(txt.text + "_code") : StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(RuntimeNodeUI.Initialize))]
        [HarmonyPostfix]
        public static void Initialize(RuntimeNodeUI __instance)
        {
            Awake(__instance);
        }

        [HarmonyPatch(nameof(RuntimeNodeUI.UpdateDisplay))]
        [HarmonyPostfix]
        public static void UpdateDisplay(RuntimeNodeUI __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            if(__instance.Node.nodeType == "PlantTypeValueNode")
            {
                foreach(TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    if(txt.gameObject.name.Contains("Label"))
                    {
                        string plantName = Utils.GetPlantNameFromAlmanac(__instance.Node.GetPortValue<PlantType>(__instance.Node.nodeName, PlantType.Nothing));
                        txt.text = (plantName != "") ? plantName : StringStore.TranslateText(txt.text);
                        txt.font = fontAsset;
                    }
                }
            }

            if(__instance.Node.nodeType == "ZombieTypeValueNode")
            {
                foreach(TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
                {
                    if(txt.gameObject.name.Contains("Label"))
                    {
                        string zombieName = Utils.GetZombieNameFromAlmanac(__instance.Node.GetPortValue<ZombieType>(__instance.Node.nodeName, ZombieType.Nothing));
                        txt.text = (zombieName != "") ? zombieName : StringStore.TranslateText(txt.text);
                        txt.font = fontAsset;
                    }
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
