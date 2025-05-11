using HarmonyLib;

using TMPro;

using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{

    [HarmonyPatch(typeof(AbyssCheckInBag))]
    public static class AbyssCheckInBag_Patch
    {
        [HarmonyPatch(nameof(AbyssCheckInBag.MoveFromBag))]
        [HarmonyPostfix]
        private static void MoveFromBag(AbyssCheckInBag __instance)
        {
            AbyssMenu2.Instance.UpdateIcons();
        }

        [HarmonyPatch(nameof(AbyssCheckInBag.SellIcon))]
        [HarmonyPostfix]
        private static void SellIcon(AbyssCheckInBag __instance)
        {
            AbyssMenu2.Instance.UpdateIcons();
        }
    }
}
