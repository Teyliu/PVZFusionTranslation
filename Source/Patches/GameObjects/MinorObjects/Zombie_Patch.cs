using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects;

[HarmonyPatch(typeof(Zombie))]
public static class Zombie_Patch
{
    private static readonly Dictionary<string, string> s_hpStrings = new()
    {
        { "最后一击：(\\d+)\nDPS：([^\\s]+)\n总伤害：(\\d+)", "Last Damage: {0}\nDPS: {1}\nTotal: {2}" },
        {
            "^HP：(\\d+)/(\\d+)\n一类：(\\d+)/(\\d+)\n二类：(\\d+)/(\\d+)$",
            "HP: {0}/{1}\nT1 armor: {2}/{3}\nT2 armor: {4}/{5}"
        },
        { "^HP：(\\d+)/(\\d+)\n一类：(\\d+)/(\\d+)$", "HP: {0}/{1}\nT1 armor: {2}/{3}" },
        { "^HP：(\\d+)/(\\d+)\n二类：(\\d+)/(\\d+)$", "HP: {0}/{1}\nT2 armor: {2}/{3}" },
        { @"^HP：(\d+)/(\d+)$", "HP: {0}/{1}" },
    };

    public static void LoadHpStrings()
    {
        foreach (var hp in s_hpStrings)
            if (StringStore.TranslationStringRegex.TryGetValue(hp.Key, out var value))
                s_hpStrings[hp.Key] = value;
    }

    [HarmonyPatch(nameof(Zombie.Start)), HarmonyPostfix]
    public static void Start(Zombie __instance)
    {
        TranslateHpUI(__instance.healthText, __instance);
        //TranslateHpUI(__instance.healthTextShadow, __instance);

        if (__instance.healthText.transform.rotation != Quaternion.Euler(0, 0, 0))
            __instance.healthText.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }

    [HarmonyPatch(nameof(Zombie.UpdateHealthText)), HarmonyPostfix]
    public static void Update(Zombie __instance)
    {
        if (__instance.theZombieType == ZombieType.TrainingDummy || !Board.Instance.showZombieHealth)
            return;

        if (__instance.healthText == null)
            return;

        TranslateHpUI(__instance.healthText, __instance);
        //TranslateHpUI(__instance.healthTextShadow, __instance);

        if (__instance.healthText.transform.rotation != Quaternion.Euler(0f, 0f, 0f))
            __instance.healthText.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }

    public static void TranslateHpUI(TextMeshPro textTMP, Zombie __instance)
    {
        if (!textTMP)
            return;

        var origText = textTMP.text;
        var translatedText = origText;

        if (translatedText == null)
            return;

        const string Pattern = "(\\d+)阶\n([\\s\\S]+)";

        if (StringStore.TestRegex(translatedText, Pattern))
        {
            var match = Regex.Match(translatedText, Pattern, RegexOptions.Singleline);
            var tier = match.Groups[1].Value;
            var healthText = TranslateHpText(match.Groups[2].Value, __instance);
            var fStr = StringStore.TranslationStringRegex[Pattern];
            translatedText = string.Format(fStr, [tier, healthText]);
        }
        else
            translatedText = TranslateHpText(origText, __instance);

        textTMP.text = translatedText == origText ? origText : translatedText;
        textTMP.autoSizeTextContainer = false;

        if (translatedText != origText)
            textTMP.font = FontStore.LoadTMPFont(Utils.Language.ToString());
    }

    public static void TranslateHpUI_T(TextMeshPro textTMP, TrainingDummy __instance)
    {
        if (!textTMP)
            return;

        var origText = textTMP.text;
        var translatedText = TranslateHPText_T(origText, __instance);
        textTMP.text = translatedText == origText ? origText : translatedText;
        textTMP.autoSizeTextContainer = false;

        if (translatedText != origText)
            textTMP.font = FontStore.LoadTMPFont(Utils.Language.ToString());
    }

    public static string TranslateHpText(string originalText, Zombie __instance)
    {
        if (originalText == null)
            return null;

        var finalText = __instance.healthText.text;
        var fIndex = -1;
        var found = false;

        for (var i = 0; i < s_hpStrings.Count; i++)
        {
            var hp = s_hpStrings.ElementAt(i);

            if (!Regex.Match(originalText, hp.Key, RegexOptions.Singleline).Success)
                continue;

            fIndex = i;
            found = true;
        }

        if (fIndex <= -1 || !found)
            return finalText;

        var fStr = s_hpStrings.ElementAt(fIndex).Value;

        return fIndex switch
        {
            1 => string.Format(
                fStr,
                __instance.theHealth,
                __instance.theMaxHealth,
                __instance.theFirstArmorHealth,
                __instance.theFirstArmorMaxHealth,
                __instance.theSecondArmorHealth,
                __instance.theSecondArmorMaxHealth
            ),
            2 => string.Format(
                fStr,
                __instance.theHealth,
                __instance.theMaxHealth,
                __instance.theFirstArmorHealth,
                __instance.theFirstArmorMaxHealth
            ),
            3 => string.Format(
                fStr,
                __instance.theHealth,
                __instance.theMaxHealth,
                __instance.theSecondArmorHealth,
                __instance.theSecondArmorMaxHealth
            ),
            4 => string.Format(fStr, __instance.theHealth, __instance.theMaxHealth),
            _ => finalText,
        };
    }

    public static string TranslateHPText_T(string originalText, TrainingDummy __instance)
    {
        var finalText = __instance.healthText.text;
        var fIndex = -1;
        var found = false;

        for (var i = 0; i < s_hpStrings.Count; i++)
        {
            var hp = s_hpStrings.ElementAt(i);
            var regex = new Regex(hp.Key);

            if (!regex.IsMatch(originalText))
                continue;

            fIndex = i;
            found = true;
        }

        if (fIndex <= -1 || !found)
            return finalText;

        var fStr = s_hpStrings.ElementAt(fIndex).Value;

        return fIndex switch
        {
            0 => string.Format(fStr, __instance.lastDamage, __instance.CurrentDPS, __instance.totalDamage),
            _ => finalText,
        };
    }
}
