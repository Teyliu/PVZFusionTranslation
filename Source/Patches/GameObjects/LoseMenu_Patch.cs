using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(LoseMenu))]
public static class LoseMenu_Patch
{
    public static void TranslateLoseMenu(BaseMenu __instance)
    {
        if (__instance.TryGetComponent<LoseMenu>(out var loseMenu))
            loseMenu.title.text = StringStore.TranslateText(loseMenu.title.text);
    }
}
