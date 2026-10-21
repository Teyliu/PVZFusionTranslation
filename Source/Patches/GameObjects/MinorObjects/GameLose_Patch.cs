using HarmonyLib;
using PvZ_Fusion_Translator.Patches.BaseTextObjects;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects;

[HarmonyPatch(typeof(GameLose))]
public static class GameLose_Patch
{
    [HarmonyPatch(nameof(GameLose.UpdateSecondChanceTimer))]
    public static void UpdateSecondChanceTimer(GameLose __instance)
    {
        if (InGameText.Instance == null)
            return;

        if (InGameText.Instance.timer < 0)
            return;

        InGameText_Patch.TranslateInGameText(InGameText.Instance);
    }
}
