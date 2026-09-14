using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(PlayerSaveMenu))]
    public static class PlayerSaveMenu_Patch
    {
        [HarmonyPatch(nameof(PlayerSaveMenu.CreatePlayerData))]
        [HarmonyPostfix]
        public static void CreatePlayerData(PlayerSaveMenu __instance)
        {
            TranslateCreatePlayerSaveMenu();
        }

        [HarmonyPatch(nameof(PlayerSaveMenu.ResetName))]
        [HarmonyPostfix]
        public static void ResetName(PlayerSaveMenu __instance)
        {
            TranslateCreatePlayerSaveMenu();
        }

        public static void TranslateCreatePlayerSaveMenu()
        {
            Transform createPlayerSaveMenuTransform = GameAPP.canvasUp.Find("ReNameMenu(Clone)");
            if(createPlayerSaveMenuTransform.TryGetComponent<ReNameMenu>(out ReNameMenu reNameMenu))
            {
                reNameMenu.title.text = StringStore.TranslateText(reNameMenu.title.text);
            }
        }
    }
}
