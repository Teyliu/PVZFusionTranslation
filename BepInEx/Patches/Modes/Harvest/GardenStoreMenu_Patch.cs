using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using TMPro;
using ZenGarden;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Modes.Harvest
{
    [HarmonyPatch(typeof(GardenStoreMenu))]
    public static class GardenStoreMenu_Patch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        private static void Start(GardenStoreMenu __instance)
        {
            TranslateText(__instance.coinCount);

            foreach (GardenShopSlot slot in __instance.GetComponentsInChildren<GardenShopSlot>(true))
            {
                GardenShopSlot_Patch.TranslateTitle(slot);
            }
        }

        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        private static void Update(GardenStoreMenu __instance)
        {
            TranslateText(__instance.coinCount);
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
