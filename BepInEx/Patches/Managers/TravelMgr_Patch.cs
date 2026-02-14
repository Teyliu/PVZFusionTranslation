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
            { BuffType.AdvancedBuff, "advancedBuffs" },
            { BuffType.UltimateBuff, "ultimateBuffs" },
            { BuffType.UnlockPlant, "unlocks" },
            { BuffType.Debuff, "debuffs" },
            { BuffType.InvestmentBuff, "investmentBuffs" }
        };

        public static Dictionary<string, SortedDictionary<int, string>> dumpedTravelBuffs = new Dictionary<string, SortedDictionary<int, string>>()
        {
            { "advancedBuffs", new SortedDictionary<int, string>() },
            { "ultimateBuffs", new SortedDictionary<int, string>() },
            { "debuffs", new SortedDictionary<int, string>() },
            { "unlocks", new SortedDictionary<int, string>() },
            { "investmentBuffs", new SortedDictionary<int, string>() }
        };

        public static Dictionary<string, SortedDictionary<int, string>> translatedTravelBuffs = new Dictionary<string, SortedDictionary<int, string>>()
        {
            { "advancedBuffs", new SortedDictionary<int, string>() },
            { "ultimateBuffs", new SortedDictionary<int, string>() },
            { "debuffs", new SortedDictionary<int, string>() },
            { "unlocks", new SortedDictionary<int, string>() },
            { "investmentBuffs", new SortedDictionary<int, string>() }
        };

        public static string MatchTravelBuff(string originalText)
        {
            string res = "";

            foreach(var i in dumpedTravelBuffs)
            {
                foreach(var j in dumpedTravelBuffs[i.Key])
                {
                    if(j.Value == originalText || j.Value == RemoveBuffName(originalText))
                    {
                        res = translatedTravelBuffs[i.Key][j.Key];
                        break;
                    }
                }

                if(res != "") break;
            }

            return res;
        }

        public static string RemoveBuffName(string buffText)
        {
            string res = buffText;
            int firstColon = res.IndexOf("：");
            if(firstColon > 0)
            {
                res = res.Substring(firstColon + 1);
            }
            return res;
        }

        public static void DumpTravelBuffs()
        {
            if (TravelMgr.Instance == null)
                return;

            try
            {
                TravelMgr.Instance.GetPlantBuffUnlockCount(PlantType.DoomGatling);

                if (TravelDictionary.advancedBuffsText != null)
                {
                    foreach (var pair in TravelDictionary.advancedBuffsText)
                    {
                        dumpedTravelBuffs["advancedBuffs"].Add((int)pair.Key, pair.Value);
                    }
                }

                if (TravelDictionary.ultimateBuffsText != null)
                {
                    foreach (var pair in TravelDictionary.ultimateBuffsText)
                    {
                        dumpedTravelBuffs["ultimateBuffs"].Add((int)pair.Key, pair.Value);
                    }
                }

                if (TravelDictionary.debuffData != null)
                {
                    foreach (var pair in TravelDictionary.debuffData)
                    {
                        dumpedTravelBuffs["debuffs"].Add((int)pair.Key, pair.Value.Item1);
                    }
                }

                if (TravelDictionary.unlocksText != null)
                {
                    foreach (var pair in TravelDictionary.unlocksText)
                    {
                        dumpedTravelBuffs["unlocks"].Add((int)pair.Key, pair.Value);
                    }
                }

                if (TravelMgr.InvestBuffsData != null)
                {
                    foreach (var pair in TravelMgr.InvestBuffsData)
                    {
                        dumpedTravelBuffs["investmentBuffs"].Add((int)pair.Key, pair.Value.GetDescription());
                    }
                }

                string dumpDir = FileLoader.GetAssetDir(FileLoader.AssetType.Dumps);
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
                File.WriteAllText(Path.Combine(dumpDir, "travel_buffs.json"), JsonSerializer.Serialize(dumpedTravelBuffs, options));

                string stringDir = FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language);
                string travelBuffDir = Path.Combine(stringDir, "travel_buffs.json");

                if (!File.Exists(travelBuffDir))
                {
                    File.WriteAllText(travelBuffDir, JsonSerializer.Serialize(dumpedTravelBuffs, options));
                    translatedTravelBuffs = dumpedTravelBuffs;
                }
                else
                {
                    string travelBuffs = File.ReadAllText(travelBuffDir);
                    try
                    {
                        translatedTravelBuffs = JsonSerializer.Deserialize<Dictionary<string, SortedDictionary<int, string>>>(travelBuffs);
                    }
                    catch
                    {
                        translatedTravelBuffs = dumpedTravelBuffs;
                    }
                }
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError($"[TravelMgr_Patch] Error dumping travel buffs: {ex.Message}");
            }
        }

    }
}
