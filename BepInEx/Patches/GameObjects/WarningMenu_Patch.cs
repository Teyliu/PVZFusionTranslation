using HarmonyLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(WarningMenu))]
    public static class WarningMenu_Patch
    {
        private static Dictionary<string, string> warningMenuTexts = new Dictionary<string, string>();

        [HarmonyPatch(nameof(WarningMenu.EnableChallengeMode))]
        [HarmonyPostfix]
        private static void Post_EnableChallengeMode(WarningMenu __instance)
        {
            LoadWarningMenuTexts();
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>(true))
            {
                if (warningMenuTexts.ContainsKey(text.text))
                {
                    text.text = warningMenuTexts[text.text];
                }
                text.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(WarningMenu.Cancel))]
        [HarmonyPostfix]
        private static void Post_Cancel(WarningMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>(true))
            {
                if (warningMenuTexts.ContainsKey(text.text))
                {
                    text.text = warningMenuTexts[text.text];
                }
                text.font = fontAsset;
            }
        }

        private static void LoadWarningMenuTexts()
        {
            if (warningMenuTexts.Count > 0)
                return;

            warningMenuTexts.Clear();

            string stringsDir = FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language);
            string warningMenuFile = Path.Combine(stringsDir, "warning_menu.json");

            if (File.Exists(warningMenuFile))
            {
                string warningMenuJson = File.ReadAllText(warningMenuFile);
                warningMenuTexts = JsonSerializer.Deserialize<Dictionary<string, string>>(warningMenuJson);
            }
        }
    }
}
