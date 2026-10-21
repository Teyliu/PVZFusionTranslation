using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(ExploreMakeMenu))]
public static class ExploreMakeMenu_Patch
{
    [HarmonyPatch(nameof(ExploreMakeMenu.Awake)), HarmonyPostfix]
    private static void Awake(ExploreMakeMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = StringStore.TranslateText(txt.text);
            txt.font = fontAsset;
        }
    }

    [HarmonyPatch(nameof(ExploreMakeMenu.InitMenu)), HarmonyPostfix]
    private static void InitMenu(ExploreMakeMenu __instance)
    {
        _ = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            if (txt.text.Contains("关卡制作中："))
            {
                var plantName = Utils.GetPlantNameFromAlmanac(txt.text.Split("：")[1]);
                txt.text = string.Format(StringStore.TranslationStringRegex["关卡制作中：([^\\s]+)"], plantName);
            }
            else
                txt.text = StringStore.TranslateText(txt.text);
    }

    [HarmonyPatch(nameof(ExploreMakeMenu.ViewScene)), HarmonyPostfix]
    private static void ViewScene(ExploreMakeMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = StringStore.TranslateText(txt.text);
            txt.font = fontAsset;
        }
    }

    [HarmonyPatch(nameof(ExploreMakeMenu.InitZombieButtons)), HarmonyPostfix]
    private static void InitZombieButtons(ExploreMakeMenu __instance)
    {
        var fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = StringStore.TranslateText(txt.text);
            txt.font = fontAsset;
        }
    }
}
