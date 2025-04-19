using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Managers
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
