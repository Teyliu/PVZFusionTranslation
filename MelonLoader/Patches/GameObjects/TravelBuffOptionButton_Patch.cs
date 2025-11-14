using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
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
            __instance.introduce.text = translatedTravelBuffs[buffLinks[__instance.buffType]][__instance.buffIndex];
        }

        [HarmonyPatch(nameof(TravelBuffOptionButton.Awake))]
        [HarmonyPostfix]
        private static void Awake(TravelBuffOptionButton __instance)
        {
            __instance.introduce.text = translatedTravelBuffs[buffLinks[__instance.buffType]][__instance.buffIndex];
        }

        [HarmonyPatch(nameof(TravelBuffOptionButton.OnAnimOver))]
        [HarmonyPostfix]
        private static void OnAnimOver(TravelBuffOptionButton __instance)
        {
            __instance.introduce.text = translatedTravelBuffs[buffLinks[__instance.buffType]][__instance.buffIndex];
        }

        [HarmonyPatch(nameof(TravelBuffOptionButton.SetBackground))]
        [HarmonyPostfix]
        private static void SetBackground(TravelBuffOptionButton __instance)
        {
            __instance.introduce.text = translatedTravelBuffs[buffLinks[__instance.buffType]][__instance.buffIndex];
        }
    }
}
