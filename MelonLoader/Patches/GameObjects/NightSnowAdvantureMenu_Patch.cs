using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(NightSnowAdvantureMenu))]
    public static class NightSnowAdvantureMenu_Patch
    {
        [HarmonyPatch(nameof(NightSnowAdvantureMenu.Awake))]
        [HarmonyPatch(nameof(NightSnowAdvantureMenu.InitLevels))]
        [HarmonyPostfix]
        public static void TranslateNightSnowMenu(NightSnowAdvantureMenu __instance)
        {
            TMP_FontAsset font = FontStore.LoadTMPFont(Utils.Language.ToString());
            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = font;
            }
        }
    }
}
