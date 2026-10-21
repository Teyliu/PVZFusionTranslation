using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.BaseTextObjects;

[HarmonyPatch(typeof(TMP_Dropdown))]
public static class TMP_Dropdown_Patch
{
    [HarmonyPatch(nameof(TMP_Dropdown.Awake)), HarmonyPatch(nameof(TMP_Dropdown.Start)),
     HarmonyPatch(nameof(TMP_Dropdown.Show)), HarmonyPatch(nameof(TMP_Dropdown.SetValue)), HarmonyPostfix]
    public static void Awake(TMP_Dropdown __instance)
    {
        if (__instance.captionText)
        {
            var txt = __instance.captionText;

            txt.text = StringStore.TranslationString.ContainsKey(txt.text + "_code")
                ? StringStore.TranslateText(txt.text + "_code")
                : StringStore.TranslateText(txt.text);
        }

        if (__instance.itemText)
        {
            var txt = __instance.itemText;

            txt.text = StringStore.TranslationString.ContainsKey(txt.text + "_code")
                ? StringStore.TranslateText(txt.text + "_code")
                : StringStore.TranslateText(txt.text);
        }

        foreach (var dropdownItem in __instance.m_Items)
        {
            var txt = dropdownItem.text;

            txt.text = StringStore.TranslationString.ContainsKey(txt.text + "_code")
                ? StringStore.TranslateText(txt.text + "_code")
                : StringStore.TranslateText(txt.text);
        }
    }

    [HarmonyPatch(nameof(TMP_Dropdown.CreateDropdownList))]
    public static void CreateDropdownList(TMP_Dropdown __instance)
    {
        foreach (var txt in __instance.GetComponentsInChildren<TMP_Text>(true))
            txt.text = StringStore.TranslationString.ContainsKey(txt.text + "_code")
                ? StringStore.TranslateText(txt.text + "_code")
                : StringStore.TranslateText(txt.text);
    }
}
