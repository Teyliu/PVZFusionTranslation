using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(AlmanacPlantMenu))]
public static class AlmanacPlantMenu_Patch
{
#pragma warning disable CA2211
    public static string AlmanacJson = "";
#pragma warning restore CA2211
    public static readonly Dictionary<int, Il2CppPlantInfo> PlantInfoDict = new();

    [HarmonyPatch(nameof(AlmanacPlantMenu.Awake)), HarmonyPostfix]
    private static void Awake(AlmanacPlantMenu __instance)
    {
        var font = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var text in from text in __instance.GetComponentsInChildren<TextMeshProUGUI>(true)
            let isPlantName = text.gameObject.name.Contains("Name") && text.transform.parent.name != "Background"
            where text.gameObject.name != "Description" && !isPlantName && !text.gameObject.name.Contains("Cost")
            select text)
        {
            text.text = StringStore.TranslateText(text.text);
            text.font = font;
            text.autoSizeTextContainer = true;
        }

        foreach (var almanacCardUI in __instance.GetComponentsInChildren<AlmanacCardUI>())
            AlmanacCardUI_Patch.Awake(almanacCardUI);

        // skin button resize

        var window = __instance.window;
        var skinButton = window.skinButton;
        // var skinTextObj = skinButton.transform.Find("text_1").gameObject;
        skinButton.transform.localScale /= 1.75f;
        skinButton.transform.localPosition = new(0.0f, 111.345f, 0.0f);
        skinButton.transform.GetChild(1).Translate(new(-0.35f, 0));
        skinButton.transform.GetChild(2).Translate(new(0.35f, 0));
    }

    [HarmonyPatch(nameof(AlmanacPlantMenu.SearchChanged)), HarmonyPrefix]
    public static bool SearchChanged(AlmanacPlantMenu __instance, ref TMP_InputField inputField)
    {
        var search = inputField.text;

        if (search == StringStore.TranslateText("搜索") || search == "")
            return true;

        var currentLanguage = Utils.Language.ToString();
        // var almanacDir = GetAssetDir(AssetType.Almanac, Utils.Language);
        // var path = Path.Combine(almanacDir, "LawnStringsTranslate.json");
        _ = FontStore.LoadTMPFont(currentLanguage);

        var plantData = JsonUtility.FromJson<Il2CppAlmanacDataClass>(AlmanacJson);
        Il2CppSystem.Collections.Generic.List<PlantType> searchedPlants = new();

        foreach (var plantInfo in plantData.plants)
            if (plantInfo.name.ToLower().Contains(search.ToLower()) ||
                $"{plantInfo.seedType}".ToLower().StartsWith(search.ToLower()))
                searchedPlants.Add((PlantType)plantInfo.seedType);

        __instance.ShowPlants(searchedPlants);
        return false;
    }

    [HarmonyPatch(nameof(AlmanacPlantMenu.ShowPlants), typeof(Il2CppSystem.Func<PlantType, bool>)),
     HarmonyPostfix]
    public static void ShowPlants(AlmanacPlantMenu __instance, ref Func<PlantType, bool> condition)
    {
        foreach (var cardUI in __instance.cards)
            AlmanacCardUI_Patch.Awake(cardUI);
    }

    [HarmonyPatch(nameof(AlmanacPlantMenu.ClassicMix)), HarmonyPostfix]
    public static void ClassicMix(AlmanacPlantMenu __instance)
    {
        foreach (var cardUI in __instance.cards)
            AlmanacCardUI_Patch.Awake(cardUI);
    }

    public static void LoadPlantAlmanacData(string json)
    {
        if (json == null)
            return;

        AlmanacJson = json;
        var plantData = JsonUtility.FromJson<Il2CppAlmanacDataClass>(AlmanacJson);

        foreach (var plantInfo in plantData.plants)
            PlantInfoDict[plantInfo.seedType] = plantInfo;
    }
}
