﻿using HarmonyLib;
using Il2Cpp;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(TrainingDummy), nameof(TrainingDummy.UpdateHealthText))]
    public static class TrainingDummy_Patch
    {
        [HarmonyPostfix]
        public static void UpdateHealthText(TrainingDummy __instance)
        {
            Zombie_Patch.TranslateHpUI(__instance.healthText);
            Zombie_Patch.TranslateHpUI(__instance.healthTextShadow);
        }
    }
}