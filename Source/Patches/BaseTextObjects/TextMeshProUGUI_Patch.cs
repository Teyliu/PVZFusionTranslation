using HarmonyLib;
using PvZ_Fusion_Translator.Patches.Managers;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.BaseTextObjects;

[HarmonyPatch(typeof(TextMeshProUGUI))]
public static class TextMeshProUGUI_Patch
{
    [HarmonyPatch(nameof(TextMeshProUGUI.OnEnable)), HarmonyPostfix]
    private static void OnEnable(TextMeshProUGUI __instance)
    {
        if (string.IsNullOrEmpty(__instance.text))
            return;

        __instance.font = FontStore.LoadTMPFont(Utils.Language.ToString());

        if (!Utils.CheckForUntranslatedText(__instance.text) && !__instance.text.Contains('_'))
            return;

        if (__instance.transform.parent != null)
        {
            if (__instance.transform.parent.name.Contains("DrawCardsText"))
                return;

            if (__instance.transform.parent.parent != null)
                if (__instance.transform.parent.parent.name.Contains("AbyssBagMenu"))
                    return;
        }

        __instance = StringStore.TranslateText(__instance);
        __instance.autoSizeTextContainer = false;

        if (__instance.name.StartsWith("LevelName"))
        {
            __instance.text = __instance.text.Replace("\n", " ");

            if (__instance.name is "LevelName2" or "LevelName3" &&
                !(__instance.gameObject.transform.parent.name.Contains("Difficulty") ||
                    __instance.gameObject.name.Contains("Difficulty")))
                TowerManager_Patch.UpdatedText.Add(__instance.transform);
        }

        if (__instance.transform.parent == null || !__instance.transform.parent.name.StartsWith("Window"))
            return;

        __instance.fontSizeMin = 10;
        __instance.fontSize = 12;
        // __instance.ForceMeshUpdate();
    }
#if false
    [HarmonyPatch(nameof(TextMeshProUGUI.Awake)), HarmonyPostfix]
    private static void Awake(TextMeshProUGUI __instance)
    {
        if (string.IsNullOrEmpty(__instance.text))
            return;

        if (__instance.transform.parent.parent != null)
            if (__instance.transform.parent.parent.name.Contains("AbyssBagMenu"))
                return;

        __instance = StringStore.TranslateText(__instance);
        __instance.autoSizeTextContainer = false;

        if (__instance.transform.parent != null && __instance.transform.parent.name.StartsWith("Window"))
        {
            __instance.fontSizeMin = 10;
            __instance.fontSize = 12;
        }

        if (__instance.text == "Полный Хаос" &&
            __instance.transform.parent.parent.Find("Image").GetComponent<UnityEngine.UI.Image>().activeSprite.name ==
            "Present")
            __instance.text += "\nБесконечно";

        // __instance.ForceMeshUpdate();
    }
#endif
}
#if false
[HarmonyPatch(typeof(TMP_SubMeshUI))]
public static class TMP_SubMeshUI_Patch
{
    [HarmonyPatch(nameof(TMP_SubMeshUI.OnEnable)), HarmonyPostfix]
    public static void OnEnable(TMP_SubMeshUI __instance)
    {
        if (string.IsNullOrEmpty(__instance.textComponent.text))
            return;

        var text = StringStore.TranslateText(__instance.textComponent.text);
        __instance.m_TextComponent.text = StringStore.TranslateText(text);
        __instance.textComponent.text = StringStore.TranslateText(text);
    }
}
#endif
