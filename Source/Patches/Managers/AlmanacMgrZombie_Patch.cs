#if false
using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;
using static PvZ_Fusion_Translator.FileLoader;

namespace PvZ_Fusion_Translator.Patches.Managers;

[HarmonyPatch(typeof(AlmanacMgrZombie))]
public static partial class AlmanacMgrZombie_Patch
{
    [HarmonyPatch(nameof(AlmanacMgrZombie.InitNameAndInfoFromJson)), HarmonyPostfix]
    private static void InitNameAndInfoFromJson(AlmanacMgrZombie __instance)
    {
        var (almanacDir, currentLanguage) = ModFeatures.IsMultiLanguage
            ? (GetAssetDir(AssetType.Almanac, Utils.Language), Utils.Language.ToString())
            : (GetAssetDir(AssetType.Almanac), "English");

        var path = Path.Combine(almanacDir, "ZombieStringsTranslate.json");
        var moddedPath = Path.Combine(almanacDir, "ModdedZombiesTranslate.json");

        if (!File.Exists(path))
        {
            Log.LogError($"ZombieStringsTranslate.json file not found at path: {path}");
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

        FontStore.LoadTMPFont(ModFeatures.IsMultiLanguage ? Utils.Language.ToString() : null);
        TextMeshPro component = __instance.info.GetComponent<TextMeshPro>();
        TextMeshPro component2 = __instance.zombieName.GetComponent<TextMeshPro>();
        TextMeshPro component3 = __instance.zombieName.transform.GetChild(0).GetComponent<TextMeshPro>();

        var zombieData = JsonUtility.FromJson<ZombieAlmanacData>(json);

        foreach (ZombieInfo zombieInfo in zombieData.zombies)
            if (zombieInfo.theZombieType == __instance.theZombieType)
            {
                component.text = zombieInfo.info + "\n\n" + zombieInfo.introduce;
                component.overflowMode = TextOverflowModes.Page;
                component2.text = zombieInfo.name;
                component2.autoSizeTextContainer = true;
                component3.text = Utils.RemoveColorTags(zombieInfo.name);
                component3.autoSizeTextContainer = true;
                component.font = hasAlmanacFont ? almanacFontAsset : fontAsset;
                component2.font = fontAsset;
                component3.font = fontAsset;
            }

        if (!File.Exists(moddedPath))
            return;

        var moddedJson = File.ReadAllText(moddedPath);

        var moddedZombieData = JsonUtility.FromJson<ZombieAlmanacData>(moddedJson);

        foreach (ZombieInfo zombieInfo in moddedZombieData.zombies)
            if (zombieInfo.theZombieType == __instance.theZombieType)
            {
                component.text = zombieInfo.info + "\n\n" + zombieInfo.introduce;
                component.overflowMode = TextOverflowModes.Page;
                component2.text = zombieInfo.name;
                component2.autoSizeTextContainer = true;
                component3.text = Utils.RemoveColorTags(zombieInfo.name);
                component3.autoSizeTextContainer = true;
                component.font = hasAlmanacFont ? almanacFontAsset : fontAsset;
                component2.font = fontAsset;
                component3.font = fontAsset;
            }
    }

    [HarmonyPatch(nameof(AlmanacMgrZombie.OnMouseDown)), HarmonyPrefix]
    private static bool OnMouseDown(AlmanacMgrZombie __instance)
    {
        TextMeshPro component = __instance.info.GetComponent<TextMeshPro>();

        if (component == null)
            return true;

        component.pageToDisplay =
            component.pageToDisplay > component.m_pageNumber ? 1 : component.pageToDisplay + 1;

        return false;
    }
}
#endif
