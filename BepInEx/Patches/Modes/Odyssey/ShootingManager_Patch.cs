using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using GameLevel.RogueShooting;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Modes.Odyssey
{
    [HarmonyPatch(typeof(ShootingManager))]
    public static class ShootingManager_Patch
    {
        [HarmonyPatch(nameof(ShootingManager.RegisterCoreBuff))]
        [HarmonyPatch(nameof(ShootingManager.RegisterExpertBuff))]
        [HarmonyPatch(nameof(ShootingManager.RegisterOtherBuff))]
        [HarmonyPostfix]
        public static void UpgradeBuff(ShootingManager __instance, MultipleChoiceMenu menu)
        {
            MultipleChoiceMenu_Patch.Awake(menu);
        }

        [HarmonyPatch(nameof(ShootingManager.RegisterGetPlantBuff))]
        [HarmonyPostfix]
        public static void UpgradeBuff_GetPlant(ShootingManager __instance, MultipleChoiceMenu baseMenu)
        {
            MultipleChoiceMenu_Patch.Awake(baseMenu);
        }
    }
}
