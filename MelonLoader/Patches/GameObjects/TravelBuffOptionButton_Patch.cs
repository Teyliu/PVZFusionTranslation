using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using MelonLoader;
using PvZ_Fusion_Translator.AssetStore;
using static PvZ_Fusion_Translator.Patches.Managers.TravelMgr_Patch;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(TravelBuffOptionButton))]
    public static class TravelBuffOptionButton_Patch
    {
        [HarmonyPatch(nameof(TravelBuffOptionButton.SetBuff))]
        [HarmonyPostfix]
        private static void SetBuff(TravelBuffOptionButton __instance)
        {
            List<string> buffSet = translatedTravelBuffs[buffLinks[__instance.buffType]];
            string buffText = (__instance.buffIndex < buffSet.Count && __instance.show != null) ? buffSet[__instance.buffIndex] : StringStore.TranslateText(__instance.introduce.text);
            __instance.introduce.text = buffText;
        }

        [HarmonyPatch(nameof(TravelBuffOptionButton.Awake))]
        [HarmonyPostfix]
        private static void Awake(TravelBuffOptionButton __instance)
        {
            List<string> buffSet = translatedTravelBuffs[buffLinks[__instance.buffType]];
            string buffText = (__instance.buffIndex < buffSet.Count && __instance.show != null) ? buffSet[__instance.buffIndex] : StringStore.TranslateText(__instance.introduce.text);
            __instance.introduce.text = buffText;
        }

        [HarmonyPatch(nameof(TravelBuffOptionButton.OnAnimOver))]
        [HarmonyPostfix]
        private static void OnAnimOver(TravelBuffOptionButton __instance)
        {
            List<string> buffSet = translatedTravelBuffs[buffLinks[__instance.buffType]];
            string buffText = (__instance.buffIndex < buffSet.Count && __instance.show != null) ? buffSet[__instance.buffIndex] : StringStore.TranslateText(__instance.introduce.text);
            __instance.introduce.text = buffText;
        }
    }
}
