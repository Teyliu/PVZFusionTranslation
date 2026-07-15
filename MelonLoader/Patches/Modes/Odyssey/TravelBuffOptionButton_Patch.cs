using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using MelonLoader;
using PvZ_Fusion_Translator.AssetStore;
using static MelonLoader.MelonLogger;
using static PvZ_Fusion_Translator.Patches.Modes.Odyssey.TravelMgr_Patch;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey
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
            if(TravelMgr_Patch.travelBuffString.ContainsKey(button.introduce.text))
            {
                string translatedBuff = travelBuffString[button.introduce.text];
                button.introduce.text = AddBuffName(translatedBuff);
            }

            if(!Utils.CheckForUntranslatedText(button.introduce.text))
            {
                button.introduce.text = AddBuffName(button.introduce.text);
            }

            if(!TravelMgr_Patch.travelBuffString.ContainsKey(button.introduce.text) && Utils.CheckForUntranslatedText(button.introduce.text))
            {
                button.introduce.text = StringStore.TranslateText(button.introduce.text);
            }
        }
    }

    //List<string> buffSet = translatedTravelBuffs[buffLinks[__instance.buffType]];
    //string buff = (__instance.show != null) ? buffSet[__instance.buffIndex] : StringStore.TranslateText("无");
    //__instance.introduce.text = buff;
}
