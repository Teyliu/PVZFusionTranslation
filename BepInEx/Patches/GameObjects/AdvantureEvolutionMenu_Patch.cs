using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(AdvantureEvolutionMenu))]
    public static class AdvantureEvolutionMenu_Patch
    {
        [HarmonyPatch(nameof(AdvantureEvolutionMenu.Awake))]
        [HarmonyPostfix]
        private static void Awake(AdvantureEvolutionMenu __instance)
        {
            foreach(TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }
    }
}
