using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;
using HarmonyLib;
//using MelonLoader.TinyJSON;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_;
using TMPro;
using UnityEngine.TextCore.Text;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(AbyssBuffMenu))]
    public static class AbyssBuffMenu_Patch
    {
        public static Dictionary<string, string> abyssBuffData = new Dictionary<string, string>();

        [HarmonyPatch(nameof(AbyssBuffMenu.Awake))]
        [HarmonyPostfix]
        public static void Post_Awake(AbyssBuffMenu __instance)
        {
            LoadAbyssBuffData();
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
                text.font = fontAsset;
            }

            TranslateWindows(__instance, fontAsset);
        }

        [HarmonyPatch(nameof(AbyssBuffMenu.SelectWindow))]
        [HarmonyPostfix]
        public static void Post_SelectWindow(AbyssBuffMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            TranslateWindows(__instance, fontAsset);
        }

        [HarmonyPatch(nameof(AbyssBuffMenu.SetFavorite))]
        [HarmonyPostfix]
        public static void Post_SetFavorite(AbyssBuffMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

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
                if (abyssBuffData.ContainsKey(text.text))
                {
                    text.text = abyssBuffData[text.text];
                }
                else
                {
                    string translatedRegex = TranslateAbyssBuffRegex(text.text);
                    if (translatedRegex != null)
                    {
                        text.text = translatedRegex;
                    }
                }

                text.font = fontAsset;
            }
        }

        public static void LoadAbyssBuffData()
        {
            abyssBuffData.Clear();

            string abyssBuffText = File.ReadAllText(Path.Combine(FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language), "abyss_buffs.json"));
            abyssBuffData = JsonSerializer.Deserialize<Dictionary<string, string>>(abyssBuffText);
        }

        public static string TranslateAbyssBuffRegex(string originalText)
        {
            foreach (var x in abyssBuffData)
            {
                if (x.Key.Contains("{value}"))
                {
                    string pattern = Regex.Escape(x.Key).Replace("\\{value}", "(\\d+)");
                    if (Regex.IsMatch(originalText, pattern))
                    {
                        var regex = new Regex(pattern);
                        var match = regex.Match(originalText);

                        return String.Format(x.Value.Replace("value", "0"), match.Groups[1].Value);
                    }
                }
            }

            return null;
        }
    }
}