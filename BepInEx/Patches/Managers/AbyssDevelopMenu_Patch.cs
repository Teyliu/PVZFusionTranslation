using HarmonyLib;

using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
    [HarmonyPatch(typeof(AbyssDevelopMenu))]
    public static class AbyssDevelopMenu_Patch
    {
        [HarmonyPatch(nameof(AbyssDevelopMenu.UpdateInfo))]
        [HarmonyPostfix]
        private static void UpdateInfo(AbyssDevelopMenu __instance)
        {
            __instance.currentMoney.text = StringStore.TranslateText(__instance.currentMoney.text);
            __instance.upgradeTextInfo.text = StringStore.TranslateText(__instance.upgradeTextInfo.text);
        }
    }
}
