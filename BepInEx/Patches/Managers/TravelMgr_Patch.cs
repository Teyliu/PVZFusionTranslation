using TMPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;
using HarmonyLib;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
    [HarmonyPatch(typeof(TravelMgr))]
    public static class TravelMgr_Patch
    {
        public static Dictionary<BuffType, string> buffLinks = new Dictionary<BuffType, string>()
        {
            { BuffType.AdvancedBuff, "advancedUpgrades" },
            { BuffType.UltimateBuff, "ultimateUpgrades" },
            { BuffType.UnlockPlant, "strongUltimates" },
            { BuffType.Debuff, "debuffs" },
            { BuffType.InvestmentBuff, "investmentBuffs" }
        };

        public static Dictionary<string, List<string>> dumpedTravelBuffs = new Dictionary<string, List<string>>()
        {
            { "advancedUpgrades", [] },
            { "ultimateUpgrades", [] },
            { "strongUltimates", [] },
            { "debuffs", [] },
            { "investmentBuffs", [] }
        };

        public static Dictionary<string, List<string>> translatedTravelBuffs = new Dictionary<string, List<string>>();

        public static string MatchTravelBuff(string originalText)
        {
            string res = "";

            foreach(var i in dumpedTravelBuffs)
            {
                if(i.Value.Contains(originalText))
                {
                    res = translatedTravelBuffs[i.Key][i.Value.IndexOf(originalText)];
                    break;
                }
            }

            return res;
        }

        [HarmonyPatch("get_Instance")]
        [HarmonyPrefix]
        private static void Pre_get_Instance()
        {
            if (dumpedTravelBuffs["advancedUpgrades"].Count > 0)
                return;

            dumpedTravelBuffs = new Dictionary<string, List<string>>()
            {
                { "advancedUpgrades", [] },
                { "ultimateUpgrades", [] },
                { "strongUltimates", [] },
                { "debuffs", [] },
                { "investmentBuffs", [] }
            };

            try 
            {
                if (TravelDictionary.advancedBuffsText != null)
                {
                    foreach (var kvp in TravelDictionary.advancedBuffsText)
                    {
                        if (kvp.Value != null && Utils.CheckForUntranslatedText(kvp.Value))
                            dumpedTravelBuffs["advancedUpgrades"].Add(kvp.Value);
                    }
                }
                
                if (TravelDictionary.ultimateBuffsText != null)
                {
                    foreach (var kvp in TravelDictionary.ultimateBuffsText)
                    {
                        if (kvp.Value != null && Utils.CheckForUntranslatedText(kvp.Value))
                            dumpedTravelBuffs["ultimateUpgrades"].Add(kvp.Value);
                    }
                }
                
                if (TravelDictionary.unlocksText != null)
                {
                    foreach (var kvp in TravelDictionary.unlocksText)
                    {
                        if (kvp.Value != null && Utils.CheckForUntranslatedText(kvp.Value))
                            dumpedTravelBuffs["strongUltimates"].Add(kvp.Value);
                    }
                }
                
                if (TravelDictionary.debuffData != null)
                {
                    foreach (var kvp in TravelDictionary.debuffData)
                    {
                        if (kvp.Value.Item1 != null && Utils.CheckForUntranslatedText(kvp.Value.Item1))
                            dumpedTravelBuffs["debuffs"].Add(kvp.Value.Item1);
                    }
                }

                if (TravelMgr.InvestBuffsData != null)
                {
                    foreach (var kvp in TravelMgr.InvestBuffsData)
                    {
                        var investBuff = kvp.Value;
                        string description = GetInvestBuffDescription(kvp.Key);
                        if (!string.IsNullOrEmpty(description) && Utils.CheckForUntranslatedText(description))
                            dumpedTravelBuffs["investmentBuffs"].Add(description);
                    }
                }

                string dumpDir = FileLoader.GetAssetDir(FileLoader.AssetType.Dumps);
                var options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                    WriteIndented = true
                };
                File.WriteAllText(Path.Combine(dumpDir, "travel_buffs.json"), JsonSerializer.Serialize(dumpedTravelBuffs, options));

                string stringDir = FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language);
                string travelBuffDir = Path.Combine(stringDir, "travel_buffs.json");

                if(!File.Exists(travelBuffDir))
                {
                    File.WriteAllText(travelBuffDir, JsonSerializer.Serialize(dumpedTravelBuffs, options));
                }

                string travelBuffs = File.ReadAllText(travelBuffDir);

                translatedTravelBuffs = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(travelBuffs);
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError($"[TravelMgr_Patch] Error loading travel buffs: {ex.Message}");
            }
        }

        private static string GetInvestBuffDescription(InvestBuff buff)
        {
            try
            {
                return buff.ToString();
            }
            catch
            {
                return "";
            }
        }
    }
}
