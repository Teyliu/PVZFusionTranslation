using HarmonyLib;
using Il2CppTMPro;
using MelonLoader;
using PvZ_Fusion_Translator.AssetStore;
using static MelonLoader.MelonLogger;
using static PvZ_Fusion_Translator.Patches.Managers.TravelMgr_Patch;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(TravelBuffOptionButton))]
    public static class TravelBuffOptionButton_Patch
    {
        [HarmonyPatch(nameof(TravelBuffOptionButton.Awake))]
        [HarmonyPostfix]
        public static void Awake(TravelBuffOptionButton __instance)
        {
            TranslateOptionButton(__instance);
        }

        [HarmonyPatch(nameof(TravelBuffOptionButton.OnAnimOver))]
        [HarmonyPostfix]
        public static void OnAnimOver(TravelBuffOptionButton __instance)
        {
            TranslateOptionButton(__instance);
        }

        public static void TranslateOptionButton(TravelBuffOptionButton button)
        {
            SortedDictionary<int, string> buffSet = translatedTravelBuffs[buffLinks[button.buffType]];

            string buff = button.show != null && button.introduce.text != "词条已选完" ? buffSet[button.buffIndex] : StringStore.TranslateText("词条已选完");

            button.introduce.text = buff;
        }

        //List<string> buffSet = translatedTravelBuffs[buffLinks[__instance.buffType]];
        //string buff = (__instance.show != null) ? buffSet[__instance.buffIndex] : StringStore.TranslateText("无");
        //__instance.introduce.text = buff;
    }
}
