using HarmonyLib;
using Il2CppGameLevel;
using Il2Cpp;
using UnityEngine;
using Il2CppGameLevel.RogueShooting;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey
{
    [HarmonyPatch(typeof(ShootingManager))]
    public static class ShootingManager_Patch
    {
        [HarmonyPatch(nameof(ShootingManager.UpgradeBuff))]
        [HarmonyPostfix]
        public static void UpgradeBuff(ShootingManager __instance, ref MultipleChoiceMenu menu)
        {
            MultipleChoiceMenu_Patch.Awake(menu);
        }
    }
}
