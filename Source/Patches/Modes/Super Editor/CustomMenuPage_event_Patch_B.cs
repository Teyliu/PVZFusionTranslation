#if false
using HarmonyLib;
using PvZ_Fusion_Translator.Patches.Modes.Super_Editor.GameLevel.EventNodes;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor;

[HarmonyPatch(typeof(CustomMenuPage_event))] // ReSharper disable once InconsistentNaming
public static class CustomMenuPage_event_Patch
{
    [HarmonyPatch(nameof(CustomMenuPage_event.InitializeNodeEditor)), HarmonyPostfix]
    public static void InitializeNodeEditor(CustomMenuPage_event __instance)
    {
        RuntimeEventNodeEditor_Patch.Update(__instance.nodeEditor);
        NodeInfoPanel_Patch.UpdatePanelContent(__instance.nodeInfoPanel);
    }
}
#endif
