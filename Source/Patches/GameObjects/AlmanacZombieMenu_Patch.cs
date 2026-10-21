using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(AlmanacZombieMenu))]
public static class AlmanacZombieMenu_Patch
{
#pragma warning disable CA2211
    public static string AlmanacJson = "";
#pragma warning restore CA2211
    [HarmonyPatch(nameof(AlmanacZombieMenu.Start)), HarmonyPostfix]
    private static void Start(AlmanacZombieMenu __instance)
    {
        var font = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var text in from text in __instance.GetComponentsInChildren<TextMeshProUGUI>(true)
            where !text.gameObject.name.Contains("Cost")
            let isZombieName = text.gameObject.name.Contains("Name") && text.transform.parent.name != "Background"
            where text.gameObject.name != "Description" && !isZombieName
            select text)
        {
            text.text = StringStore.TranslateText(text.text);
            text.font = font;
            text.autoSizeTextContainer = true;
        }
    }
}
