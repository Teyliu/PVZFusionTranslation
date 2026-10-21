using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Managers;

[HarmonyPatch(typeof(ChessManager))]
public static class ChessManager_Patch
{
    [HarmonyPatch(nameof(ChessManager.Start)), HarmonyPostfix]
    private static void Postfix_Start(ChessManager __instance)
    {
        __instance.textMesh.text = StringStore.TranslateText(__instance.textMesh.text);
        __instance.textMesh.font = FontStore.LoadTMPFont(Utils.Language.ToString());
    }

    [HarmonyPatch(nameof(ChessManager.Update)), HarmonyPostfix]
    private static void Postfix_Update(ChessManager __instance)
    {
        __instance.textMesh.text = StringStore.TranslateText(__instance.textMesh.text);
        __instance.textMesh.font = FontStore.LoadTMPFont(Utils.Language.ToString());
    }

    [HarmonyPatch(nameof(ChessManager.UpdateText)), HarmonyPostfix]
    private static void Postfix_UpdateText(ChessManager __instance)
    {
        __instance.textMesh.text = StringStore.TranslateText(__instance.textMesh.text);
        __instance.textMesh.font = FontStore.LoadTMPFont(Utils.Language.ToString());
    }
}
