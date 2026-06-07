using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.BaseTextObjects;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(PropCard))]
    public static class PropCard_Patch
    {
        [HarmonyPatch(nameof(PropCard.Start))]
        [HarmonyPostfix]
        public static void Start(PropCard __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            if (__instance.countText != null)
            {
                __instance.countText.text = StringStore.TranslateText(__instance.countText.text);
                __instance.countText.font = fontAsset;
            }
        }
    }
}
