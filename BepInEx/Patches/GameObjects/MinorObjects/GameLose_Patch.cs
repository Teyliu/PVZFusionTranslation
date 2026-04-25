using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using PvZ_Fusion_Translator__BepInEx_.Patches.BaseTextObjects;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(GameLose))]
    public static class GameLose_Patch
    {
        [HarmonyPatch(nameof(GameLose.UpdateSecondChanceTimer))]
        public static void UpdateSecondChanceTimer(GameLose __instance)
        {
            if (InGameText.Instance == null) return;

            if (InGameText.Instance.timer < 0) return;

            InGameText_Patch.TranslateInGameText(InGameText.Instance);
        }
    }
}