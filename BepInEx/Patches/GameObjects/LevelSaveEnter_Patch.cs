using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.BaseTextObjects;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(LevelSaveEnter))]
    public static class LevelSaveEnter_Patch
    {
        [HarmonyPatch(nameof(LevelSaveEnter.InitEnter))]
        [HarmonyPostfix]
        public static void InitEnter(LevelSaveEnter __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            if (__instance.text != null)
            {
                __instance.text.text = StringStore.TranslateText(__instance.text.text);
                __instance.text.font = fontAsset;
            }
        }
    }
}
