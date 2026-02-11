using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Modes.Harvest
{
    [HarmonyPatch(typeof(TreasureConfirmMenu))]
    public static class TreasureConfirmMenu_Patch
    {
        [HarmonyPatch(nameof(TreasureConfirmMenu.SetText))]
        [HarmonyPostfix]
        private static void SetText(TreasureConfirmMenu __instance)
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