using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.BaseTextObjects;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(ReNameMenu))]
    public static class ReNameMenu_Patch
    {
        [HarmonyPatch(nameof(ReNameMenu.SetTitle))]
        [HarmonyPostfix]
        public static void SetTitle(ReNameMenu __instance, string text)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            if (__instance.title != null)
            {
                __instance.title.text = StringStore.TranslateText(text);
                __instance.title.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(ReNameMenu.SetInputText))]
        [HarmonyPostfix]
        public static void SetInputText(ReNameMenu __instance, string text)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            if (__instance.input != null)
            {
                __instance.input.text = StringStore.TranslateText(text);
            }
        }
    }
}
