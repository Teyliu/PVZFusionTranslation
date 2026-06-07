using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.BaseTextObjects;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(TheCard))]
    public static class TheCard_Patch
    {
        [HarmonyPatch(nameof(TheCard.Start))]
        [HarmonyPostfix]
        public static void Start(TheCard __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            if (__instance.costText != null)
            {
                __instance.costText.text = StringStore.TranslateText(__instance.costText.text);
                __instance.costText.font = fontAsset;
            }
        }
    }
}
