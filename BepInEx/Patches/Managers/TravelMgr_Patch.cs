using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.RegularExpressions;
using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using Il2CppSystem;
using Il2CppInterop.Runtime;

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

        private static System.DateTime _lastDumpWriteTime = System.DateTime.MinValue;
        private static bool _runtimeTravelBuffsDumped = false;
        private static HashSet<string> _titleMatchedTranslations = new HashSet<string>();

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

            string category;
            int buffIndex;
            if (!TryGetBuffIndex(buff, out category, out buffIndex))
                return false;

            return TryGetTranslatedBuff(category, buffIndex, out translated);
        }

        private static bool TryGetBuffIndex(object buff, out string category, out int buffIndex)
        {
            category = "";
            buffIndex = -1;

            var il2Obj = buff as Il2CppSystem.Object;
            if (il2Obj == null)
                return false;

            var buffType = il2Obj.GetIl2CppType();

            if (buffType == Il2CppType.From(typeof(AdvBuff)))
            {
                category = "advancedBuffs";
                buffIndex = (int)il2Obj.Unbox<AdvBuff>();
                return true;
            }
            if (buffType == Il2CppType.From(typeof(UltiBuff)))
            {
                category = "ultimateBuffs";
                buffIndex = (int)il2Obj.Unbox<UltiBuff>();
                return true;
            }
            if (buffType == Il2CppType.From(typeof(TravelUnlocks)))
            {
                category = "unlocks";
                buffIndex = (int)il2Obj.Unbox<TravelUnlocks>();
                return true;
            }
            if (buffType == Il2CppType.From(typeof(TravelDebuff)))
            {
                category = "debuffs";
                buffIndex = (int)il2Obj.Unbox<TravelDebuff>();
                return true;
            }
            if (buffType == Il2CppType.From(typeof(InvestBuff)))
            {
                category = "investmentBuffs";
                buffIndex = (int)il2Obj.Unbox<InvestBuff>();
                return true;
            }

            return false;
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
            _titleMatchedTranslations.Clear();

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

            // Step 3: Title-based matching fallback for entries with mismatched indices
            int titleMatchCount = 0;
            foreach (var cat in translatedTravelBuffs)
            {
                if (cat.Value == null) continue;

                foreach (var translatedEntry in cat.Value)
                {
                    string viText = translatedEntry.Value;
                    if (string.IsNullOrEmpty(viText)) continue;

                    if (_titleMatchedTranslations.Contains(viText)) continue;
                    if (travelBuffString.ContainsValue(viText)) continue;

                    string viTitle = GetBuffTitle(viText);
                    if (string.IsNullOrEmpty(viTitle)) continue;

                    // Find Chinese title by reverse-looking in StringStore.translationString
                    string foundChineseTitle = null;
                    foreach (var ss in StringStore.translationString)
                    {
                        if (ss.Value == viTitle)
                        {
                            foundChineseTitle = ss.Key;
                            break;
                        }
                    }
                    if (string.IsNullOrEmpty(foundChineseTitle)) continue;

                    bool matched = false;

                    // Method A: Search dumpedTravelBuffs (game data with correct enum values)
                    foreach (var dumpCat in dumpedTravelBuffs)
                    {
                        if (dumpCat.Value == null) continue;
                        foreach (var dumpEntry in dumpCat.Value)
                        {
                            string dumpTitle = GetBuffTitle(dumpEntry.Value);
                            if (dumpTitle == foundChineseTitle)
                            {
                                travelBuffString[dumpEntry.Value] = viText;
                                _titleMatchedTranslations.Add(viText);

                                string withoutName = RemoveBuffName(dumpEntry.Value);
                                if (!string.IsNullOrEmpty(withoutName) && withoutName != dumpEntry.Value)
                                    travelBuffString[withoutName] = viText;

                                titleMatchCount++;
#if DEBUG
                                Log.LogInfo($"[TravelMgr_Patch][TitleMatch:GameDump] {cat.Key}[{translatedEntry.Key}]: \"{dumpEntry.Value}\" -> \"{viText}\" (title: \"{foundChineseTitle}\" <-> \"{viTitle}\")");
#endif
                                matched = true;
                                break;
                            }
                        }
                        if (matched) break;
                    }

                    // Method B (fallback): Search StringStore.translationString for buff entries with same Chinese title
                    if (!matched)
                    {
                        foreach (var ss in StringStore.translationString)
                        {
                            string ssTitle = GetBuffTitle(ss.Key);
                            if (ssTitle == foundChineseTitle)
                            {
                                if (travelBuffString.ContainsKey(ss.Key)) continue;

                                travelBuffString[ss.Key] = viText;
                                _titleMatchedTranslations.Add(viText);

                                string withoutName = RemoveBuffName(ss.Key);
                                if (!string.IsNullOrEmpty(withoutName) && withoutName != ss.Key)
                                    travelBuffString[withoutName] = viText;

                                titleMatchCount++;
                                matched = true;
#if DEBUG
                                Log.LogInfo($"[TravelMgr_Patch][TitleMatch:StringStore] {cat.Key}[{translatedEntry.Key}]: \"{ss.Key}\" -> \"{viText}\" (title: \"{foundChineseTitle}\" <-> \"{viTitle}\")");
#endif
                                break;
                            }
                        }
                    }
                }
            }

#if DEBUG
            Log.LogInfo($"[TravelMgr_Patch] Rebuilt travelBuffString: {travelBuffString.Count} entries ({titleMatchCount} title-matched)");
#endif
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

            string bestResult = "";
            int matchCount = 0;
            foreach (var entry in StringStore.translationString)
            {
                if (GetBuffTitle(entry.Key) == originalTitle && !string.IsNullOrEmpty(entry.Value))
                {
                    matchCount++;
                    if (string.IsNullOrEmpty(bestResult) && !ContainsChinese(entry.Value))
                        bestResult = entry.Value;
                }
            }

            return bestResult;
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

            string splitTranslated = TranslateBySplitDescription(originalText);
            if (splitTranslated != originalText)
                return splitTranslated;

            string matched = MatchTravelBuff(originalText);
            if (!string.IsNullOrEmpty(matched) && !ContainsChinese(matched))
                return matched;

            matched = MatchTranslationStringByTitle(originalText);
            if (!string.IsNullOrEmpty(matched) && !ContainsChinese(matched))
                return matched;

            // Runtime title-based fallback: game text may have been updated but still shares the same title
            string runtimeTitle = GetBuffTitle(originalText);
            if (!string.IsNullOrEmpty(runtimeTitle))
            {
                foreach (var tbs in travelBuffString)
                {
                    if (GetBuffTitle(tbs.Key) == runtimeTitle && !ContainsChinese(tbs.Value))
                    {
#if DEBUG
                        Log.LogInfo($"[TravelMgr_Patch][RuntimeTitleMatch] \"{originalText}\" -> \"{tbs.Value}\" (title: \"{runtimeTitle}\")");
#endif
                        return tbs.Value;
                    }
                }
            }

            // Last resort: search translatedTravelBuffs directly by title (handles entries not in StringStore or dump)
            if (!string.IsNullOrEmpty(runtimeTitle))
            {
                foreach (var cat in translatedTravelBuffs)
                {
                    if (cat.Value == null) continue;
                    foreach (var entry in cat.Value)
                    {
                        string viText = entry.Value;
                        if (string.IsNullOrEmpty(viText) || ContainsChinese(viText)) continue;

                        string viTitle = GetBuffTitle(viText);
                        if (string.IsNullOrEmpty(viTitle)) continue;

                        foreach (var ss in StringStore.translationString)
                        {
                            if (ss.Value == viTitle && GetBuffTitle(ss.Key) == runtimeTitle)
                            {
#if DEBUG
                                Log.LogInfo($"[TravelMgr_Patch][DirectTitleMatch] \"{originalText}\" -> \"{viText}\" (cat:{cat.Key}[{entry.Key}], title:\"{runtimeTitle}\")");
#endif
                                return viText;
                            }
                        }
                    }
                }
            }

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

        public static string TranslateBySplitDescription(string originalText)
        {
            int colonIndex = originalText.IndexOf("：");
            if (colonIndex <= 0) return originalText;

            string title = originalText.Substring(0, colonIndex);
            string description = originalText.Substring(colonIndex + 1);

            if (string.IsNullOrEmpty(description)) return originalText;

            string titleVi = null;
            if (!string.IsNullOrEmpty(title)
                && StringStore.translationString.TryGetValue(title, out string tVi)
                && !string.IsNullOrEmpty(tVi)
                && tVi != title)
            {
                titleVi = tVi;
            }

            if (StringStore.translationString.TryGetValue(description, out string descVi)
                && !string.IsNullOrEmpty(descVi)
                && descVi != description)
            {
                string result = (titleVi ?? title) + "：" + descVi;
#if DEBUG
                Log.LogInfo($"[TravelMgr_Patch][SplitTranslate] \"{originalText}\" -> \"{result}\"");
#endif
                return result;
            }

            if (titleVi != null)
            {
                string result = titleVi + "：" + description;
#if DEBUG
                Log.LogInfo($"[TravelMgr_Patch][SplitTranslate] \"{originalText}\" -> \"{result}\" (title only)");
#endif
                return result;
            }

            return originalText;
        }

        [HarmonyPatch(nameof(TravelMgr.GetText))]
        [HarmonyPostfix]
        public static void GetText(TravelMgr __instance, object buff, ref string __result)
        {
            if (string.IsNullOrEmpty(__result))
                return;

            string original = __result;
            string category = null;
            int buffIndex = -1;

            if (buff != null)
                TryGetBuffIndex(buff, out category, out buffIndex);

            string buffDebug = (category != null) ? $"{category}[{buffIndex}]" : "?";

            // Fix "未知索引" input: look up actual Chinese text from dumped game data
            if (original == "未知索引" && category != null)
            {
                string foundText = null;
                if (dumpedTravelBuffs.TryGetValue(category, out var catData) && catData != null)
                    catData.TryGetValue(buffIndex, out foundText);

                if (!string.IsNullOrEmpty(foundText) && foundText != "未知索引")
                    original = foundText;
            }

#if DEBUG
            Log.LogMessage($"==== TravelMgr.GetText | buff={buffDebug} ====");
#endif
#if DEBUG
            Log.LogInfo($"Input: \"{original}\"");
#endif

            string travelTranslated = TryGetTranslatedBuff(buff, out string translatedByBuff)
                ? translatedByBuff
                : TranslateTravelText(original);
            if (travelTranslated != original)
            {
                __result = travelTranslated;
#if DEBUG
                Log.LogInfo($"Travel HIT: \"{original}\" -> \"{__result}\"");
#endif
            }
            else
            {
#if DEBUG
                Log.LogWarning($"NO TRANSLATION: \"{original}\"");
#endif
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
                catch (System.Exception ex)
                {
#if DEBUG
                    Log.LogWarning($"[TravelMgr_Patch] Failed to load buff file {path}: {ex.Message}");
#endif
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
            catch (System.Exception ex)
            {
#if DEBUG
                Log.LogWarning($"[TravelMgr_Patch] LoadTravelBuffsFlexible failed: {ex.Message}");
#endif
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
                if (!force && System.DateTime.Now - _lastDumpWriteTime < System.TimeSpan.FromSeconds(2))
                    return;

                _lastDumpWriteTime = System.DateTime.Now;
            }
            catch (System.Exception ex)
            {
#if DEBUG
                Log.LogWarning($"[TravelMgr_Patch] Failed to save dump file: {ex.Message}");
#endif
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

#if DEBUG
            Log.LogInfo("[TravelMgr_Patch] Loaded buff data from file fallback.");
#endif
        }

        public static void DumpTravelBuffs()
        {
#if DEBUG
            Log.LogInfo("[TravelMgr_Patch] DumpTravelBuffs called");
#endif

            ResetBuffCache(dumpedTravelBuffs);
            ResetBuffCache(translatedTravelBuffs);

            TravelMgr instance = GetTravelMgrInstance();
            if (instance == null && !HasRuntimeTravelData())
            {
#if DEBUG
                Log.LogWarning("[TravelMgr_Patch] TravelMgr instance is null! Using file fallback and TravelLookMenu capture.");
#endif
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
                    catch (System.Exception ex)
                    {
#if DEBUG
                        Log.LogWarning($"[TravelMgr_Patch] TravelMgr warmup failed, continuing with TravelDictionary data: {ex.Message}");
#endif
                    }
                }

                if (TravelDictionary.advancedBuffsText != null)
                {
#if DEBUG
                    Log.LogInfo($"[TravelMgr_Patch] Dumping advancedBuffs: {TravelDictionary.advancedBuffsText.Count} items");
#endif
                    foreach (var pair in TravelDictionary.advancedBuffsText)
                    {
                        int enumId = (int)pair.Key;
                        string advBuffText = pair.Value;
                        AddOrUpdate(dumpedTravelBuffs, "advancedBuffs", enumId, advBuffText);
                        if (!travelBuffString.ContainsKey(advBuffText))
                            travelBuffString.Add(advBuffText, advBuffText);
#if DEBUG
                        Log.LogInfo($"[TravelMgr_Patch][Dump] advancedBuffs[{enumId}] = \"{advBuffText}\"");
#endif
                    }
                }

                if (TravelDictionary.ultimateBuffsText != null)
                {
#if DEBUG
                    Log.LogInfo($"[TravelMgr_Patch] Dumping ultimateBuffs: {TravelDictionary.ultimateBuffsText.Count} items");
#endif
                    foreach (var pair in TravelDictionary.ultimateBuffsText)
                    {
                        int enumId = (int)pair.Key;
                        string ultBuffText = pair.Value;
                        AddOrUpdate(dumpedTravelBuffs, "ultimateBuffs", enumId, ultBuffText);
                        if (!travelBuffString.ContainsKey(ultBuffText))
                            travelBuffString.Add(ultBuffText, ultBuffText);
#if DEBUG
                        Log.LogInfo($"[TravelMgr_Patch][Dump] ultimateBuffs[{enumId}] = \"{ultBuffText}\"");
#endif
                    }
                }

                if (TravelDictionary.debuffData != null)
                {
#if DEBUG
                    Log.LogInfo($"[TravelMgr_Patch] Dumping debuffs: {TravelDictionary.debuffData.Count} items");
#endif
                    foreach (var pair in TravelDictionary.debuffData)
                    {
                        int enumId = (int)pair.Key;
                        string debuffText = pair.Value.Item1;
                        AddOrUpdate(dumpedTravelBuffs, "debuffs", enumId, debuffText);
                        if (!travelBuffString.ContainsKey(debuffText))
                            travelBuffString.Add(debuffText, debuffText);
#if DEBUG
                        Log.LogInfo($"[TravelMgr_Patch][Dump] debuffs[{enumId}] = \"{debuffText}\"");
#endif
                    }
                }

                if (TravelDictionary.unlocksText != null)
                {
#if DEBUG
                    Log.LogInfo($"[TravelMgr_Patch] Dumping unlocks: {TravelDictionary.unlocksText.Count} items");
#endif
                    foreach (var pair in TravelDictionary.unlocksText)
                    {
                        int enumId = (int)pair.Key;
                        string unlockText = pair.Value;
                        AddOrUpdate(dumpedTravelBuffs, "unlocks", enumId, unlockText);
                        if (!travelBuffString.ContainsKey(unlockText))
                            travelBuffString.Add(unlockText, unlockText);
#if DEBUG
                        Log.LogInfo($"[TravelMgr_Patch][Dump] unlocks[{enumId}] = \"{unlockText}\"");
#endif
                    }
                }

                if (TravelMgr.InvestBuffsData != null)
                {
#if DEBUG
                    Log.LogInfo($"[TravelMgr_Patch] Dumping investmentBuffs: {TravelMgr.InvestBuffsData.Count} items");
#endif
                    foreach (var pair in TravelMgr.InvestBuffsData)
                    {
                        int enumId = (int)pair.Key;
                        string desc = pair.Value.GetDescription();
                        AddOrUpdate(dumpedTravelBuffs, "investmentBuffs", enumId, desc);
                        if (!travelBuffString.ContainsKey(desc))
                            travelBuffString.Add(desc, desc);
#if DEBUG
                        Log.LogInfo($"[TravelMgr_Patch][Dump] investmentBuffs[{enumId}] = \"{desc}\"");
#endif
                    }
                }

                if (TravelMgr.SynergysData != null)
                {
#if DEBUG
                    Log.LogInfo($"[TravelMgr_Patch] Dumping synergies: {TravelMgr.SynergysData.Count} items");
#endif
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
                        catch (System.Exception ex)
                        {
#if DEBUG
                            Log.LogWarning($"[TravelMgr_Patch] Error getting synergy description: {ex.Message}");
#endif
                        }

                        if (!string.IsNullOrEmpty(synergyDesc))
                        {
                            int synEnumId = (int)pair.Key;
                            AddOrUpdate(dumpedTravelBuffs, "synergies", synEnumId, synergyDesc);
#if DEBUG
                            Log.LogInfo($"[TravelMgr_Patch][Dump] synergies[{synEnumId}] = \"{synergyDesc}\"");
#endif
                        }
                    }
                }

                string dumpDir = FileLoader.GetAssetDir(FileLoader.AssetType.Dumps);
                string jsonPath = Path.Combine(dumpDir, "travel_buffs.json");
                File.WriteAllText(jsonPath, JsonSerializer.Serialize(dumpedTravelBuffs, JsonOptions));
                _lastDumpWriteTime = System.DateTime.Now;
#if DEBUG
                Log.LogInfo($"[TravelMgr_Patch] Dumped travel_buffs.json to {jsonPath}");
#endif

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

                        int indexMatchCount = 0, indexMismatchCount = 0;
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
                                    indexMatchCount++;
#if DEBUG
                                    Log.LogInfo($"[TravelMgr_Patch][IndexMatch] {cat.Key}[{entry.Key}]: FOUND -> \"{translatedBuff}\"");
#endif
                                }
                                else
                                {
                                    if (!travelBuffString.ContainsKey(originalBuff))
                                        travelBuffString.Add(originalBuff, originalBuff);
                                    indexMismatchCount++;
#if DEBUG
                                    Log.LogInfo($"[TravelMgr_Patch][IndexMismatch] {cat.Key}[{entry.Key}]: \"{originalBuff}\" has NO translation at index {entry.Key}");
#endif
                                }
                            }
                        }
#if DEBUG
                        Log.LogInfo($"[TravelMgr_Patch] Index matching: {indexMatchCount} matched, {indexMismatchCount} unmatched");
#endif
                    }
                    catch (System.Exception ex)
                    {
#if DEBUG
                        Log.LogError($"[TravelMgr_Patch] Failed to deserialize translation file: {ex.Message}");
#endif
                        translatedTravelBuffs = MergeWithDumped(null);
                    }
                }

                RebuildTravelBuffString();
                _runtimeTravelBuffsDumped = true;
#if DEBUG
                Log.LogInfo("[TravelMgr_Patch] DumpTravelBuffs completed");
#endif
            }
            catch (System.Exception ex)
            {
#if DEBUG
                UnityEngine.Debug.LogError($"[TravelMgr_Patch] Error dumping travel buffs: {ex.Message}");
#endif
#if DEBUG
                Log.LogError($"[TravelMgr_Patch] Stack trace: {ex.StackTrace}");
#endif
            }
        }
    }
}
