using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects;

[HarmonyPatch(typeof(PumpinerChestMenu))]
public static class PumpinerChestMenu_Patch
{
    [HarmonyPatch(nameof(PumpinerChestMenu.InitPlants)), HarmonyPostfix]
    public static void Post_InitPlants(PumpinerChestMenu __instance)
    {
        var closeBtnTransform = __instance.transform.Find("SampleButton");
        var txt = closeBtnTransform.GetComponentInChildren<TextMeshProUGUI>();
        txt.text = StringStore.TranslateText("合上");
    }
}
