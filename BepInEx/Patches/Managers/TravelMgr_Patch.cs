using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.RegularExpressions;
using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

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
            { "investmentBuffs", new SortedDictionary<int, string>() },
            { "synergies", new SortedDictionary<int, string>() }
        };

        public static Dictionary<string, SortedDictionary<int, string>> translatedTravelBuffs = new Dictionary<string, SortedDictionary<int, string>>()
        {
            { "advancedBuffs", new SortedDictionary<int, string>() },
            { "ultimateBuffs", new SortedDictionary<int, string>() },
            { "debuffs", new SortedDictionary<int, string>() },
            { "unlocks", new SortedDictionary<int, string>() },
            { "investmentBuffs", new SortedDictionary<int, string>() },
            { "synergies", new SortedDictionary<int, string>() }
        };

        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
        private static readonly Regex ChineseRegex = new Regex("[\\u3400-\\u4DBF\\u4E00-\\u9FFF\\uF900-\\uFAFF]", RegexOptions.Compiled);

        private static DateTime _lastDumpWriteTime = DateTime.MinValue;

        public static bool TryGetTranslatedBuff(BuffType buffType, int buffIndex, out string translated)
        {
            translated = "";
            if (!buffLinks.TryGetValue(buffType, out string category))
                return false;

            return TryGetTranslatedBuff(category, buffIndex, out translated);
        }

        public static bool TryGetTranslatedBuff(string category, int buffIndex, out string translated)
        {
            translated = "";
            if (string.IsNullOrEmpty(category))
                return false;

            if (!translatedTravelBuffs.TryGetValue(category, out SortedDictionary<int, string> translatedSet) || translatedSet == null)
                return false;

            if (!translatedSet.TryGetValue(buffIndex, out translated) || string.IsNullOrEmpty(translated))
                return false;

            return true;
        }

        public static bool ContainsChinese(string text)
        {
            return !string.IsNullOrEmpty(text) && ChineseRegex.IsMatch(text);
        }

        public static string ResolveBuffTranslation(BuffType buffType, int buffIndex, string originalText)
        {
            string resolved = "";

            if (TryGetTranslatedBuff(buffType, buffIndex, out string byIndex))
            {
                resolved = byIndex;
            }
            else if (!string.IsNullOrEmpty(originalText))
            {
                resolved = MatchTravelBuff(originalText);
            }

            bool needsStringFallback = string.IsNullOrEmpty(resolved) || ContainsChinese(resolved);
            if (!needsStringFallback)
                return resolved;

            if (string.IsNullOrEmpty(originalText))
                return resolved;

            string stringFallback = StringStore.TranslateColorText(originalText);
            if (stringFallback == originalText)
            {
                stringFallback = StringStore.TranslateText(originalText);
            }

            if (!string.IsNullOrEmpty(stringFallback) && (stringFallback != originalText || !ContainsChinese(stringFallback)))
            {
                return stringFallback;
            }

            return !string.IsNullOrEmpty(resolved) ? resolved : originalText;
        }

        public static string MatchTravelBuff(string originalText)
        {
            if (string.IsNullOrEmpty(originalText))
                return "";

            string res = "";

            foreach (var cat in dumpedTravelBuffs)
            {
                foreach (var entry in cat.Value)
                {
                    if (entry.Value == originalText || entry.Value == RemoveBuffName(originalText))
                    {
                        if (translatedTravelBuffs.TryGetValue(cat.Key, out SortedDictionary<int, string> translatedSet)
                            && translatedSet != null
                            && translatedSet.TryGetValue(entry.Key, out string translated)
                            && !string.IsNullOrEmpty(translated))
                        {
                            res = translated;
                        }
                        break;
                    }
                }

                if (res != "")
                    break;
            }

            return res;
        }

        public static string RemoveBuffName(string buffText)
        {
            string res = buffText;
            int firstColon = res.IndexOf("：");
            if (firstColon > 0)
            {
                res = res.Substring(firstColon + 1);
            }
            return res;
        }

        private static TravelMgr GetTravelMgrInstance()
        {
            try
            {
                var field = typeof(TravelMgr).GetField("_instance", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
                if (field != null)
                {
                    return (TravelMgr)field.GetValue(null);
                }
            }
            catch { }
            return null;
        }

        private static void ResetBuffCache(Dictionary<string, SortedDictionary<int, string>> target)
        {
            foreach (var key in new List<string>(target.Keys))
            {
                if (target[key] == null)
                    target[key] = new SortedDictionary<int, string>();
                else
                    target[key].Clear();
            }
        }

        private static void AddOrUpdate(Dictionary<string, SortedDictionary<int, string>> target, string category, int index, string value)
        {
            if (!target.ContainsKey(category) || target[category] == null)
                target[category] = new SortedDictionary<int, string>();

            target[category][index] = value ?? "";
        }

        private static Dictionary<string, SortedDictionary<int, string>> MergeWithDumped(Dictionary<string, SortedDictionary<int, string>> loaded)
        {
            if (loaded == null)
                loaded = new Dictionary<string, SortedDictionary<int, string>>();

            foreach (var cat in dumpedTravelBuffs)
            {
                if (!loaded.ContainsKey(cat.Key) || loaded[cat.Key] == null)
                    loaded[cat.Key] = new SortedDictionary<int, string>();

                foreach (var entry in cat.Value)
                {
                    if (!loaded[cat.Key].ContainsKey(entry.Key) || string.IsNullOrEmpty(loaded[cat.Key][entry.Key]))
                        loaded[cat.Key][entry.Key] = entry.Value;
                }
            }

            return loaded;
        }

        private static void MergeInto(Dictionary<string, SortedDictionary<int, string>> target, Dictionary<string, SortedDictionary<int, string>> source)
        {
            if (source == null)
                return;

            foreach (var cat in source)
            {
                if (!target.ContainsKey(cat.Key) || target[cat.Key] == null)
                    target[cat.Key] = new SortedDictionary<int, string>();

                if (cat.Value == null)
                    continue;

                foreach (var entry in cat.Value)
                {
                    target[cat.Key][entry.Key] = entry.Value;
                }
            }
        }

        private static Dictionary<string, SortedDictionary<int, string>> LoadBuffFile(string path)
        {
            if (!File.Exists(path))
                return null;

            try
            {
                string content = File.ReadAllText(path);
                return JsonSerializer.Deserialize<Dictionary<string, SortedDictionary<int, string>>>(content);
            }
            catch (Exception ex)
            {
                Log.LogWarning($"[TravelMgr_Patch] Failed to load buff file {path}: {ex.Message}");
                return null;
            }
        }

        private static void SaveDumpFileSafe(bool force = false)
        {
            try
            {
                if (!force && DateTime.Now - _lastDumpWriteTime < TimeSpan.FromSeconds(2))
                    return;

                string dumpDir = FileLoader.GetAssetDir(FileLoader.AssetType.Dumps);
                if (!Directory.Exists(dumpDir))
                    Directory.CreateDirectory(dumpDir);

                string jsonPath = Path.Combine(dumpDir, "travel_buffs.json");
                File.WriteAllText(jsonPath, JsonSerializer.Serialize(dumpedTravelBuffs, JsonOptions));
                _lastDumpWriteTime = DateTime.Now;
            }
            catch (Exception ex)
            {
                Log.LogWarning($"[TravelMgr_Patch] Failed to save dump file: {ex.Message}");
            }
        }

        public static void CaptureBuffFromLookMenu(BuffType buffType, int buffIndex, string originalText)
        {
            if (string.IsNullOrEmpty(originalText))
                return;

            if (!buffLinks.TryGetValue(buffType, out string category))
                return;

            AddOrUpdate(dumpedTravelBuffs, category, buffIndex, originalText);

            if (!translatedTravelBuffs.ContainsKey(category) || translatedTravelBuffs[category] == null)
                translatedTravelBuffs[category] = new SortedDictionary<int, string>();

            if (!translatedTravelBuffs[category].ContainsKey(buffIndex))
                translatedTravelBuffs[category][buffIndex] = originalText;

            SaveDumpFileSafe();
            // Log.LogInfo($"[TravelMgr_Patch] CaptureBuffFromLookMenu: {category}[{buffIndex}] = {originalText}");
        }

        private static void LoadFromFilesFallback()
        {
            string stringDir = FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language);
            string translatedPath = Path.Combine(stringDir, "travel_buffs.json");
            var translatedLoaded = LoadBuffFile(translatedPath);

            string dumpDir = FileLoader.GetAssetDir(FileLoader.AssetType.Dumps);
            string dumpedPath = Path.Combine(dumpDir, "travel_buffs.json");
            var dumpedLoaded = LoadBuffFile(dumpedPath);

            MergeInto(dumpedTravelBuffs, dumpedLoaded);
            MergeInto(dumpedTravelBuffs, translatedLoaded);

            translatedTravelBuffs = MergeWithDumped(translatedLoaded);

            Log.LogInfo("[TravelMgr_Patch] Loaded buff data from file fallback.");
        }

        public static void DumpTravelBuffs()
        {
            Log.LogInfo("[TravelMgr_Patch] DumpTravelBuffs called");

            ResetBuffCache(dumpedTravelBuffs);
            ResetBuffCache(translatedTravelBuffs);

            TravelMgr instance = GetTravelMgrInstance();
            if (instance == null)
            {
                Log.LogWarning("[TravelMgr_Patch] TravelMgr instance is null! Using file fallback and TravelLookMenu capture.");
                LoadFromFilesFallback();
                return;
            }

            try
            {
                instance.GetPlantBuffUnlockCount(PlantType.DoomGatling);

                if (TravelDictionary.advancedBuffsText != null)
                {
                    Log.LogInfo($"[TravelMgr_Patch] Dumping advancedBuffs: {TravelDictionary.advancedBuffsText.Count} items");
                    foreach (var pair in TravelDictionary.advancedBuffsText)
                    {
                        AddOrUpdate(dumpedTravelBuffs, "advancedBuffs", (int)pair.Key, pair.Value);
                    }
                }

                if (TravelDictionary.ultimateBuffsText != null)
                {
                    Log.LogInfo($"[TravelMgr_Patch] Dumping ultimateBuffs: {TravelDictionary.ultimateBuffsText.Count} items");
                    foreach (var pair in TravelDictionary.ultimateBuffsText)
                    {
                        AddOrUpdate(dumpedTravelBuffs, "ultimateBuffs", (int)pair.Key, pair.Value);
                    }
                }

                if (TravelDictionary.debuffData != null)
                {
                    Log.LogInfo($"[TravelMgr_Patch] Dumping debuffs: {TravelDictionary.debuffData.Count} items");
                    foreach (var pair in TravelDictionary.debuffData)
                    {
                        AddOrUpdate(dumpedTravelBuffs, "debuffs", (int)pair.Key, pair.Value.Item1);
                    }
                }

                if (TravelDictionary.unlocksText != null)
                {
                    Log.LogInfo($"[TravelMgr_Patch] Dumping unlocks: {TravelDictionary.unlocksText.Count} items");
                    foreach (var pair in TravelDictionary.unlocksText)
                    {
                        AddOrUpdate(dumpedTravelBuffs, "unlocks", (int)pair.Key, pair.Value);
                    }
                }

                if (TravelMgr.InvestBuffsData != null)
                {
                    Log.LogInfo($"[TravelMgr_Patch] Dumping investmentBuffs: {TravelMgr.InvestBuffsData.Count} items");
                    foreach (var pair in TravelMgr.InvestBuffsData)
                    {
                        string desc = pair.Value.GetDescription();
                        AddOrUpdate(dumpedTravelBuffs, "investmentBuffs", (int)pair.Key, desc);
                    }
                }

                if (TravelMgr.SynergysData != null)
                {
                    Log.LogInfo($"[TravelMgr_Patch] Dumping synergies: {TravelMgr.SynergysData.Count} items");
                    foreach (var pair in TravelMgr.SynergysData)
                    {
                        string synergyDesc = "";
                        try
                        {
                            var allData = pair.Value?.GetAllData();
                            if (allData != null && allData.Count > 0)
                            {
                                synergyDesc = allData[allData.Count - 1]?.Description ?? "";
                            }
                        }
                        catch (Exception ex)
                        {
                            Log.LogWarning($"[TravelMgr_Patch] Error getting synergy description: {ex.Message}");
                        }

                        if (!string.IsNullOrEmpty(synergyDesc))
                            AddOrUpdate(dumpedTravelBuffs, "synergies", (int)pair.Key, synergyDesc);
                    }
                }

                string dumpDir = FileLoader.GetAssetDir(FileLoader.AssetType.Dumps);
                string jsonPath = Path.Combine(dumpDir, "travel_buffs.json");
                File.WriteAllText(jsonPath, JsonSerializer.Serialize(dumpedTravelBuffs, JsonOptions));
                _lastDumpWriteTime = DateTime.Now;
                Log.LogInfo($"[TravelMgr_Patch] Dumped travel_buffs.json to {jsonPath}");

                string stringDir = FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language);
                string travelBuffDir = Path.Combine(stringDir, "travel_buffs.json");

                if (!File.Exists(travelBuffDir))
                {
                    File.WriteAllText(travelBuffDir, JsonSerializer.Serialize(dumpedTravelBuffs, JsonOptions));
                    translatedTravelBuffs = MergeWithDumped(null);
                }
                else
                {
                    string travelBuffs = File.ReadAllText(travelBuffDir);
                    try
                    {
                        var loaded = JsonSerializer.Deserialize<Dictionary<string, SortedDictionary<int, string>>>(travelBuffs);
                        translatedTravelBuffs = MergeWithDumped(loaded);
                    }
                    catch (Exception ex)
                    {
                        Log.LogError($"[TravelMgr_Patch] Failed to deserialize translation file: {ex.Message}");
                        translatedTravelBuffs = MergeWithDumped(null);
                    }
                }

                Log.LogInfo("[TravelMgr_Patch] DumpTravelBuffs completed");
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError($"[TravelMgr_Patch] Error dumping travel buffs: {ex.Message}");
                Log.LogError($"[TravelMgr_Patch] Stack trace: {ex.StackTrace}");
            }
        }
    }
}
