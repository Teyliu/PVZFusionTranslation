using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using static PvZ_Fusion_Translator__BepInEx_.Patches.Managers.TravelMgr_Patch;
using TravelMgr_Patch = PvZ_Fusion_Translator__BepInEx_.Patches.Managers.TravelMgr_Patch;
using TMPro;

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
            if (button == null) return;

            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            if (button.introduce != null)
            {
                string text = button.introduce.text;
                if (TravelMgr_Patch.travelBuffString.TryGetValue(text, out string tb))
                {
                    button.introduce.text = TravelMgr_Patch.AddBuffName(tb);
                }
                else if (TravelMgr_Patch.TryGetTranslatedBuff(button.buff, out string translatedBuff))
                {
                    button.introduce.text = TravelMgr_Patch.AddBuffName(translatedBuff);
                }
                else if (Utils.CheckForUntranslatedText(text))
                {
                    button.introduce.text = TravelMgr_Patch.AddBuffName(StringStore.TranslateText(text));
                }
                else
                {
                    button.introduce.text = TravelMgr_Patch.AddBuffName(text);
                }
            }

            foreach (TextMeshProUGUI text in button.GetComponentsInChildren<TextMeshProUGUI>())
            {
                if (text == null || string.IsNullOrEmpty(text.text)) continue;
                string translated = TravelMgr_Patch.TranslateTravelText(text.text);
                text.text = translated;
                text.font = fontAsset;
            }
        }
    }
}