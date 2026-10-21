using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey;

[HarmonyPatch(typeof(TravelLookMenu))]
public static class TravelLookMenu_Patch
{
#pragma warning disable CA2211
    public static string SavedAssetString = "";
#pragma warning restore CA2211
    [HarmonyPatch(nameof(TravelLookMenu.Start)), HarmonyPostfix]
    private static void Postfix_Start(TravelLookMenu __instance)
    {
        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = StringStore.TranslateText(txt.text);
            txt.font = FontStore.LoadTMPFont(Utils.Language.ToString());
        }

        var quitButtonTransform = __instance.transform.Find("Quit");

        foreach (var txt in quitButtonTransform.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = StringStore.TranslateText("合上");
            txt.font = FontStore.LoadTMPFont(Utils.Language.ToString());
        }

        __instance.treasureText.text = StringStore.TranslateText(__instance.treasureText.text);
        SavedAssetString = __instance.treasureText.text;
    }

    [HarmonyPatch(nameof(TravelLookMenu.Update)), HarmonyPostfix]
    private static void Update(TravelLookMenu __instance)
    {
        if (SavedAssetString == __instance.treasureText.text)
            return;

        __instance.treasureText.text = StringStore.TranslateText(__instance.treasureText.text);
        SavedAssetString = __instance.treasureText.text;
    }
}
