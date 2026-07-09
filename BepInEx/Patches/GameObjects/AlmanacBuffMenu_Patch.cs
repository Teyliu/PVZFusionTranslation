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
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }

            // Translate buff card titles using TravelMgr buff data
            foreach (AlmanacCardUI cardUI in __instance.cards)
            {
                AlmanacBuffMenu.CardInfo cardInfo = __instance.cardInfos[cardUI];
                if (cardInfo == null) continue;

                string translatedTitle = TravelMgr_Patch.TranslateTravelText(cardInfo.description);
                if (!string.IsNullOrEmpty(translatedTitle) && translatedTitle != cardInfo.description)
                {
                    cardUI.cost.text = translatedTitle;
                    cardUI.cost.font = fontAsset;
                }
            }
        }

        [HarmonyPatch(nameof(AlmanacBuffMenu.OnCardClick))]
        [HarmonyPostfix]
        public static void Post_OnCardClick(AlmanacBuffMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            string translatedTitle = TravelMgr_Patch.TranslateTravelText(__instance.buffDescription.text);
            if (!string.IsNullOrEmpty(translatedTitle) && translatedTitle != __instance.buffDescription.text)
            {
                __instance.buffTitle.text = translatedTitle;
                __instance.buffTitle.font = fontAsset;
            }

            __instance.buffDescription.text = StringStore.TranslateText(__instance.buffDescription.text) + "\n\n";
            __instance.buffDescription.font = fontAsset;
        }
    }
}
