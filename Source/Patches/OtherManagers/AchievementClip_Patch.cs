#if false
using HarmonyLib;
using Newtonsoft.Json;
using PvZ_Fusion_Translator.AssetStore;
using static PvZ_Fusion_Translator.FileLoader;
using static PvZ_Fusion_Translator.Patches.Managers.AlmanacPlantBank_Patch;

namespace PvZ_Fusion_Translator.Patches.OtherManagers;

[HarmonyPatch(typeof(AchievementClip))]
public static class AchievementClip_Patch
{
    [HarmonyPatch(nameof(AchievementClip.Start)), HarmonyPostfix]
    private static void Start(AchievementClip __instance)
    {
        var (achievementDir, fontAsset) = ModFeatures.IsMultiLanguage
            ? (GetAssetDir(AssetType.Almanac, Utils.Language), FontStore.LoadTMPFont(Utils.Language.ToString()))
            : (GetAssetDir(AssetType.Almanac), FontStore.LoadTMPFont());

        var path = Path.Combine(achievementDir, "AchievementsTextTranslate.json");

        if (!File.Exists(path))
            return;

        var json = File.ReadAllText(path);

        Dictionary<Achievement, AchievementObject> achievementsTexts =
            new Dictionary<Achievement, AchievementObject>();

        achievementsTexts = JsonConvert.DeserializeObject<Dictionary<Achievement, AchievementObject>>(json);

        TextMeshProUGUI text1 = __instance.introduce.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI text2 = __instance.introduce.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI name1 = __instance.image.transform.GetChild(0).GetComponent<TextMeshProUGUI>();

        text1.text = achievementsTexts[__instance._index].Name;
        text1.font = fontAsset;
        text2.text = achievementsTexts[__instance._index].Name;
        text2.font = fontAsset;
        name1.text = achievementsTexts[__instance._index].Text;
        name1.font = fontAsset;
    }
}

// ReSharper disable once ClassNeverInstantiated.Global
public sealed class AchievementObject
{
    public Achievement achievement { get; set; }

    // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
    public string Name { get; set; }

    // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
    public string Text { get; set; }

    public AchievementObject(Achievement achievement = Achievement.Welcome, string name = "", string text = "")
    {
        this.achievement = achievement;
        Name = name;
        Text = text;
    }
}
#endif
