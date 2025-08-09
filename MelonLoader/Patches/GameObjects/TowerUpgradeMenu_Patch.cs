using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(TowerUpgradeMenu))]
    public static class TowerUpgradeMenu_Patch
    {
        [HarmonyPatch(nameof(TowerUpgradeMenu.Awake))]
        [HarmonyPostfix]
        private static void Awake(TowerUpgradeMenu __instance)
        {
            __instance.des.text = StringStore.TranslateText(__instance.des.text);
            __instance.des2.text = StringStore.TranslateText(__instance.des2.text);

            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
                text.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
        }

        [HarmonyPatch(nameof(TowerUpgradeMenu.SetText))]
        [HarmonyPostfix]
        private static void SetText(TowerUpgradeMenu __instance)
        {
            __instance.des.text = StringStore.TranslateText(__instance.des.text);
            __instance.des2.text = StringStore.TranslateText(__instance.des2.text);

            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
                text.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
        }
    }
}