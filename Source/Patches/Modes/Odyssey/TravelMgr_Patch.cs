using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey;

public sealed class TravelBuffInfo(string nameA = "", string descA = "")
{
    public readonly string Name = nameA;
    public readonly string Desc = descA;
}

public sealed class TravelBuffSet
{
    public readonly SortedDictionary<int, TravelBuffInfo>
        AdvancedBuffs,
        UltimateBuffs,
        Debuffs,
        Unlocks,
        InvestmentBuffs;

    private readonly Dictionary<string, SortedDictionary<int, TravelBuffInfo>> _travelBuffSets;

    public TravelBuffSet()
    {
        AdvancedBuffs = new();
        UltimateBuffs = new();
        Debuffs = new();
        Unlocks = new();
        InvestmentBuffs = new();

        _travelBuffSets = new()
        {
            { "advancedBuffs", AdvancedBuffs },
            { "ultimateBuffs", UltimateBuffs },
            { "debuffs", Debuffs },
            { "unlocks", Unlocks },
            { "investmentBuffs", InvestmentBuffs },
        };
    }

    public SortedDictionary<int, TravelBuffInfo> TryGet(string name) =>
        name switch
        {
            "advancedBuffs" => AdvancedBuffs,
            "ultimateBuffs" => UltimateBuffs,
            "debuffs" => Debuffs,
            "unlocks" => Unlocks,
            "investmentBuffs" => InvestmentBuffs,
            _ => null,
        };

    public IEnumerator<ValueTuple<string, SortedDictionary<int, TravelBuffInfo>>> GetEnumerator() =>
        _travelBuffSets.Select(item => (item.Key, item.Value)).GetEnumerator();
}

[HarmonyPatch(typeof(TravelMgr))]
public static class TravelMgr_Patch
{
    public static readonly TravelBuffSet TemplateTravelBuffs = new();

    public static readonly Dictionary<string, string> TravelBuffString = new();
#pragma warning disable CA2211
    public static TravelBuffSet DumpedTravelBuffs = new();

    public static TravelBuffSet TranslatedTravelBuffs = new();

    public static Dictionary<BuffType, string> BuffLinks = new()
    {
        { BuffType.AdvancedBuff, "advancedBuffs" },
        { BuffType.UltimateBuff, "ultimateBuffs" },
        { BuffType.Debuff, "debuffs" },
        { BuffType.UnlockPlant, "unlocks" },
        { BuffType.InvestmentBuff, "investmentBuffs" },
    };
#pragma warning restore CA2211
    [HarmonyPatch(nameof(TravelMgr.GetText)), HarmonyPostfix]
    public static void GetText(TravelMgr __instance, ref string result)
    {
        if (TravelBuffString.TryGetValue(result, out var value))
            result = value;
        else if (TravelBuffString.ContainsKey(RemoveBuffName(result)))
            result = TravelBuffString[RemoveBuffName(result)];
        else
            result = StringStore.TranslateText(result);
    }

    public static void DumpTravelBuffs()
    {
        TravelMgr.Instance.GetPlantBuffUnlockCount(PlantType.DoomGatling);

        DumpedTravelBuffs = new();
        TravelBuffString.Clear();

        foreach (var pair in TravelDictionary.advancedBuffsText)
        {
            Utils.TryAdd(DumpedTravelBuffs.AdvancedBuffs, (int)pair.Key, new("", pair.Value));
            Utils.TryAdd(TravelBuffString, pair.Value, pair.Value);
        }

        foreach (var pair in TravelDictionary.ultimateBuffsText)
        {
            Utils.TryAdd(DumpedTravelBuffs.UltimateBuffs, (int)pair.Key, new("", pair.Value));
            Utils.TryAdd(TravelBuffString, pair.Value, pair.Value);
        }

        foreach (var pair in TravelDictionary.debuffData)
        {
            Utils.TryAdd(DumpedTravelBuffs.Debuffs, (int)pair.Key, new("", pair.Value.Item1));
            Utils.TryAdd(TravelBuffString, pair.Value.Item1, pair.Value.Item1);
        }

        foreach (var pair in TravelDictionary.unlocksText)
        {
            Utils.TryAdd(DumpedTravelBuffs.Unlocks, (int)pair.Key, new("", pair.Value));
            Utils.TryAdd(TravelBuffString, pair.Value, pair.Value);
        }

        foreach (var pair in TravelMgr.InvestBuffsData)
        {
            Utils.TryAdd(
                DumpedTravelBuffs.InvestmentBuffs,
                (int)pair.Key,
                new("", pair.Value.Description)
            );

            Utils.TryAdd(TravelBuffString, pair.Value.Description, pair.Value.Description);
        }

        File.WriteAllText(
            Path.Combine(FileLoader.GetAssetDir(FileLoader.AssetType.Dumps), "travel_buffs.json"),
            FileLoader.SerializeWithIndentation(DumpedTravelBuffs)
        );

        var translatedTravelBuffsPath = Path.Combine(
            FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language),
            "travel_buffs.json"
        );

        if (File.Exists(translatedTravelBuffsPath))
            return;

        File.WriteAllText(translatedTravelBuffsPath, FileLoader.SerializeWithIndentation(DumpedTravelBuffs));
        TranslatedTravelBuffs = DumpedTravelBuffs;
    }

    //System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, SortedDictionary<int, string>>>(travelBuffsContent);
    public static void GenerateTranslatedTravelBuffs(string travelBuffsContent)
    {
        if (!Core.IsInitialized)
            return;

        DumpTravelBuffs();

        var travelBuffs = Newtonsoft.Json.JsonConvert.DeserializeObject<TravelBuffSet>(travelBuffsContent);
        TranslatedTravelBuffs = travelBuffs;
        TravelBuffString.Clear();

        foreach (var i in travelBuffs)
        {
            var originalBuffSet = DumpedTravelBuffs.TryGet(i.Item1);

            foreach (var (key, originalBuff) in originalBuffSet)
            {
                var translatedBuffSet = travelBuffs.TryGet(i.Item1);

                if (originalBuff.Desc != RemoveBuffName(originalBuff.Desc))
                    continue;

                if (translatedBuffSet.TryGetValue(key, out var value))
                    Utils.TryAdd(TravelBuffString, originalBuff.Desc, value.Desc);
#if false
                var translatedBuffSet = travelBuffs[i.Key];

                if (!translatedBuffSet.ContainsKey(j.Key))
                    continue;

                string translatedBuff = travelBuffs[i.Key][j.Key];
                travelBuffString[originalBuff] = translatedBuff;
#endif
            }
        }

        var travelBuffsToSave = FileLoader.SerializeWithIndentation(TranslatedTravelBuffs);
        var stringDir = FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language);
        File.WriteAllText(Path.Combine(stringDir, "travel_buffs.json"), travelBuffsToSave);
    }

    public static string MatchTravelBuff(string originalText)
    {
        var res = "";

        foreach (var i in DumpedTravelBuffs)
        {
            foreach (var j in DumpedTravelBuffs.TryGet(i.Item1))
                if (j.Value.Desc == originalText || j.Value.Desc == RemoveBuffName(originalText))
                {
                    var translatedBuffSet = TranslatedTravelBuffs.TryGet(i.Item1);

                    if (translatedBuffSet.TryGetValue(j.Key, out var value))
                        res = value.Desc;

                    break;
                }

            if (res != "")
                break;
        }

        return res;
    }

    public static string RemoveBuffName(string buffText)
    {
        var res = buffText;
        var firstColon = res.IndexOf("：", StringComparison.Ordinal);

        if (firstColon > 0)
            res = res[(firstColon + 1)..];

        return res;
    }

    public static readonly Dictionary<string, string> ModifierNameDict = new()
    {
        { "advancedBuffs", "COMMON_MODIFIER_TAG" },
        { "ultimateBuffs", "EPIC_MODIFIER_TAG" },
        { "debuffs", "ZOMBIE_MODIFIER_TAG" },
        { "unlocks", "UNLOCK_MODIFIER_TAG" },
        { "investmentBuffs", "INVEST_MODIFIER_TAG" },
    };

    public static readonly Dictionary<string, string> FallbackNameDict = new()
    {
        { "COMMON_MODIFIER_TAG", "Common Modifier" },
        { "EPIC_MODIFIER_TAG", "Epic Modifier" },
        { "ZOMBIE_MODIFIER_TAG", "Zombie Modifier" },
        { "UNLOCK_MODIFIER_TAG", "Unlock Modifier" },
        { "INVEST_MODIFIER_TAG", "Investment Modifier" },
    };

    public static string TranslateNameTag(string originalText)
    {
        var nameTag = ModifierNameDict[originalText];

        return StringStore.TranslationString.ContainsKey(nameTag)
            ? StringStore.TranslateText(nameTag)
            : FallbackNameDict[nameTag];
    }

    public static ValueTuple<string, int, string, bool> FindBuffData(string buffText)
    {
        ValueTuple<string, int, string, bool> res = new();

        foreach (var pair1 in TranslatedTravelBuffs)
        {
            foreach (var pair2 in pair1.Item2.Where(pair2 => buffText == pair2.Value.Desc))
            {
                if (pair2.Value.Name != "")
                {
                    res.Item1 = pair2.Value.Name;
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

        foreach (var pair1 in DumpedTravelBuffs)
        {
            foreach (var pair2 in pair1.Item2.Where(pair2 => buffText == pair2.Value.Desc))
            {
                (res.Item1, res.Item4) = pair2.Value.Name != ""
                    ? (pair2.Value.Name, true)
                    : (TranslateNameTag(pair1.Item1), false);

                res.Item2 = pair2.Key;
            }
        }

        var finalBuffText = TravelBuffString.TryGetValue(buffText, out var value)
            ? value
            : StringStore.TranslateText(buffText);

        res.Item3 = finalBuffText;

        return res;
    }

    // public static string FallbackFBuffStr = "{0}: {1}";

    public static string AddBuffName(string buffText)
    {
        var translatedBuff = buffText;

        if (Utils.CheckForUntranslatedText(buffText))
            if (TravelBuffString.TryGetValue(buffText, out var value))
                translatedBuff = value;

        var buffData = FindBuffData(translatedBuff);

        if (buffData is not { Item1: not null, Item3: not null })
            return translatedBuff;

        var buffFStr = StringStore.TranslationStringRegex.GetValueOrDefault("BUFF_NAME_FORMAT", "{0}: {1}");
        return string.Format(buffFStr, buffData.Item1, buffData.Item3);
    }
}
