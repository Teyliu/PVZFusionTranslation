using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(TreasureEquipmentMenu))]
    public static class TreasureEquipmentMenu_Patch
    {
        [HarmonyPatch(nameof(TreasureEquipmentMenu.Awake))]
        [HarmonyPostfix]
        private static void Awake(TreasureEquipmentMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(TreasureEquipmentMenu.UpdateCards))]
        [HarmonyPostfix]
        private static void UpdateCards(TreasureEquipmentMenu __instance)
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