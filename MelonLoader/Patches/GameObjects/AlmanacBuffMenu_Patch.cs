using HarmonyLib;
using Il2Cpp;
using Il2CppAlmanacData;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using System.Drawing;
using static Il2Cpp.AlmanacBuffMenu;
using static PvZ_Fusion_Translator.FileLoader;
using static PvZ_Fusion_Translator.Patches.Modes.Odyssey.TravelMgr_Patch;
using static PvZ_Fusion_Translator.Utils;
using Unity.VisualScripting;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(AlmanacBuffMenu))]
    public static class AlmanacBuffMenu_Patch
    {
        [HarmonyPatch(nameof(AlmanacBuffMenu.Awake))]
        [HarmonyPostfix]
        public static void Post_Awake(AlmanacBuffMenu __instance)
        {
            foreach(AlmanacCardUI cardUI in __instance.cards)
            {
                AlmanacBuffMenu.CardInfo cardInfo = __instance.cardInfos[cardUI];
                var buffData = FindBuffData(cardInfo.description);

                if (buffData.Item1 == null || buffData.Item3 == null) continue;

                cardUI.cost.text = (buffData.Item4) ? buffData.Item1 : $"{buffData.Item1} #{buffData.Item2}";
            }

            Post_OnCardClick(__instance);
        }

        [HarmonyPatch(nameof(AlmanacBuffMenu.SetAllCards))]
        [HarmonyPatch(nameof(AlmanacBuffMenu.Start))]
        [HarmonyPatch(nameof(AlmanacBuffMenu.InitMenu))]
        [HarmonyPostfix]
        public static void Post_SetAllCards(AlmanacBuffMenu __instance)
        {
            foreach(AlmanacCardUI cardUI in __instance.cards)
            {
                AlmanacBuffMenu.CardInfo cardInfo = __instance.cardInfos[cardUI];
                var buffData = FindBuffData(cardInfo.description);
                if (buffData.Item1 == null || buffData.Item3 == null) continue;

                cardUI.cost.text = (buffData.Item4) ? buffData.Item1 : $"{buffData.Item1} #{buffData.Item2}";
            }

            Post_OnToolClick(__instance);

            Post_OnCardClick(__instance);
        }

        [HarmonyPatch(nameof(AlmanacBuffMenu.OnToolClick))]
        [HarmonyPostfix]
        public static void Post_OnToolClick(AlmanacBuffMenu __instance)
        {
            foreach(TextMeshProUGUI txt in __instance.toolButton.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
        }

        [HarmonyPatch(nameof(AlmanacBuffMenu.OnCardClick))]
        [HarmonyPostfix]
        public static void Post_OnCardClick(AlmanacBuffMenu __instance)
        {
            var buffData = FindBuffData(__instance.buffDescription.text);

            if (buffData.Item1 == null || buffData.Item3 == null)
            {
                return;
            }

            __instance.buffTitle.text = (buffData.Item4) ? buffData.Item1 : $"{buffData.Item1} #{buffData.Item2}";
            __instance.buffTitle.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            string buffFStr = StringStore.translationStringRegex.ContainsKey("BUFF_NAME_FORMAT") ? StringStore.translationStringRegex["BUFF_NAME_FORMAT"] : "{0}: {1}";
            string fBuffDesc = string.Format(buffFStr, buffData.Item1, buffData.Item3);
            __instance.buffDescription.text = (buffData.Item4) ? fBuffDesc + "\n\n" : buffData.Item3 + "\n\n";
            __instance.buffDescription.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            string colorHex = StringStore.translationString.ContainsKey("MOD_ALMANAC_COL") ? StringStore.TranslateText("MOD_ALMANAC_COL") : "#000000";
            System.Drawing.Color descriptionColor = ColorTranslator.FromHtml(colorHex);
            __instance.buffDescription.color = new UnityEngine.Color(descriptionColor.R / 255.0f, descriptionColor.G / 255.0f, descriptionColor.B / 255.0f);

            __instance.buffDescription.fontSizeMax = 18;
            __instance.buffDescription.margin = new Vector4(8, 4, 25, 0);

            __instance.buffDescription.enableWordWrapping = true;
            __instance.buffDescription.overflowMode = TextOverflowModes.ScrollRect;

            Canvas.ForceUpdateCanvases();
            __instance.buffDescription.ForceMeshUpdate();

            Post_OnToolClick(__instance);
        }
    }
}
