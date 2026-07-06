/*using MelonLoader;
using HarmonyLib;
using UnityEngine;
using Il2Cpp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using Il2CppGameLevel;
using PvZ_Fusion_Translator.Patches.Modes.Super_Editor.GameLevel.EventNodes;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor
{
    [HarmonyPatch(typeof(CustomMenuPage_event))]
    public static class CustomMenuPage_event_Patch
    {
        [HarmonyPatch(nameof(CustomMenuPage_event.InitializeNodeEditor))]
        [HarmonyPostfix]
        public static void InitializeNodeEditor(CustomMenuPage_event __instance)
        {
            RuntimeEventNodeEditor_Patch.Update(__instance.nodeEditor);
            NodeInfoPanel_Patch.UpdatePanelContent(__instance.nodeInfoPanel);
        }
    }
}
*/