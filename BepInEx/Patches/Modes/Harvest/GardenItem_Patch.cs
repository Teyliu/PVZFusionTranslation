using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using TMPro;
using ZenGarden;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Modes.Harvest
{
    [HarmonyPatch(typeof(GardenItem))]
    public static class GardenItem_Patch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        private static void Update(GardenItem __instance)
        {
            TranslateText(__instance.countTextMesh);
        }

        private static void TranslateText(TextMeshProUGUI text)
        {
            if (text == null) return;

            if (!string.IsNullOrEmpty(text.text))
            {
                text.text = StringStore.TranslateText(text.text);
            }

            text.font = FontStore.LoadTMPFont(Utils.Language.ToString());
        }
    }
}
