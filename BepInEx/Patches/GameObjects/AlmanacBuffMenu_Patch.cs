using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(AlmanacBuffMenu))]
    public static class AlmanacBuffMenu_Patch
    {
        [HarmonyPatch(nameof(AlmanacBuffMenu.Awake))]
        [HarmonyPostfix]
        public static void Post_Awake(AlmanacBuffMenu __instance)
        {
            TranslateExistingText(__instance);
        }

        [HarmonyPatch(nameof(AlmanacBuffMenu.InitMenu))]
        [HarmonyPostfix]
        public static void Post_InitMenu(AlmanacBuffMenu __instance)
        {
            TranslateCardTitles(__instance);
        }

        [HarmonyPatch(nameof(AlmanacBuffMenu.Start))]
        [HarmonyPostfix]
        public static void Post_Start(AlmanacBuffMenu __instance)
        {
            TranslateCardTitles(__instance);
        }

        [HarmonyPatch(nameof(AlmanacBuffMenu.OnCardClick))]
        [HarmonyPostfix]
        public static void Post_OnCardClick(AlmanacBuffMenu __instance)
        {
            if (__instance.buffDescription == null) return;

            TravelMgr_Patch.EnsureRuntimeTravelBuffsDumped();
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            string descText = __instance.buffDescription.text;
            string translatedDesc = TravelMgr_Patch.TranslateTravelText(descText);

            if (translatedDesc != descText)
            {
                __instance.buffDescription.text = translatedDesc;
                __instance.buffDescription.font = fontAsset;
            }

            string categoryKey = TravelMgr_Patch.FindBuffCategoryKey(descText, out int index);
            if (categoryKey == null)
                categoryKey = TravelMgr_Patch.FindBuffCategoryKey(translatedDesc, out index);

            if (categoryKey != null)
            {
                string nameTag = TravelMgr_Patch.TranslateNameTag(categoryKey);
                string buffFStr = StringStore.translationStringRegex.TryGetValue("BUFF_NAME_FORMAT", out string fmt)
                    ? fmt : TravelMgr_Patch.fallbackFBuffStr;

                __instance.buffTitle.text = $"{nameTag} #{index}";
                __instance.buffTitle.font = fontAsset;
                __instance.buffDescription.text = string.Format(buffFStr, $"{nameTag} #{index}", __instance.buffDescription.text);
                __instance.buffDescription.font = fontAsset;
            }

            Post_OnToolClick(__instance);
        }

        [HarmonyPatch(nameof(AlmanacBuffMenu.OnToolClick))]
        [HarmonyPostfix]
        public static void Post_OnToolClick(AlmanacBuffMenu __instance)
        {
            if (__instance.toolButton == null) return;
            foreach (TextMeshProUGUI txt in __instance.toolButton.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
        }

        private static void TranslateExistingText(AlmanacBuffMenu instance)
        {
            if (instance == null) return;
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
            foreach (TextMeshProUGUI txt in instance.GetComponentsInChildren<TextMeshProUGUI>(true))
            {
                if (txt == null || string.IsNullOrEmpty(txt.text)) continue;
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
        }

        private static void TranslateCardTitles(AlmanacBuffMenu instance)
        {
            if (instance == null) return;
            if (instance.cardInfos == null || instance.cards == null) return;

            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
            foreach (AlmanacCardUI cardUI in instance.cards)
            {
                if (cardUI == null) continue;
                AlmanacBuffMenu.CardInfo cardInfo;
                try { cardInfo = instance.cardInfos[cardUI]; }
                catch { continue; }

                string original = cardInfo.description;
                if (string.IsNullOrEmpty(original)) continue;
                string translated = TravelMgr_Patch.TranslateTravelText(original);
                if (translated != original && cardUI.cost != null)
                {
                    cardUI.cost.text = translated;
                    cardUI.cost.font = fontAsset;
                }
            }
        }
    }
}
