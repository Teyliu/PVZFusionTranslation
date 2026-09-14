using GameLevel.Abyss;
using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Modes.Abyss
{
    [HarmonyPatch(typeof(AbyssStorageMenu))]
    public static class AbyssStorageMenu_Patch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Start(AbyssStorageMenu __instance)
        {
            TranslateMenuText(__instance);
        }

        [HarmonyPatch("UpdateReinforceText")]
        [HarmonyPostfix]
        private static void UpdateReinforceText(AbyssStorageMenu __instance)
        {
            TranslateMenuText(__instance);
        }

        private static void TranslateMenuText(AbyssStorageMenu menu)
        {
            if (menu == null)
            {
                return;
            }

            TMP_FontAsset font = FontStore.LoadTMPFont(Utils.Language.ToString());
            TranslateText(menu.ticketText, font);
            TranslateText(menu.tips, font);
            TranslateText(menu.healthInfo, font);
            TranslateText(menu.speedInfo, font);
            TranslateText(menu.damageInfo, font);
        }

        private static void TranslateText(TextMeshProUGUI text, TMP_FontAsset font)
        {
            if (text == null)
            {
                return;
            }

            if (!string.IsNullOrEmpty(text.text))
            {
                text.text = StringStore.TranslateText(text.text);
            }

            text.font = font;
        }
    }
}
