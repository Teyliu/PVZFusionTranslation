#if false
using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;
using static PvZ_Fusion_Translator.FileLoader;

namespace PvZ_Fusion_Translator.Patches.Managers;

[HarmonyPatch(typeof(AlmanacPlantBank))]
public static partial class AlmanacPlantBank_Patch
{
    [HarmonyPatch(nameof(AlmanacPlantBank.InitNameAndInfoFromJson)), HarmonyPostfix]
    private static void InitNameAndInfoFromJson(Il2Cpp.AlmanacPlantBank __instance)
    {
        var (almanacDir, currentLanguage) = ModFeatures.IsMultiLanguage
            ? (GetAssetDir(AssetType.Almanac, Utils.Language), Utils.Language.ToString())
            : (GetAssetDir(AssetType.Almanac), "English");

        var path = Path.Combine(almanacDir, "LawnStringsTranslate.json");
        var moddedPath = Path.Combine(almanacDir, "ModdedPlantsTranslate.json");

        if (!File.Exists(path))
        {
            Log.LogError($"LawnStringsTranslate.json file not found at path: {path}");
            return;
        }

        var json = File.ReadAllText(path);
        var hasAlmanacFont = false;
        TMP_FontAsset almanacFontAsset = null;

        if (FontStore.fontAssetDictSecondary.ContainsKey(currentLanguage + "_Almanac") ||
            FontStore.fontAssetDictSecondary.ContainsKey(currentLanguage))
        {
            almanacFontAsset = FontStore.LoadTMPFontAlmanac(currentLanguage);
            hasAlmanacFont = true;
        }

        var fontAsset = ModFeatures.IsMultiLanguage
            ? FontStore.LoadTMPFont(Utils.Language.ToString())
            : FontStore.LoadTMPFont();

        TextMeshPro component = __instance.introduce.GetComponent<TextMeshPro>();
        TextMeshPro component2 = __instance.plantName.GetComponent<TextMeshPro>();
        TextMeshPro component3 = __instance.plantName.transform.GetChild(0).GetComponent<TextMeshPro>();
        TextMeshPro component4 = __instance.cost.GetComponent<TextMeshPro>();

        AlmanacPlantBank.PlantData plantData = JsonUtility.FromJson<AlmanacPlantBank.PlantData>(json);

        foreach (var plantInfo in plantData.plants)
        {
            if (plantInfo.seedType != __instance.theSeedType || string.IsNullOrEmpty(plantInfo.name))
                continue;

            component.autoSizeTextContainer = false;
            component.text = plantInfo.info + "\n\n" + plantInfo.introduce;
            component.overflowMode = TextOverflowModes.Page;

            // fix dimensions for cost text
            component.rectTransform.offsetMax = new(component.rectTransform.offsetMax.x, 27.3839f);
            component.rectTransform.offsetMin = new(component.rectTransform.offsetMin.x, -29.3079f);
            component.rectTransform.sizeDelta = new(component.rectTransform.sizeDelta.x, 50.917f);

            component.transform.localPosition = new(
                component.transform.localPosition.x,
                component.transform.localPosition.y + 0.15f,
                component.transform.localPosition.z
            );

            component2.text = plantInfo.name;
            component2.autoSizeTextContainer = true;

            component3.text = Utils.RemoveColorTags(plantInfo.name ?? string.Empty);
            component3.autoSizeTextContainer = true;

            component4.text = plantInfo.cost;

            if (hasAlmanacFont)
            {
                component.font = almanacFontAsset;
                component4.font = almanacFontAsset;
            }
            else
            {
                component.font = fontAsset;
                component4.font = fontAsset;
            }

            component2.font = fontAsset;
            component3.font = fontAsset;
        }

        if (!File.Exists(moddedPath))
            return;

        var moddedJson = File.ReadAllText(moddedPath);
        AlmanacPlantBank.PlantData moddedPlantData = JsonUtility.FromJson<AlmanacPlantBank.PlantData>(moddedJson);

        foreach (AlmanacPlantBank.PlantInfo plantInfo in moddedPlantData.plants)
        {
            if (plantInfo.seedType != __instance.theSeedType || string.IsNullOrEmpty(plantInfo.name))
                continue;

            component.autoSizeTextContainer = false;
            component.text = plantInfo.info + "\n\n" + plantInfo.introduce;
            component.overflowMode = TextOverflowModes.Page;

            // fix dimensions for cost text
            component.rectTransform.offsetMax = new(component.rectTransform.offsetMax.x, 27.3839f);
            component.rectTransform.offsetMin = new(component.rectTransform.offsetMin.x, -29.3079f);
            component.rectTransform.sizeDelta = new(component.rectTransform.sizeDelta.x, 50.917f);

            component.transform.localPosition = new(
                component.transform.localPosition.x,
                component.transform.localPosition.y + 0.15f,
                component.transform.localPosition.z
            );

            component2.text = plantInfo.name;
            component2.autoSizeTextContainer = true;

            component3.text = Utils.RemoveColorTags(plantInfo.name ?? string.Empty);
            component3.autoSizeTextContainer = true;

            component4.text = plantInfo.cost;

            if (hasAlmanacFont)
            {
                component.font = almanacFontAsset;
                component4.font = almanacFontAsset;
            }
            else
            {
                component.font = fontAsset;
                component4.font = fontAsset;
            }

            component2.font = fontAsset;
            component3.font = fontAsset;
        }
    }

    [HarmonyPatch(nameof(AlmanacPlantBank.OnMouseDown)), HarmonyPrefix]
    private static bool OnMouseDown(AlmanacPlantBank __instance)
    {
        TextMeshPro component = __instance.introduce.GetComponent<TextMeshPro>();

        if (component == null)
            return true;

        component.pageToDisplay =
            component.pageToDisplay > component.m_pageNumber ? 1 : component.pageToDisplay + 1;

        return false;
    }

    [HarmonyPatch(nameof(AlmanacPlantBank.PVPInit)), HarmonyPostfix] // ReSharper disable once InconsistentNaming
    private static void PVPInit(Il2Cpp.AlmanacPlantBank __instance)
    {
        TextMeshPro component = __instance.introduce.GetComponent<TextMeshPro>();

        if (component != null)
            component.autoSizeTextContainer = false;

        Transform banTransform = __instance.transform.FindChild("Ban").GetChild(0);

        if (banTransform != null)
            banTransform.GetComponent<TextMeshPro>().text =
                StringStore.TranslateText(banTransform.GetComponent<TextMeshPro>().text);
    }

    [HarmonyPatch(nameof(AlmanacPlantBank.Start)), HarmonyPostfix]
    public static void Post_Start(AlmanacPlantBank __instance)
    {
        GameObject skinTextObj = __instance.skinButton.transform.GetChild(0).gameObject;

        var skinShadowTextObj =
            UnityEngine.Object.Instantiate(skinTextObj, parent: __instance.skinButton.transform);

        var skinShadowText = skinShadowTextObj.GetComponent<TextMeshPro>();
        skinShadowText.text = StringStore.TranslateText("换肤_S");
        skinShadowText.sortingOrder -= 2;
        skinShadowTextObj.transform.Translate(new(0.015f, -0.015f, 0));
        skinTextObj.transform.Translate(new(-0.022f, 0));
        skinShadowTextObj.transform.Translate(new(-0.022f, 0));
        __instance.skinButton.transform.localScale /= 1.75f;
        __instance.skinButton.transform.Translate(new Vector3(-0.075f, -0.15f, 0));
        __instance.skinButton.transform.GetChild(1).Translate(new Vector3(0.35f, 0));
        __instance.skinButton.transform.GetChild(2).Translate(new Vector3(-0.35f, 0));
    }
}
#endif
