using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
    [HarmonyPatch(typeof(Garden))]
    public static class Garden_Patch
    {
        [HarmonyPatch(nameof(Garden.Awake))]
        [HarmonyPostfix]
        private static void Awake(Garden __instance)
        {
            foreach (TextMeshPro text in __instance.GetComponentsInChildren<TextMeshPro>())
            {
                text.text = StringStore.TranslateText(text.text);
                text.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
        }
    }
}
