using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(AdvantureHelpMenu))]
    public static class AdvantureHelpMenu_Patch
    {
        [HarmonyPatch(nameof(AdvantureHelpMenu.Awake))]
        [HarmonyPostfix]
        private static void Awake(AdvantureHelpMenu __instance)
        {
            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }
    }
}
