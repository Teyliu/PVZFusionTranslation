using HarmonyLib;

using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(AbyssStoreMenu))]
    public static class AbyssStoreMenu_Patch
    {
        [HarmonyPatch(nameof(AbyssStoreMenu.Update))]
        [HarmonyPostfix]
        private static void UpdateInfo(AbyssStoreMenu __instance)
        {
            __instance.yourMoney.text = StringStore.TranslateText(__instance.yourMoney.text);
        }
    }
}
