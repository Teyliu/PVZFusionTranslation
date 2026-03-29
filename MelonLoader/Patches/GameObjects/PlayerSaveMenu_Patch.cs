using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator.Patches.GameObjects
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
            Transform createPlayerSaveMenuTransform = GameAPP.canvasUp.Find("CreatePlayerSaveMenu(Clone)");
            if(createPlayerSaveMenuTransform.TryGetComponent<CreatePlayerSaveMenu>(out CreatePlayerSaveMenu createPlayerSaveMenu))
            {
                createPlayerSaveMenu.title.text = StringStore.TranslateText(createPlayerSaveMenu.title.text);
            }
        }
    }
}
