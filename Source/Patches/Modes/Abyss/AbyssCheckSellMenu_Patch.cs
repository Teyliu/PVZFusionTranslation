#if false
using HarmonyLib;

namespace PvZ_Fusion_Translator.Patches.Modes.Abyss;

[HarmonyPatch(typeof(AbyssCheckSellMenu))]
public static class AbyssCheckSellMenu_Patch
{
    [HarmonyPatch(nameof(AbyssCheckSellMenu.SellIcon)), HarmonyPostfix]
    private static void SellIcon(AbyssCheckSellMenu __instance) => AbyssMenu2.Instance.UpdateIcons();

    [HarmonyPatch(nameof(AbyssCheckSellMenu.MoveInBag)), HarmonyPostfix]
    private static void MoveInBag(AbyssCheckSellMenu __instance) => AbyssMenu2.Instance.UpdateIcons();
}
#endif
