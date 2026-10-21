using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.OtherManagers;

[HarmonyPatch(typeof(ThanksMenu))]
public class ThanksMenu_Patch
{
    [HarmonyPostfix, HarmonyPatch(nameof(ThanksMenu.Update))]
    private static void Update(ThanksMenu __instance)
    {
        var textTransform = __instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>();

        if (textTransform == null)
            return;

        textTransform.text = StringStore.TranslateText(textTransform.text);
        textTransform.autoSizeTextContainer = true;
    }
}
