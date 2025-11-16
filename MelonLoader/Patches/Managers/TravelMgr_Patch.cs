using Il2Cpp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using HarmonyLib;

namespace PvZ_Fusion_Translator.Patches.Managers
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
        };

        public static Dictionary<string, List<string>> dumpedTravelBuffs = new Dictionary<string, List<string>>()
        {
            { "advancedUpgrades", [] },
            { "ultimateUpgrades", [] },
            { "strongUltimates", [] },
            { "debuffs", [] }
        };

        public static Dictionary<string, List<string>> translatedTravelBuffs = new Dictionary<string, List<string>>();

        public static void DumpTravelBuffs(Il2CppSystem.Collections.Generic.Dictionary<int, string> source, Dictionary<string, List<string>> dest, string index)
        {
            foreach (var i in source)
            {
                if (!Utils.CheckForUntranslatedText(i.Value))
                {
                    break;
                }
                dest[index].Add(i.Value);
            }
        }

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

        [HarmonyPatch(nameof(TravelMgr.Awake))]
        [HarmonyPrefix]
        private static void Pre_Awake(TravelMgr __instance)
        {
            // Dump buffs

            dumpedTravelBuffs = new Dictionary<string, List<string>>() // reset dump
            {
                { "advancedUpgrades", [] },
                { "ultimateUpgrades", [] },
                { "strongUltimates", [] },
                { "debuffs", [] }
            };

            DumpTravelBuffs(TravelMgr.advancedBuffs, dumpedTravelBuffs, "advancedUpgrades");
            DumpTravelBuffs(TravelMgr.ultimateBuffs, dumpedTravelBuffs, "ultimateUpgrades");
            DumpTravelBuffs(TravelMgr.unlocks, dumpedTravelBuffs, "strongUltimates");
            DumpTravelBuffs(TravelMgr.debuffs, dumpedTravelBuffs, "debuffs");

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

            string travelBuffs = File.ReadAllText(Path.Combine(stringDir, "travel_buffs.json"));

            translatedTravelBuffs = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(travelBuffs);
        }
    }
}
