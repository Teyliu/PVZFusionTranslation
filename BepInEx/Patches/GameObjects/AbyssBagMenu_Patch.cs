using HarmonyLib;

using TMPro;

using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{

    [HarmonyPatch(typeof(AbyssBagMenu))]
    public static class AbyssBagMenu_Patch
    {
        [HarmonyPatch(nameof(AbyssBagMenu.Awake))]
        [HarmonyPostfix]
        private static void MoveFromBag(AbyssCheckInBag __instance)
        {
            AbyssMenu2.Instance.UpdateIcons();
            Utils.ConvertButtonText(__instance.transform, "Goback");
        }
    }
}
