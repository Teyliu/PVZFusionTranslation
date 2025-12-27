using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(PlantDamageMenu))]
    public static class PlantDamageMenu_Patch
    {
        [HarmonyPatch(nameof(PlantDamageMenu.Awake))]
        [HarmonyPostfix]
        private static void Awake(PlantDamageMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
            foreach(TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
                text.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(PlantDamageMenu.InitCards))]
        [HarmonyPostfix]
        private static void InitCards(PlantDamageMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
                text.font = fontAsset;
            }
        }
    }
}
