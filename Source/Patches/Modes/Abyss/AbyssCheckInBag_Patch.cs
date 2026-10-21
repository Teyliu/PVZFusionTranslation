#if false
using HarmonyLib;

namespace PvZ_Fusion_Translator.Patches.Modes.Abyss;

[HarmonyPatch(typeof(AbyssCheckInBag))]
public static class AbyssCheckInBag_Patch
{
    [HarmonyPatch(nameof(AbyssCheckInBag.MoveFromBag)), HarmonyPostfix]
    private static void MoveFromBag(AbyssCheckInBag __instance) => AbyssMenu2.Instance.UpdateIcons();

    [HarmonyPatch(nameof(AbyssCheckInBag.SellIcon)), HarmonyPostfix]
    private static void SellIcon(AbyssCheckInBag __instance) => AbyssMenu2.Instance.UpdateIcons();
}
#endif
