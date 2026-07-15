using Il2Cpp;
using UnityEngine;
using HarmonyLib;
using Il2CppPVPScaryPot;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Managers
{
    [HarmonyPatch(typeof(PVPScareyPot))]
    public static class PVPScareyPot_Patch
    {
        [HarmonyPatch(nameof(PVPScareyPot.Awake))]
        [HarmonyPatch(nameof(PVPScareyPot.Start))]
        [HarmonyPatch(nameof(PVPScareyPot.AutoRuleUpdate))]
        [HarmonyPatch(nameof(PVPScareyPot.RandomCardUpdate))]
        [HarmonyPatch(nameof(PVPScareyPot.Update))]
        [HarmonyPostfix]
        public static void TranslatePlayerDatas(PVPScareyPot __instance)
        {
            TranslatePlayerData(__instance.player1);
            TranslatePlayerData(__instance.player2);
            TranslatePlayerData(__instance.currentPlayer);
        }

        public static void TranslatePlayerData(PVPScareyPot.PlayerData playerData)
        {
            if(playerData != null)
            {
                playerData.textMesh.text = StringStore.TranslateText(playerData.textMesh.text);
                playerData.textMesh.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
        }
    }
}
