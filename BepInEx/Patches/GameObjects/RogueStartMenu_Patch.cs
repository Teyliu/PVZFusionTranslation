using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{

    [HarmonyPatch(typeof(RogueStartMenu))]
    public static class RogueStartMenu_Patch
    {
        [HarmonyPatch(nameof(RogueStartMenu.SetLeader))]
        [HarmonyPostfix]
        private static void SetLeader(RogueStartMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(RogueStartMenu.EnterGame))]
        [HarmonyPostfix]
        private static void EnterGame(RogueStartMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }
    }
}
