using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(PlayerSaveMenu))]
public static class PlayerSaveMenu_Patch
{
    [HarmonyPatch(nameof(PlayerSaveMenu.CreatePlayerData)), HarmonyPostfix]
    public static void CreatePlayerData(PlayerSaveMenu __instance) => TranslateCreatePlayerSaveMenu();

    [HarmonyPatch(nameof(PlayerSaveMenu.ResetName)), HarmonyPostfix]
    public static void ResetName(PlayerSaveMenu __instance) => TranslateCreatePlayerSaveMenu();

    public static void TranslateCreatePlayerSaveMenu()
    {
        var reNameMenuTransform = GameAPP.canvasUp.Find("ReNameMenu(Clone)");

        if (reNameMenuTransform.TryGetComponent<ReNameMenu>(out var reNameMenu))
            reNameMenu.title.text = StringStore.TranslateText(reNameMenu.title.text);
    }
}
