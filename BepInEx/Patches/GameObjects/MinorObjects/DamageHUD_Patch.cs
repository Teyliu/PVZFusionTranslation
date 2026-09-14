using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using TMPro;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(DamageHUD))]
    public static class DamageHUD_Patch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        private static void Update(DamageHUD __instance)
        {
            TranslateText(__instance.text);
        }

        private static void TranslateText(TextMeshProUGUI text)
        {
            if (text == null || string.IsNullOrEmpty(text.text)) return;

            text.text = StringStore.TranslateText(text.text);
            text.font = FontStore.LoadTMPFont(Utils.Language.ToString());
        }
    }
}
