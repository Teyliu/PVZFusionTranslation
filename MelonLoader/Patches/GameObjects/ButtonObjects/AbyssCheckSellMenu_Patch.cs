using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects
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