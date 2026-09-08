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
    public class TravelBuffInfo
    {
        public string name = "";
        public string desc = "";

        public TravelBuffInfo(string name_a = "", string desc_a = "")
        {
            name = name_a;
            desc = desc_a;
        }
    }

    public class TravelBuffSet
    {
        public SortedDictionary<int, TravelBuffInfo> advancedBuffs = new();
        public SortedDictionary<int, TravelBuffInfo> ultimateBuffs = new();
        public SortedDictionary<int, TravelBuffInfo> debuffs = new();
        public SortedDictionary<int, TravelBuffInfo> unlocks = new();
        public SortedDictionary<int, TravelBuffInfo> investmentBuffs = new();
        private Dictionary<string, SortedDictionary<int, TravelBuffInfo>> _travelBuffSets = [];

        public TravelBuffSet()
        {
            advancedBuffs = new();
            ultimateBuffs = new();
            debuffs = new();
            unlocks = new();
            investmentBuffs = new();

            _travelBuffSets = new()
            {
                { "advancedBuffs", advancedBuffs }, 
                { "ultimateBuffs", ultimateBuffs }, 
                { "debuffs", debuffs }, 
                { "unlocks", unlocks }, 
                { "investmentBuffs", investmentBuffs }
            };
        }

        public SortedDictionary<int, TravelBuffInfo> TryGet(string name)
        {
            switch(name)
            {
                case "advancedBuffs":
                    return advancedBuffs;
                case "ultimateBuffs":
                    return ultimateBuffs;
                case "debuffs":
                    return debuffs;
                case "unlocks":
                    return unlocks;
                case "investmentBuffs":
                    return investmentBuffs;
                default:
                    return null;
            }
        }

        public IEnumerator<ValueTuple<string, SortedDictionary<int, TravelBuffInfo>>> GetEnumerator()
        {
            foreach(var item in _travelBuffSets)
            {
                yield return new(item.Key, item.Value);
            }
        }
    }

    [HarmonyPatch(typeof(TravelMgr))]
    public static class TravelMgr_Patch
    {
        public static readonly TravelBuffSet templateTravelBuffs = new();

        public static TravelBuffSet dumpedTravelBuffs = new();

        public static TravelBuffSet translatedTravelBuffs = new();

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

            dumpedTravelBuffs = new();
            travelBuffString.Clear();

            foreach (var pair in TravelDictionary.advancedBuffsText)
            {
                Utils.TryAdd(dumpedTravelBuffs.advancedBuffs, (int)pair.Key, new TravelBuffInfo("", pair.Value));
                Utils.TryAdd(travelBuffString, pair.Value, pair.Value);
            }

            foreach (var pair in TravelDictionary.ultimateBuffsText)
            {
                Utils.TryAdd(dumpedTravelBuffs.ultimateBuffs, (int)pair.Key, new TravelBuffInfo("", pair.Value));
                Utils.TryAdd(travelBuffString, pair.Value, pair.Value);
            }

            foreach (var pair in TravelDictionary.debuffData)
            {
                Utils.TryAdd(dumpedTravelBuffs.debuffs, (int)pair.Key, new TravelBuffInfo("", pair.Value.Item1));
                Utils.TryAdd(travelBuffString, pair.Value.Item1, pair.Value.Item1);
            }

            foreach (var pair in TravelDictionary.unlocksText)
            {
                Utils.TryAdd(dumpedTravelBuffs.unlocks, (int)pair.Key, new TravelBuffInfo("", pair.Value));
                Utils.TryAdd(travelBuffString, pair.Value, pair.Value);
            }

            foreach (var pair in TravelMgr.InvestBuffsData)
            {
                Utils.TryAdd(dumpedTravelBuffs.investmentBuffs, (int)pair.Key, new TravelBuffInfo("", pair.Value.Description));
                Utils.TryAdd(travelBuffString, pair.Value.Description, pair.Value.Description);
            }

            File.WriteAllText(Path.Combine(GetAssetDir(AssetType.Dumps), "travel_buffs.json"), SerializeWithIndentation(dumpedTravelBuffs));

            string translatedTravelBuffsPath = Path.Combine(GetAssetDir(AssetType.Strings, Utils.Language), "travel_buffs.json");

            if (!File.Exists(translatedTravelBuffsPath))
            {
                File.WriteAllText(translatedTravelBuffsPath, SerializeWithIndentation(dumpedTravelBuffs));
                translatedTravelBuffs = dumpedTravelBuffs;
            }
        }

        //System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, SortedDictionary<int, string>>>(travelBuffsContent);
        public static void GenerateTranslatedTravelBuffs(string travelBuffsContent)
        {
            if (!Core.isInitialized) return;
            
            DumpTravelBuffs();

            TravelBuffSet travelBuffs = Newtonsoft.Json.JsonConvert.DeserializeObject<TravelBuffSet>(travelBuffsContent);
            translatedTravelBuffs = travelBuffs;
            travelBuffString.Clear();

            foreach(var i in travelBuffs)
            {
                var originalBuffSet = dumpedTravelBuffs.TryGet(i.Item1);
                foreach(var j in originalBuffSet)
                {
                    TravelBuffInfo originalBuff = j.Value;
                    var translatedBuffSet = travelBuffs.TryGet(i.Item1);

                    if (j.Value.desc == originalBuff.desc)
                    {
                        if (translatedBuffSet.ContainsKey(j.Key))
                        {
                            Utils.TryAdd(travelBuffString, originalBuff.desc, translatedBuffSet[j.Key].desc);
                        }
                    }
                    else if(j.Value.desc == RemoveBuffName(originalBuff.desc))
                    {
                        if (translatedBuffSet.ContainsKey(j.Key))
                        {
                            Utils.TryAdd(travelBuffString, originalBuff.desc, translatedBuffSet[j.Key].desc);
                        }
                    }

                    /*var translatedBuffSet = travelBuffs[i.Key];
                    if(translatedBuffSet.ContainsKey(j.Key))
                    {
                        string translatedBuff = travelBuffs[i.Key][j.Key];
                        travelBuffString[originalBuff] = translatedBuff;
                    }*/
                }
            }

            string travelBuffsToSave = SerializeWithIndentation(TravelMgr_Patch.translatedTravelBuffs);
			string stringDir = GetAssetDir(AssetType.Strings, Utils.Language);
			File.WriteAllText(Path.Combine(stringDir, "travel_buffs.json"), travelBuffsToSave);
        }

        public static string MatchTravelBuff(string originalText)
        {
            string res = "";

            foreach (var i in dumpedTravelBuffs)
            {
                foreach (var j in dumpedTravelBuffs.TryGet(i.Item1))
                {
                    if (j.Value.desc == originalText || j.Value.desc == RemoveBuffName(originalText))
                    {
                        var translatedBuffSet = translatedTravelBuffs.TryGet(i.Item1);
                        if (translatedBuffSet.ContainsKey(j.Key))
                        {
                            res = translatedBuffSet[j.Key].desc;
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

        public static Dictionary<string, string> modifierNameDict = new Dictionary<string, string>()
        {
            { "advancedBuffs", "COMMON_MODIFIER_TAG" },
            { "ultimateBuffs", "EPIC_MODIFIER_TAG" },
            { "debuffs", "ZOMBIE_MODIFIER_TAG" },
            { "unlocks", "UNLOCK_MODIFIER_TAG" },
            { "investmentBuffs", "INVEST_MODIFIER_TAG" }
        };

        public static Dictionary<string, string> fallbackNameDict = new Dictionary<string, string>()
        {
            { "COMMON_MODIFIER_TAG", "Common Modifier" },
            { "EPIC_MODIFIER_TAG", "Epic Modifier" },
            { "ZOMBIE_MODIFIER_TAG", "Zombie Modifier" },
            { "UNLOCK_MODIFIER_TAG", "Unlock Modifier" },
            { "INVEST_MODIFIER_TAG", "Investment Modifier" }
        };

        public static string TranslateNameTag(string originalText)
        {
            string res = originalText;

            string nameTag = modifierNameDict[originalText];
            res = StringStore.translationString.ContainsKey(nameTag) ? StringStore.TranslateText(nameTag) : fallbackNameDict[nameTag];

            return res;
        }

        public static ValueTuple<string, int, string, bool> FindBuffData(string buffText)
        {
            ValueTuple<string, int, string, bool> res = new();
            foreach(var pair1 in translatedTravelBuffs)
            {
                foreach(var pair2 in pair1.Item2)
                {
                    if(buffText == pair2.Value.desc)
                    {
                        if(pair2.Value.name != "")
                        {
                            res.Item1 = pair2.Value.name;
                            res.Item4 = true;
                        }
                        else
                        {
                            res.Item1 = TranslateNameTag(pair1.Item1);
                            res.Item4 = false;
                        }
                        res.Item2 = pair2.Key;
                    }
                }
            }

            foreach(var pair1 in dumpedTravelBuffs)
            {
                foreach(var pair2 in pair1.Item2)
                {
                    if(buffText == pair2.Value.desc)
                    {
                        if(pair2.Value.name != "")
                        {
                            res.Item1 = pair2.Value.name;
                            res.Item4 = true;
                        }
                        else
                        {
                            res.Item1 = TranslateNameTag(pair1.Item1);
                            res.Item4 = false;
                        }
                        res.Item2 = pair2.Key;
                    }
                }
            }

            string finalBuffText = buffText;
            if(travelBuffString.ContainsKey(buffText))
            {
                finalBuffText = travelBuffString[buffText];
            }
            else
            {
                finalBuffText = StringStore.TranslateText(buffText);
            }
            res.Item3 = finalBuffText;

            return res;
        }

        public static string fallbackFBuffStr = "{0}: {1}";

        public static string AddBuffName(string buffText)
        {
            string translatedBuff = buffText;
            if(Utils.CheckForUntranslatedText(buffText))
            {
                if(travelBuffString.ContainsKey(buffText))
                {
                    translatedBuff = travelBuffString[buffText];
                }
            }
            var buffData = FindBuffData(translatedBuff);
            if(buffData.Item1 != null && buffData.Item3 != null)
            {
                string buffFStr = StringStore.translationStringRegex.ContainsKey("BUFF_NAME_FORMAT") ? StringStore.translationStringRegex["BUFF_NAME_FORMAT"] : "{0}: {1}";
                string fBuffDesc = string.Format(buffFStr, buffData.Item1, buffData.Item3);
                translatedBuff = fBuffDesc;
            }

            return translatedBuff;
        }
    }
}
