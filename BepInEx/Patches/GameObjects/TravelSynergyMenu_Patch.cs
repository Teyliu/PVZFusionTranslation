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
    [HarmonyPatch(typeof(TravelSynergyMenu))]
    public static class TravelSynergyMenu_Patch
    {
        private static Dictionary<string, string> synergyMenuTexts = new Dictionary<string, string>();

        [HarmonyPatch(nameof(TravelSynergyMenu.Awake))]
        [HarmonyPostfix]
        private static void Post_Awake(TravelSynergyMenu __instance)
        {
            LoadSynergyMenuTexts();
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>(true))
            {
                if (synergyMenuTexts.ContainsKey(text.text))
                {
                    text.text = synergyMenuTexts[text.text];
                }
                text.font = fontAsset;
            }
        }

        private static void LoadSynergyMenuTexts()
        {
            if (synergyMenuTexts.Count > 0)
                return;

            synergyMenuTexts.Clear();

            string stringsDir = FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language);
            string synergyMenuFile = Path.Combine(stringsDir, "synergy_menu.json");

            if (File.Exists(synergyMenuFile))
            {
                string synergyMenuJson = File.ReadAllText(synergyMenuFile);
                synergyMenuTexts = JsonSerializer.Deserialize<Dictionary<string, string>>(synergyMenuJson);
            }
        }
    }
}
