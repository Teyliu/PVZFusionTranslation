using HarmonyLib;
using System;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(TrainingDummy), nameof(TrainingDummy.UpdateHealthText))]
    public static class TrainingDummy_Patch
    {
        [HarmonyPostfix]
        public static void UpdateHealthText(TrainingDummy __instance)
        {
            Zombie_Patch.TranslateHpUI(__instance.healthText, null);
            Zombie_Patch.TranslateHpUI(__instance.healthTextShadow, null);
        }
    }
}