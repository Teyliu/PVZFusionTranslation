using HarmonyLib;

using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.ButtonObjects
{
    [HarmonyPatch(typeof(AbyssCheckSellMenu))]
    public static class AbyssCheckSellMenu_Patch
    {
        [HarmonyPatch(nameof(AbyssCheckSellMenu.SellIcon))]
        [HarmonyPostfix]
        private static void SellIcon(AbyssCheckSellMenu __instance)
        {
            AbyssMenu2.Instance.UpdateIcons();
        }

        [HarmonyPatch(nameof(AbyssCheckSellMenu.MoveInBag))]
        [HarmonyPostfix]
        private static void MoveInBag(AbyssCheckSellMenu __instance)
        {
            AbyssMenu2.Instance.UpdateIcons();
        }
    }
}