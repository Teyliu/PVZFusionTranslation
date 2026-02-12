using HarmonyLib;
using Il2Cpp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using Unity.Collections;
using static PvZ_Fusion_Translator.FileLoader;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey
{
    [HarmonyPatch(typeof(TravelMgr))]
    public static class TravelMgr_Patch
    {
        public static Dictionary<string, SortedDictionary<int, string>> dumpedTravelBuffs = new()
        {
            { "advancedBuffs", new SortedDictionary<int, string>() },
            { "ultimateBuffs", new SortedDictionary<int, string>() },
            { "debuffs", new SortedDictionary<int, string>() },
            { "unlocks", new SortedDictionary<int, string>() },
            { "investmentBuffs", new SortedDictionary<int, string>() }
        };

        public static Dictionary<string, SortedDictionary<int, string>> translatedTravelBuffs = new()
        {
            { "advancedBuffs", new SortedDictionary<int, string>() },
            { "ultimateBuffs", new SortedDictionary<int, string>() },
            { "debuffs", new SortedDictionary<int, string>() },
            { "unlocks", new SortedDictionary<int, string>() },
            { "investmentBuffs", new SortedDictionary<int, string>() }
        };

        public static Dictionary<BuffType, string> buffLinks = new()
        {
            { BuffType.AdvancedBuff, "advancedBuffs" },
            { BuffType.UltimateBuff, "ultimateBuffs" },
            { BuffType.Debuff, "debuffs" },
            { BuffType.UnlockPlant, "unlocks" },
            { BuffType.InvestmentBuff, "investmentBuffs" }
        };

        public static void DumpTravelBuffs()
        {
            TravelMgr.Instance.GetPlantBuffUnlockCount(PlantType.DoomGatling);

            foreach (var pair in TravelDictionary.advancedBuffsText)
            {
                dumpedTravelBuffs["advancedBuffs"].Add((int)pair.Key, pair.Value);
            }

            foreach (var pair in TravelDictionary.ultimateBuffsText)
            {
                dumpedTravelBuffs["ultimateBuffs"].Add((int)pair.Key, pair.Value);
            }

            foreach (var pair in TravelDictionary.debuffData)
            {
                dumpedTravelBuffs["debuffs"].Add((int)pair.Key, pair.Value.Item1);
            }

            foreach (var pair in TravelDictionary.unlocksText)
            {
                dumpedTravelBuffs["unlocks"].Add((int)pair.Key, pair.Value);
            }

            foreach (var pair in TravelMgr.InvestBuffsData)
            {
                dumpedTravelBuffs["investmentBuffs"].Add((int)pair.Key, pair.Value.GetDescription());
            }

            File.WriteAllText(Path.Combine(GetAssetDir(AssetType.Dumps), "travel_buffs.json"), JsonSerializer.Serialize(dumpedTravelBuffs, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            }));

            string translatedTravelBuffsPath = Path.Combine(GetAssetDir(AssetType.Strings, Utils.Language), "travel_buffs.json");

            if (!File.Exists(translatedTravelBuffsPath))
            {
                File.WriteAllText(translatedTravelBuffsPath, JsonSerializer.Serialize(dumpedTravelBuffs, new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                }));
                translatedTravelBuffs = dumpedTravelBuffs;
            }
        }

        public static string MatchTravelBuff(string originalText)
        {
            string res = "";

            foreach (var i in translatedTravelBuffs)
            {
                foreach (var j in translatedTravelBuffs[i.Key])
                {
                    if (j.Value == originalText)
                    {
                        res = j.Value;
                        break;
                    }
                }

                if (res != "") break;
            }

            return res;
        }
    }
}
