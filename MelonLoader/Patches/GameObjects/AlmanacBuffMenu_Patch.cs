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

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(AlmanacBuffMenu))]
    public static class AlmanacBuffMenu_Patch
    {
        public static Dictionary<string, string> modifierNameDict = new Dictionary<string, string>()
        {
            { "advancedBuffs", "COMMON_MODIFIER_TAG" },
            { "ultimateBuffs", "EPIC_MODIFIER_TAG" },
            { "debuffs", "ZOMBIE_MODIFIER_TAG" },
            { "unlocks", "UNLOCK_MODIFIER_TAG" },
            { "investmentBuffs", "INVEST_MODIFIER_TAG" }
        };

        public static Dictionary<string, string> fallbackNameDict = new Dictionary<string, string>()
        {
            { "COMMON_MODIFIER_TAG", "Common Modifier" },
            { "EPIC_MODIFIER_TAG", "Epic Modifier" },
            { "ZOMBIE_MODIFIER_TAG", "Zombie Modifier" },
            { "UNLOCK_MODIFIER_TAG", "Unlock Modifier" },
            { "INVEST_MODIFIER_TAG", "Investment Modifier" }
        };

        public static string TranslateNameTag(string originalText)
        {
            string res = originalText;

            string nameTag = modifierNameDict[originalText];
            res = StringStore.translationString.ContainsKey(nameTag) ? StringStore.TranslateText(nameTag) : fallbackNameDict[nameTag];

            return res;
        }

        [HarmonyPatch(nameof(AlmanacBuffMenu.Awake))]
        [HarmonyPostfix]
        public static void Post_Awake(AlmanacBuffMenu __instance)
        {
            foreach(AlmanacCardUI cardUI in __instance.cards)
            {
                AlmanacBuffMenu.CardInfo cardInfo = __instance.cardInfos[cardUI];
                var buffData = FindBuffData(cardInfo.description);

                if (buffData.Item1 == null || buffData.Item3 == null) continue;

                string nameTag = TranslateNameTag(buffData.Item1);
                cardUI.cost.text = $"{nameTag} #{buffData.Item2}";
            }

            Post_OnCardClick(__instance);
        }

        [HarmonyPatch(nameof(AlmanacBuffMenu.OnCardClick))]
        [HarmonyPostfix]
        public static void Post_OnCardClick(AlmanacBuffMenu __instance)
        {
            var buffData = FindBuffData(__instance.buffDescription.text);

            if (buffData.Item1 == null || buffData.Item3 == null) return;

            string nameTag = TranslateNameTag(buffData.Item1);
            __instance.buffTitle.text = $"{nameTag} #{buffData.Item2}";
            __instance.buffTitle.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            __instance.buffDescription.text = buffData.Item3 + "\n\n";
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
        }
    }
}
