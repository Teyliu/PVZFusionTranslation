using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using static PvZ_Fusion_Translator__BepInEx_.Patches.Managers.TravelMgr_Patch;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
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
            if (button.introduce == null)
                return;

            string originalText = button.introduce.text;
            if (string.IsNullOrEmpty(originalText))
                return;

            string buffInfo = button.buff != null ? $"{button.buff.GetType().Name}:{button.buff}" : "null";
            string buffIndexInfo = button.refreshedbuffIndex != null ? $"{button.refreshedbuffIndex.GetType().Name}:{button.refreshedbuffIndex}" : "null";
            bool isSet = button.set;

            Log.LogInfo("==== [TravelBuffOptionButton] ====");

            if (travelBuffString.ContainsKey(originalText))
            {
                button.introduce.text = travelBuffString[originalText];
                Log.LogInfo($"[TravelBuffOptionButton] buff={buffInfo} buffIndex={buffIndexInfo} set={isSet} travelBuffString HIT: \"{originalText}\" -> \"{button.introduce.text}\"");
            }
            else if (travelBuffString.ContainsKey(RemoveBuffName(originalText)))
            {
                button.introduce.text = travelBuffString[RemoveBuffName(originalText)];
                Log.LogInfo($"[TravelBuffOptionButton] buff={buffInfo} buffIndex={buffIndexInfo} set={isSet} travelBuffString (RemoveBuffName) HIT: \"{originalText}\" -> \"{button.introduce.text}\"");
            }
            else if (Utils.CheckForUntranslatedText(originalText))
            {
                string translated = StringStore.TranslateText(originalText);
                button.introduce.text = translated;
                if (translated != originalText)
                    Log.LogInfo($"[TravelBuffOptionButton] buff={buffInfo} buffIndex={buffIndexInfo} set={isSet} TranslateText fallback HIT: \"{originalText}\" -> \"{translated}\"");
                else
                    Log.LogInfo($"[TravelBuffOptionButton] buff={buffInfo} buffIndex={buffIndexInfo} set={isSet} NO TRANSLATION: \"{originalText}\"");
            }
            else
            {
                Log.LogInfo($"[TravelBuffOptionButton] buff={buffInfo} buffIndex={buffIndexInfo} set={isSet} SKIPPED (no CJK): \"{originalText}\"");
            }
        }
    }
}