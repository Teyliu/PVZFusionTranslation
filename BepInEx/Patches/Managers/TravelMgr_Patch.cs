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

        public static Dictionary<string, string> travelBuffString = new Dictionary<string, string>();

        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
        private static readonly Regex ChineseRegex = new Regex("[\\u3400-\\u4DBF\\u4E00-\\u9FFF\\uF900-\\uFAFF]", RegexOptions.Compiled);

        private static DateTime _lastDumpWriteTime = DateTime.MinValue;
        private static bool _runtimeTravelBuffsDumped = false;

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

        public static bool TryGetTranslatedBuff(object buff, out string translated)
        {
            translated = "";
            if (buff == null)
                return false;

            string category = "";
            int buffIndex = -1;

            switch (buff)
            {
                case AdvBuff advBuff:
                    category = "advancedBuffs";
                    buffIndex = (int)advBuff;
                    break;
                case UltiBuff ultiBuff:
                    category = "ultimateBuffs";
                    buffIndex = (int)ultiBuff;
                    break;
                case TravelUnlocks unlock:
                    category = "unlocks";
                    buffIndex = (int)unlock;
                    break;
                case TravelDebuff debuff:
                    category = "debuffs";
                    buffIndex = (int)debuff;
                    break;
                case InvestBuff investBuff:
                    category = "investmentBuffs";
                    buffIndex = (int)investBuff;
                    break;
                default:
                    return false;
            }

            return TryGetTranslatedBuff(category, buffIndex, out translated);
        }

        public static bool ContainsChinese(string text)
        {
            return !string.IsNullOrEmpty(text) && ChineseRegex.IsMatch(text);
        }

        private static string StripRichText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";

            return Regex.Replace(text, "<[^>]+>", "");
        }

        private static string NormalizeBuffText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";

            string normalized = StripRichText(text)
                .Replace("：", ":")
                .Replace("，", ",")
                .Replace("。", ".")
                .Replace("；", ";")
                .Replace("×", "x")
                .Replace("\r", "")
                .Replace("\n", "");

            return Regex.Replace(normalized, "\\s+", "");
        }

        private static string GetBuffTitle(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";

            string cleaned = StripRichText(text).Trim();
            int colonIndex = cleaned.IndexOf("：");
            if (colonIndex < 0)
                colonIndex = cleaned.IndexOf(":");

            return colonIndex > 0 ? cleaned.Substring(0, colonIndex).Trim() : "";
        }

        private static void AddTravelBuffString(string original, string translated)
        {
            if (string.IsNullOrEmpty(original) || string.IsNullOrEmpty(translated))
                return;

            travelBuffString[original] = translated;

            string withoutName = RemoveBuffName(original);
            if (!string.IsNullOrEmpty(withoutName) && withoutName != original)
                travelBuffString[withoutName] = translated;
        }

        public static void RebuildTravelBuffString()
        {
            travelBuffString.Clear();

            foreach (var cat in dumpedTravelBuffs)
            {
                if (cat.Value == null)
                    continue;

                translatedTravelBuffs.TryGetValue(cat.Key, out SortedDictionary<int, string> translatedSet);

                foreach (var entry in cat.Value)
                {
                    string translated = entry.Value;
                    if (translatedSet != null
                        && translatedSet.TryGetValue(entry.Key, out string translatedBuff)
                        && !string.IsNullOrEmpty(translatedBuff))
                    {
                        translated = translatedBuff;
                    }

                    AddTravelBuffString(entry.Value, translated);
                }
            }

            foreach (var entry in StringStore.translationString)
            {
                if (!string.IsNullOrEmpty(GetBuffTitle(entry.Key)))
                    AddTravelBuffString(entry.Key, entry.Value);
            }

            Log.LogInfo($"[TravelMgr_Patch] Rebuilt travelBuffString: {travelBuffString.Count} entries");
        }

        public static string ResolveBuffTranslation(BuffType buffType, int buffIndex, string originalText)
        {
            EnsureRuntimeTravelBuffsDumped();

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
            string normalizedOriginal = NormalizeBuffText(originalText);
            string originalTitle = GetBuffTitle(originalText);
            bool canMatchTitle = !string.IsNullOrEmpty(originalTitle) && CountTravelBuffTitleMatches(originalTitle) == 1;

            foreach (var cat in dumpedTravelBuffs)
            {
                foreach (var entry in cat.Value)
                {
                    string dumpedText = entry.Value;
                    if (dumpedText == originalText
                        || dumpedText == RemoveBuffName(originalText)
                        || NormalizeBuffText(dumpedText) == normalizedOriginal
                        || (canMatchTitle && GetBuffTitle(dumpedText) == originalTitle))
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

        private static int CountTravelBuffTitleMatches(string title)
        {
            int count = 0;
            foreach (var cat in dumpedTravelBuffs)
            {
                if (cat.Value == null)
                    continue;

                foreach (var entry in cat.Value)
                {
                    if (GetBuffTitle(entry.Value) == title)
                        count++;
                }
            }

            return count;
        }

        private static bool IsLongTravelDescription(string text)
        {
            return !string.IsNullOrEmpty(text)
                && text.Length > 24
                && (text.Contains("：") || text.Contains(":"))
                && ContainsChinese(text);
        }

        private static string MatchTranslationStringByTitle(string originalText)
        {
            string originalTitle = GetBuffTitle(originalText);
            if (string.IsNullOrEmpty(originalTitle))
                return "";

            int titleMatches = 0;
            string result = "";
            foreach (var entry in StringStore.translationString)
            {
                if (GetBuffTitle(entry.Key) == originalTitle && !string.IsNullOrEmpty(entry.Value))
                {
                    titleMatches++;
                    result = entry.Value;
                    if (titleMatches > 1)
                        return "";
                }
            }

            return titleMatches == 1 ? result : "";
        }

        private static string TranslateKnownTravelTerms(string originalText)
        {
            if (string.IsNullOrEmpty(originalText) || !ContainsChinese(originalText))
                return originalText;

            string directTranslated = IsLongTravelDescription(originalText) ? originalText : StringStore.TranslateText(originalText);
            if (!string.IsNullOrEmpty(directTranslated) && directTranslated != originalText)
                return directTranslated;

            string translated = originalText;
            var plantNames = new List<KeyValuePair<string, string>>(Utils.plantIndiceStrings);
            plantNames.Sort((a, b) => b.Key.Length.CompareTo(a.Key.Length));

            foreach (var plantName in plantNames)
            {
                if (!string.IsNullOrEmpty(plantName.Key)
                    && !string.IsNullOrEmpty(plantName.Value)
                    && plantName.Key.Length >= 2
                    && plantName.Key != plantName.Value
                    && translated.Contains(plantName.Key))
                {
                    translated = translated.Replace(plantName.Key, plantName.Value);
                }
            }

            translated = translated.Replace("←→", " ←→ ");

            string ResolveTerm(string chinese)
            {
                string localized = StringStore.TranslateText(chinese);
                return !string.IsNullOrEmpty(localized) && localized != chinese ? localized : chinese;
            }

            string ReplaceTerm(string source, string chinese, string canonicalChinese = null)
            {
                if (!source.Contains(chinese))
                    return source;

                return source.Replace(chinese, ResolveTerm(canonicalChinese ?? chinese));
            }

            translated = ReplaceTerm(translated, "已关闭");
            translated = ReplaceTerm(translated, "已开启");
            translated = ReplaceTerm(translated, "已满级");
            translated = ReplaceTerm(translated, "未关闭", "已开启");
            translated = ReplaceTerm(translated, "不能升级", "不可升级");
            translated = ReplaceTerm(translated, "不可升级");
            translated = ReplaceTerm(translated, "无法升级", "不可升级");
            translated = ReplaceTerm(translated, "词条已选完");
            translated = ReplaceTerm(translated, "已有强究");
            translated = ReplaceTerm(translated, "解锁");
            translated = ReplaceTerm(translated, "究极");
            translated = ReplaceTerm(translated, "超级");
            translated = ReplaceTerm(translated, "亚种");
            translated = ReplaceTerm(translated, "融合配方");
            translated = ReplaceTerm(translated, "转换配方");
            translated = ReplaceTerm(translated, "配方");

            return translated;
        }

        public static string TranslateTravelText(string originalText)
        {
            if (string.IsNullOrEmpty(originalText))
                return originalText;

            EnsureRuntimeTravelBuffsDumped();

            if (StringStore.translationString.TryGetValue(originalText, out string exactString)
                && !string.IsNullOrEmpty(exactString)
                && exactString != originalText)
            {
                return exactString;
            }

            if (travelBuffString.TryGetValue(originalText, out string direct))
                return direct;

            string withoutName = RemoveBuffName(originalText);
            if (travelBuffString.TryGetValue(withoutName, out string directWithoutName))
                return directWithoutName;

            string matched = MatchTravelBuff(originalText);
            if (!string.IsNullOrEmpty(matched) && !ContainsChinese(matched))
                return matched;

            matched = MatchTranslationStringByTitle(originalText);
            if (!string.IsNullOrEmpty(matched) && !ContainsChinese(matched))
                return matched;

            string knownTerms = TranslateKnownTravelTerms(originalText);
            if (knownTerms != originalText && !IsLongTravelDescription(originalText))
                return knownTerms;

            if (IsLongTravelDescription(originalText))
                return originalText;

            string translated = StringStore.TranslateColorText(originalText);
            if (translated == originalText)
                translated = StringStore.TranslateText(originalText);

            return string.IsNullOrEmpty(translated) ? originalText : translated;
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

        [HarmonyPatch(nameof(TravelMgr.GetText))]
        [HarmonyPostfix]
        public static void GetText(TravelMgr __instance, object buff, ref string __result)
        {
            if (string.IsNullOrEmpty(__result))
                return;

            string original = __result;
            string buffInfo = buff != null ? $"{buff.GetType().Name}:{buff}" : "null";

            Log.LogInfo($"==== [TravelMgr.GetText] buff={buffInfo} ====");
            Log.LogInfo($"[TravelMgr.GetText] travelBuffString count: {travelBuffString.Count}");
            Log.LogInfo($"[TravelMgr.GetText] Input: \"{original}\"");

            string travelTranslated = TryGetTranslatedBuff(buff, out string translatedByBuff)
                ? translatedByBuff
                : TranslateTravelText(__result);
            if (travelTranslated != __result)
            {
                __result = travelTranslated;
                Log.LogInfo($"[TravelMgr.GetText] Travel HIT: \"{original}\" -> \"{__result}\"");
            }
            else
            {
                Log.LogInfo($"[TravelMgr.GetText] NO TRANSLATION: \"{original}\"");
            }
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
                var result = JsonSerializer.Deserialize<Dictionary<string, SortedDictionary<int, string>>>(content);
                return result;
            }
            catch
            {
                try
                {
                    string content = File.ReadAllText(path);
                    return LoadTravelBuffsFlexible(content);
                }
                catch (Exception ex)
                {
                    Log.LogWarning($"[TravelMgr_Patch] Failed to load buff file {path}: {ex.Message}");
                    return null;
                }
            }
        }

        private static bool HasRuntimeTravelData()
        {
            return (TravelDictionary.advancedBuffsText != null && TravelDictionary.advancedBuffsText.Count > 0)
                || (TravelDictionary.ultimateBuffsText != null && TravelDictionary.ultimateBuffsText.Count > 0)
                || (TravelDictionary.debuffData != null && TravelDictionary.debuffData.Count > 0)
                || (TravelDictionary.unlocksText != null && TravelDictionary.unlocksText.Count > 0)
                || (TravelMgr.InvestBuffsData != null && TravelMgr.InvestBuffsData.Count > 0)
                || (TravelMgr.SynergysData != null && TravelMgr.SynergysData.Count > 0);
        }

        private static void EnsureRuntimeTravelBuffsDumped()
        {
            if (_runtimeTravelBuffsDumped || !HasRuntimeTravelData())
                return;

            DumpTravelBuffs();
        }

        internal static Dictionary<string, SortedDictionary<int, string>> ConvertLegacyTravelBuffs(Dictionary<string, SortedDictionary<int, string>> legacy)
        {
            var converted = new Dictionary<string, SortedDictionary<int, string>>();
            if (legacy.TryGetValue("advancedUpgrades", out var advUpgrades))
                converted["advancedBuffs"] = advUpgrades;
            if (legacy.TryGetValue("ultimateUpgrades", out var ultUpgrades))
                converted["ultimateBuffs"] = ultUpgrades;
            if (legacy.TryGetValue("strongUltimates", out var strongUltimates))
                converted["ultimateBuffs"] = MergeDictionaries(converted.GetValueOrDefault("ultimateBuffs", new SortedDictionary<int, string>()), strongUltimates);
            if (legacy.TryGetValue("debuffs", out var debuffs))
                converted["debuffs"] = debuffs;
            if (legacy.TryGetValue("investmentBuffs", out var investBuffs))
                converted["investmentBuffs"] = investBuffs;
            if (legacy.TryGetValue("synergies", out var synergies))
                converted["synergies"] = synergies;
            return converted;
        }

        internal static Dictionary<string, SortedDictionary<int, string>> LoadTravelBuffsFlexible(string jsonString)
        {
            try
            {
                using var doc = JsonDocument.Parse(jsonString);
                var result = new Dictionary<string, SortedDictionary<int, string>>();
                
                foreach (var category in doc.RootElement.EnumerateObject())
                {
                    var dict = new SortedDictionary<int, string>();
                    
                    if (category.Value.ValueKind == JsonValueKind.Object)
                    {
                        foreach (var item in category.Value.EnumerateObject())
                        {
                            if (int.TryParse(item.Name, out int key))
                            {
                                dict[key] = item.Value.GetString() ?? "";
                            }
                        }
                    }
                    else if (category.Value.ValueKind == JsonValueKind.Array)
                    {
                        int idx = 0;
                        foreach (var item in category.Value.EnumerateArray())
                        {
                            if (item.ValueKind == JsonValueKind.String)
                            {
                                dict[idx++] = item.GetString() ?? "";
                            }
                        }
                    }
                    
                    string newKey = category.Name;
                    if (category.Name == "advancedUpgrades") newKey = "advancedBuffs";
                    else if (category.Name == "ultimateUpgrades") newKey = "ultimateBuffs";
                    else if (category.Name == "strongUltimates") newKey = "ultimateBuffs";
                    
                    if (!result.ContainsKey(newKey))
                        result[newKey] = dict;
                    else
                        result[newKey] = MergeDictionaries(result[newKey], dict);
                }
                
                return result;
            }
            catch (Exception ex)
            {
                Log.LogWarning($"[TravelMgr_Patch] LoadTravelBuffsFlexible failed: {ex.Message}");
                return null;
            }
        }

        private static SortedDictionary<int, string> MergeDictionaries(SortedDictionary<int, string> a, SortedDictionary<int, string> b)
        {
            foreach (var pair in b)
            {
                if (!a.ContainsKey(pair.Key))
                    a[pair.Key] = pair.Value;
            }
            return a;
        }

        private static void SaveDumpFileSafe(bool force = false)
        {
            try
            {
                if (!force && DateTime.Now - _lastDumpWriteTime < TimeSpan.FromSeconds(2))
                    return;

                // Dump disabled - user doesn't need it
                // string dumpDir = FileLoader.GetAssetDir(FileLoader.AssetType.Dumps);
                // if (!Directory.Exists(dumpDir))
                //     Directory.CreateDirectory(dumpDir);
                // string jsonPath = Path.Combine(dumpDir, "travel_buffs.json");
                // File.WriteAllText(jsonPath, JsonSerializer.Serialize(dumpedTravelBuffs, JsonOptions));
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

            translatedTravelBuffs = MergeWithDumped(translatedLoaded);
            RebuildTravelBuffString();

            Log.LogInfo("[TravelMgr_Patch] Loaded buff data from file fallback.");
        }

        public static void DumpTravelBuffs()
        {
            Log.LogInfo("[TravelMgr_Patch] DumpTravelBuffs called");

            ResetBuffCache(dumpedTravelBuffs);
            ResetBuffCache(translatedTravelBuffs);

            TravelMgr instance = GetTravelMgrInstance();
            if (instance == null && !HasRuntimeTravelData())
            {
                Log.LogWarning("[TravelMgr_Patch] TravelMgr instance is null! Using file fallback and TravelLookMenu capture.");
                LoadFromFilesFallback();
                return;
            }

            try
            {
                if (instance != null)
                {
                    try
                    {
                        instance.GetPlantBuffUnlockCount(PlantType.DoomGatling);
                    }
                    catch (Exception ex)
                    {
                        Log.LogWarning($"[TravelMgr_Patch] TravelMgr warmup failed, continuing with TravelDictionary data: {ex.Message}");
                    }
                }

                if (TravelDictionary.advancedBuffsText != null)
                {
                    Log.LogInfo($"[TravelMgr_Patch] Dumping advancedBuffs: {TravelDictionary.advancedBuffsText.Count} items");
                    foreach (var pair in TravelDictionary.advancedBuffsText)
                    {
                        AddOrUpdate(dumpedTravelBuffs, "advancedBuffs", (int)pair.Key, pair.Value);
                        if (!travelBuffString.ContainsKey(pair.Value))
                            travelBuffString.Add(pair.Value, pair.Value);
                    }
                }

                if (TravelDictionary.ultimateBuffsText != null)
                {
                    Log.LogInfo($"[TravelMgr_Patch] Dumping ultimateBuffs: {TravelDictionary.ultimateBuffsText.Count} items");
                    foreach (var pair in TravelDictionary.ultimateBuffsText)
                    {
                        AddOrUpdate(dumpedTravelBuffs, "ultimateBuffs", (int)pair.Key, pair.Value);
                        if (!travelBuffString.ContainsKey(pair.Value))
                            travelBuffString.Add(pair.Value, pair.Value);
                    }
                }

                if (TravelDictionary.debuffData != null)
                {
                    Log.LogInfo($"[TravelMgr_Patch] Dumping debuffs: {TravelDictionary.debuffData.Count} items");
                    foreach (var pair in TravelDictionary.debuffData)
                    {
                        AddOrUpdate(dumpedTravelBuffs, "debuffs", (int)pair.Key, pair.Value.Item1);
                        if (!travelBuffString.ContainsKey(pair.Value.Item1))
                            travelBuffString.Add(pair.Value.Item1, pair.Value.Item1);
                    }
                }

                if (TravelDictionary.unlocksText != null)
                {
                    Log.LogInfo($"[TravelMgr_Patch] Dumping unlocks: {TravelDictionary.unlocksText.Count} items");
                    foreach (var pair in TravelDictionary.unlocksText)
                    {
                        AddOrUpdate(dumpedTravelBuffs, "unlocks", (int)pair.Key, pair.Value);
                        if (!travelBuffString.ContainsKey(pair.Value))
                            travelBuffString.Add(pair.Value, pair.Value);
                    }
                }

                if (TravelMgr.InvestBuffsData != null)
                {
                    Log.LogInfo($"[TravelMgr_Patch] Dumping investmentBuffs: {TravelMgr.InvestBuffsData.Count} items");
                    foreach (var pair in TravelMgr.InvestBuffsData)
                    {
                        string desc = pair.Value.GetDescription();
                        AddOrUpdate(dumpedTravelBuffs, "investmentBuffs", (int)pair.Key, desc);
                        if (!travelBuffString.ContainsKey(desc))
                            travelBuffString.Add(desc, desc);
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

                        foreach (var cat in dumpedTravelBuffs)
                        {
                            foreach (var entry in cat.Value)
                            {
                                string originalBuff = entry.Value;
                                if (translatedTravelBuffs.TryGetValue(cat.Key, out SortedDictionary<int, string> translatedSet)
                                    && translatedSet != null
                                    && translatedSet.TryGetValue(entry.Key, out string translatedBuff)
                                    && !string.IsNullOrEmpty(translatedBuff))
                                {
                                    if (travelBuffString.ContainsKey(originalBuff))
                                        travelBuffString[originalBuff] = translatedBuff;
                                    else
                                        travelBuffString.Add(originalBuff, translatedBuff);

                                    string withoutName = RemoveBuffName(originalBuff);
                                    if (withoutName != originalBuff)
                                    {
                                        if (travelBuffString.ContainsKey(withoutName))
                                            travelBuffString[withoutName] = translatedBuff;
                                        else
                                            travelBuffString.Add(withoutName, translatedBuff);
                                    }
                                }
                                else
                                {
                                    if (!travelBuffString.ContainsKey(originalBuff))
                                        travelBuffString.Add(originalBuff, originalBuff);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.LogError($"[TravelMgr_Patch] Failed to deserialize translation file: {ex.Message}");
                        translatedTravelBuffs = MergeWithDumped(null);
                    }
                }

                RebuildTravelBuffString();
                _runtimeTravelBuffsDumped = true;
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
