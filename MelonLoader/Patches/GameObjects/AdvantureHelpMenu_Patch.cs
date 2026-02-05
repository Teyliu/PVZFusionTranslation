using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(AdvantureHelpMenu))]
    public static class AdvantureHelpMenu_Patch
    {
        [HarmonyPatch(nameof(AdvantureHelpMenu.InitText))]
        [HarmonyPostfix]
        private static void InitText(AdvantureHelpMenu __instance)
        {
            foreach(TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }
    }
}
