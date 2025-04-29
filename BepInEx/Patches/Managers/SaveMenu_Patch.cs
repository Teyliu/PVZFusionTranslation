using HarmonyLib;

using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
    [HarmonyPatch(typeof(SaveMenu))]
    public static class SaveMenu_Patch
    {
        [HarmonyPatch(nameof(SaveMenu.Start))]
        [HarmonyPostfix]
        private static void Start(SaveMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            __instance.title.text = StringStore.TranslateText(__instance.title.text);
            __instance.title.font = fontAsset;
            __instance.title_shadow.text = StringStore.TranslateText(__instance.title_shadow.text);
            __instance.title_shadow.font = fontAsset;

            foreach(SaveMenuBtn level in __instance.levels)
            {
                level.theName.text = StringStore.TranslateText(level.theName.text);
            }
        }
    }
}
