using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using MelonLoader;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;
using static MelonLoader.MelonLogger;

namespace PvZ_Fusion_Translator.Patches.GameObjects
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
