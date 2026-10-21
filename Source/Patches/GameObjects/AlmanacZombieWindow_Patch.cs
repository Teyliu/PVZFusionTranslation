using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(AlmanacZombieWindow))]
public static class AlmanacZombieWindow_Patch
{
    [HarmonyPatch(nameof(AlmanacZombieWindow.UpdateText)), HarmonyPostfix]
    private static void UpdateText(AlmanacZombieWindow __instance)
    {
        var currentLanguage = Utils.Language.ToString();
        // var almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
        // var path = Path.Combine(almanacDir, "ZombieStringsTranslate.json");
        var hasAlmanacFont = false;

        if (FontStore.FontAssetDictSecondary.ContainsKey((currentLanguage + "_almanac").ToLower()) ||
            FontStore.FontAssetDictSecondary.ContainsKey(currentLanguage.ToLower()))
        {
            _ = FontStore.LoadTMPFontAlmanac(currentLanguage);
            hasAlmanacFont = true;
        }

        var fontAsset = hasAlmanacFont
            ? FontStore.LoadTMPFontAlmanac(Utils.Language.ToString())
            : FontStore.LoadTMPFont(Utils.Language.ToString());

        var zombieAlmanacData = JsonUtility.FromJson<Il2CppAlmanacDataClass>(AlmanacZombieMenu_Patch.AlmanacJson);
        var zombieDataDic = ZombieDataManager.zombieDataDic;

        foreach (var zombieInfo in zombieAlmanacData.zombies)
            if (zombieInfo.theZombieType == __instance.currentZombieType)
            {
                foreach (var text in __instance.showedZombieName)
                {
                    text.autoSizeTextContainer = false;
                    text.text = $"{Utils.RemoveSizeTags(zombieInfo.name)} ({(int)zombieInfo.theZombieType})";
                    text.font = fontAsset;
                    text.fontSizeMax = 21;
                }

                var zombieData = zombieDataDic[__instance.currentZombieType];

                var spawnInfo = "";

                var spawnInfoFormat =
                    StringStore.TranslationStringRegex.GetValueOrDefault("出怪等级: (\\d+)\n出怪权重: (\\d+)");

                if (spawnInfoFormat != null)
                    spawnInfo = string.Format(spawnInfoFormat, [zombieData.summonLevel, zombieData.summonWeight]) +
                        "\n\n";

                __instance.showedZombieIntroduce.text =
                    $"""
                     {Utils.RemoveSizeTags(zombieInfo.info)}

                     {spawnInfo}{Utils.RemoveSizeTags(zombieInfo.introduce)}


                     """;

                __instance.showedZombieIntroduce.font = fontAsset;
                __instance.showedZombieIntroduce.fontSizeMax = 21;
                __instance.showedZombieIntroduce.margin = new(3, 2, 12, 0);

                __instance.showedZombieIntroduce.enableWordWrapping = true;
                __instance.showedZombieIntroduce.overflowMode = TextOverflowModes.ScrollRect;

                Canvas.ForceUpdateCanvases();
                __instance.showedZombieIntroduce.ForceMeshUpdate();

                var textHeight = __instance.showedZombieIntroduce.preferredHeight;

                __instance.zombieTextContent.sizeDelta = new(
                    __instance.zombieTextContent.sizeDelta.x,
                    textHeight
                );
            }
    }
}
