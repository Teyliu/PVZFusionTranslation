using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using System.Text.RegularExpressions;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(ConfirmMenu))]
    public static class ConfirmMenu_Patch
    {
        [HarmonyPatch(nameof(ConfirmMenu.SetTitle))]
        [HarmonyPostfix]
        private static void SetTitle(ConfirmMenu __instance)
        {
            foreach(TextMeshProUGUI title in __instance.title)
            {
                title.text = StringStore.TranslateText(title.text);
                title.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
        }
    }
}
