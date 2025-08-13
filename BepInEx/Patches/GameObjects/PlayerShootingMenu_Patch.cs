using HarmonyLib;
using TMPro;
using BepInEx.Unity.IL2CPP;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(PlayerShootingMenu))]
    public static class PlayerShootingMenu_Patch
    {
        [HarmonyPatch(nameof(PlayerShootingMenu.Update))]
        [HarmonyPostfix]
        private static void Update(PlayerShootingMenu __instance)
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