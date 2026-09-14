using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using TMPro;
using ZenGarden;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Modes.Harvest
{
    [HarmonyPatch(typeof(GardenShopSlot))]
    public static class GardenShopSlot_Patch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Start(GardenShopSlot __instance)
        {
            TranslateTitle(__instance);
        }

        [HarmonyPatch("set_CurrentHas")]
        [HarmonyPostfix]
        private static void SetCurrentHas(GardenShopSlot __instance)
        {
            TranslateTitle(__instance);
        }

        internal static void TranslateTitle(GardenShopSlot slot)
        {
            TextMeshProUGUI title = slot == null ? null : slot.title;
            if (title == null) return;

            if (!string.IsNullOrEmpty(title.text))
            {
                title.text = StringStore.TranslateText(title.text);
            }

            title.font = FontStore.LoadTMPFont(Utils.Language.ToString());
        }
    }
}
