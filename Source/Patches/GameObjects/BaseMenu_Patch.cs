using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(BaseMenu))]
public static class BaseMenu_Patch
{
    [HarmonyPatch(nameof(BaseMenu.Awake)), HarmonyPrefix]
    private static void Pre_Awake(BaseMenu __instance)
    {
        if (__instance.name.Contains("NoticePauseMenu"))
            NoticePauseMenu_Patch.Pre_Awake(__instance);
    }

    [HarmonyPatch(nameof(BaseMenu.Awake)), HarmonyPostfix]
    private static void Post_Awake(BaseMenu __instance)
    {
        if (__instance.name.Contains("NoticePauseMenu"))
            NoticePauseMenu_Patch.Post_Awake(__instance);

        if (__instance.name.StartsWith("MainMenu(Clone)"))
            MainMenu_Patch.AnimOver(__instance);

        if (__instance.name.StartsWith("PlantDamageMenu"))
            PlantDamageMenu_Patch.Awake(__instance);

        TranslateBaseMenuTransform(__instance, "Level");
        TranslateBaseMenuTransform(__instance, "Levels");
        TranslateBaseMenuTransform(__instance, "CustomLevel");

        StringStore.TranslateTextTransform(__instance.transform.Find("Goback"));
        StringStore.TranslateTextTransform(__instance.transform.Find("Switich"));
    }

    public static void TranslateBaseMenuTransform(BaseMenu __instance, string levelsName)
    {
        var levels = __instance.transform.Find(levelsName);

        if (levels == null)
            return;

        var children = levels.GetComponentsInChildren<Transform>(true).ToList();

        foreach (var child in children.Where(child => child.name is "Nextpage" or "LastPage" or "BackToIndex"))
            StringStore.TranslateTextTransform(child);
    }
}
