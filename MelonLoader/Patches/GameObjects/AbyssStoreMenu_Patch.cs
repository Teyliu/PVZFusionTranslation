using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects
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
