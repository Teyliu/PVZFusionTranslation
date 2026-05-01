using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using Unity.Collections;
using UnityEngine.Rendering;
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

        public static Dictionary<string, string> travelBuffString = new()
        {

        };

        public static Dictionary<BuffType, string> buffLinks = new()
        {
            { BuffType.AdvancedBuff, "advancedBuffs" },
            { BuffType.UltimateBuff, "ultimateBuffs" },
            { BuffType.Debuff, "debuffs" },
            { BuffType.UnlockPlant, "unlocks" },
            { BuffType.InvestmentBuff, "investmentBuffs" }
        };

        [HarmonyPatch(nameof(TravelMgr.GetText))]
        [HarmonyPostfix]
        public static void GetText(TravelMgr __instance, ref string __result)
        {
            if (travelBuffString.ContainsKey(__result))
            { 
                __result = travelBuffString[__result]; 
            }
            else if(travelBuffString.ContainsKey(RemoveBuffName(__result)))
            {
                __result = travelBuffString[RemoveBuffName(__result)];
            }
            else
            {
                __result = StringStore.TranslateText(__result);
            }
        }

        public static void DumpTravelBuffs()
        {
            TravelMgr.Instance.GetPlantBuffUnlockCount(PlantType.DoomGatling);

            foreach (var pair in TravelDictionary.advancedBuffsText)
            {
                dumpedTravelBuffs["advancedBuffs"].Add((int)pair.Key, pair.Value);
                travelBuffString.Add(pair.Value, pair.Value);
            }

            foreach (var pair in TravelDictionary.ultimateBuffsText)
            {
                dumpedTravelBuffs["ultimateBuffs"].Add((int)pair.Key, pair.Value);
                travelBuffString.Add(pair.Value, pair.Value);
            }

            foreach (var pair in TravelDictionary.debuffData)
            {
                dumpedTravelBuffs["debuffs"].Add((int)pair.Key, pair.Value.Item1);
                travelBuffString.Add(pair.Value.Item1, pair.Value.Item1);
            }

            foreach (var pair in TravelDictionary.unlocksText)
            {
                dumpedTravelBuffs["unlocks"].Add((int)pair.Key, pair.Value);
                travelBuffString.Add(pair.Value, pair.Value);
            }

            foreach (var pair in TravelMgr.InvestBuffsData)
            {
                dumpedTravelBuffs["investmentBuffs"].Add((int)pair.Key, pair.Value.GetDescription());
                travelBuffString.Add(pair.Value.GetDescription(), pair.Value.GetDescription());
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

        //System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, SortedDictionary<int, string>>>(travelBuffsContent);
        public static Dictionary<string, SortedDictionary<int, string>> GenerateTranslatedTravelBuffs(string travelBuffsContent)
        {
            TravelMgr_Patch.DumpTravelBuffs();

            Dictionary<string, SortedDictionary<int, string>> travelBuffs = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, SortedDictionary<int, string>>>(travelBuffsContent);

            // save travel buffs

			string travelBuffsToSave = SerializeWithIndentation(travelBuffs);
            string stringDir = GetAssetDir(AssetType.Strings, Utils.Language);
			File.WriteAllText(Path.Combine(stringDir, "travel_buffs.json"), travelBuffsToSave);

            foreach(var i in travelBuffs)
            {
                var originalBuffSet = dumpedTravelBuffs[i.Key];
                foreach(var j in originalBuffSet)
                {
                    string originalBuff = j.Value;
                    var translatedBuffSet = travelBuffs[i.Key];

                    if (j.Value == originalBuff)
                    {
                        if (translatedBuffSet.ContainsKey(j.Key))
                        {
                            if(travelBuffString.ContainsKey(originalBuff))
                            {
                                travelBuffString[originalBuff] = translatedBuffSet[j.Key];
                            }
                            else
                            {
                                travelBuffString.Add(originalBuff, translatedBuffSet[j.Key]);
                            }
                        }
                    }
                    else if(j.Value == RemoveBuffName(originalBuff))
                    {
                        if (translatedBuffSet.ContainsKey(j.Key))
                        {
                            if(travelBuffString.ContainsKey(originalBuff))
                            {
                                travelBuffString[RemoveBuffName(originalBuff)] = translatedBuffSet[j.Key];
                            }
                            else
                            {
                                travelBuffString.Add(RemoveBuffName(originalBuff), translatedBuffSet[j.Key]);
                            }
                        }
                    }
                    else
                    {
                        Log.LogInfo("Couldnt find this buff");
                    }

                    /*var translatedBuffSet = travelBuffs[i.Key];
                    if(translatedBuffSet.ContainsKey(j.Key))
                    {
                        string translatedBuff = travelBuffs[i.Key][j.Key];
                        travelBuffString[originalBuff] = translatedBuff;
                    }*/
                }
            }

            return travelBuffs;
        }

        public static string MatchTravelBuff(string originalText)
        {
            string res = "";

            foreach (var i in dumpedTravelBuffs)
            {
                foreach (var j in dumpedTravelBuffs[i.Key])
                {
                    if (j.Value == originalText || j.Value == RemoveBuffName(originalText))
                    {
                        var translatedBuffSet = translatedTravelBuffs[i.Key];
                        if (translatedBuffSet.ContainsKey(j.Key))
                        {
                            res = translatedBuffSet[j.Key];
                        }
                        break;
                    }
                }

                if (res != "") break;
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
    }
}
