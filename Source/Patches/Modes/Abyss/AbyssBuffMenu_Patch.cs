#if false
using System.Text.Json;
using System.Text.RegularExpressions;
using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Abyss;

[HarmonyPatch(typeof(AbyssBuffMenu))]
public static class AbyssBuffMenu_Patch
{
#pragma warning disable CA2211
    public static Dictionary<string, string> AbyssBuffData = new();
#pragma warning restore CA2211
    [HarmonyPatch(nameof(AbyssBuffMenu.Awake)), HarmonyPostfix]
    public static void Post_Awake(AbyssBuffMenu __instance)
    {
        LoadAbyssBuffData();
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            text.text = StringStore.TranslateText(text.text);
            text.font = fontAsset;
        }

        TranslateWindows(__instance, fontAsset);
    }

    [HarmonyPatch(nameof(AbyssBuffMenu.SelectWindow)), HarmonyPostfix]
    public static void Post_SelectWindow(AbyssBuffMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        TranslateWindows(__instance, fontAsset);
    }

    [HarmonyPatch(nameof(AbyssBuffMenu.SetFavorite)), HarmonyPostfix]
    public static void Post_SetFavorite(AbyssBuffMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            text.text = StringStore.TranslateText(text.text);
            text.font = fontAsset;
        }
    }

    public static void TranslateWindows(AbyssBuffMenu __instance, TMP_FontAsset fontAsset)
    {
        foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            if (AbyssBuffData.TryGetValue(text.text, out var value))
                text.text = value;
            else
            {
                var translatedRegex = TranslateAbyssBuffRegex(text.text);

                if (translatedRegex != null)
                    text.text = translatedRegex;
            }

            text.font = fontAsset;
        }
    }

    public static void LoadAbyssBuffData()
    {
        AbyssBuffData.Clear();

        var abyssBuffText = "{}";

        if (!Core.Instance.ConfigUseLocal.Value)
        {
            var abyssBuffsContent = Utils.GetDataFromWeb(
                    $"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language}/Strings/abyss_buffs.json"
                )
               .Result;

            if (abyssBuffsContent != null)
                abyssBuffText = abyssBuffsContent;
            else
            {
                var abyssBuffsPath = Path.Combine(
                    GetAssetDir(FileLoader.AssetType.Strings, Utils.Language),
                    "abyss_buffs.json"
                );

                if (File.Exists(abyssBuffsPath))
                    abyssBuffText = File.ReadAllText(abyssBuffsPath);
            }
        }
        else
            abyssBuffText = File.ReadAllText(
                Path.Combine(FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language), "abyss_buffs.json")
            );

        AbyssBuffData = JsonSerializer.Deserialize<Dictionary<string, string>>(abyssBuffText);
    }

    public static string TranslateAbyssBuffRegex(string originalText) =>
        (from x in AbyssBuffData
            where x.Key.Contains("{value}")
            let pattern = Regex.Escape(x.Key).Replace("\\{value}", "(\\d+)")
            where Regex.IsMatch(originalText, pattern)
            let regex = new Regex(pattern)
            let match = regex.Match(originalText)
            select string.Format(x.Value.Replace("value", "0"), match.Groups[1].Value)).FirstOrDefault();
}
#endif
