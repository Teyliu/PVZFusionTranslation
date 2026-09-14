using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator__BepInEx_.AssetStore
{
    public static class AbyssBuffStore
    {
        public static Dictionary<string, string> abyssBuffData = new Dictionary<string, string>();

        public static void LoadAbyssBuffData()
        {
            string abyssBuffText = "{}";
            string abyssBuffsPath = Path.Combine(FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language), "abyss_buffs.json");

            if (!Utils.useLocal)
            {
                string content = Utils.GetDataFromWeb($"https://raw.githubusercontent.com/Teyliu/PVZF-Translation/refs/heads/main/PvZ_Fusion_Translator/Localization/{Utils.Language}/Strings/abyss_buffs.json").Result;
                if (content != null)
                {
                    abyssBuffText = content;
                }
                else if (File.Exists(abyssBuffsPath))
                {
                    abyssBuffText = File.ReadAllText(abyssBuffsPath);
                }
            }
            else if (File.Exists(abyssBuffsPath))
            {
                abyssBuffText = File.ReadAllText(abyssBuffsPath);
            }

            abyssBuffData = JsonSerializer.Deserialize<Dictionary<string, string>>(abyssBuffText) ?? new Dictionary<string, string>();
        }

        public static string TranslateAbyssBuffRegex(string originalText)
        {
            foreach (KeyValuePair<string, string> entry in abyssBuffData)
            {
                if (!entry.Key.Contains("{value}"))
                {
                    continue;
                }

                string pattern = Regex.Escape(entry.Key).Replace("\\{value}", "(\\d+)");
                Match match = Regex.Match(originalText, pattern);
                if (match.Success)
                {
                    return string.Format(entry.Value.Replace("value", "0"), match.Groups[1].Value);
                }
            }

            return null;
        }
    }
}
