using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using UnityEngine.UI;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.BaseTextObjects
{
    [HarmonyPatch(typeof(TMP_Dropdown))]
    public static class TMP_Dropdown_Patch
    {
        [HarmonyPatch(nameof(TMP_Dropdown.Awake))]
        [HarmonyPatch(nameof(TMP_Dropdown.Start))]
        [HarmonyPatch(nameof(TMP_Dropdown.Show))]
        [HarmonyPatch(nameof(TMP_Dropdown.SetValue))]
        [HarmonyPostfix]
        public static void Awake(TMP_Dropdown __instance)
        {
            if (__instance.captionText != null)
            {
                TMP_Text txt = __instance.captionText;
                txt.text = StringStore.translationString.ContainsKey(txt.text + "_code") ? StringStore.TranslateText(txt.text + "_code") : StringStore.TranslateText(txt.text);
            }

            if (__instance.itemText != null)
            {
                TMP_Text txt = __instance.itemText;
                txt.text = StringStore.translationString.ContainsKey(txt.text + "_code") ? StringStore.TranslateText(txt.text + "_code") : StringStore.TranslateText(txt.text);
            }

            foreach (TMP_Dropdown.DropdownItem dropdownItem in __instance.m_Items)
            {
                TMP_Text txt = dropdownItem.text;
                txt.text = StringStore.translationString.ContainsKey(txt.text + "_code") ? StringStore.TranslateText(txt.text + "_code") : StringStore.TranslateText(txt.text);
            }
        }

        [HarmonyPatch(nameof(TMP_Dropdown.CreateDropdownList))]
        [HarmonyPostfix]
        public static void CreateDropdownList(TMP_Dropdown __instance)
        {
            foreach (TMP_Text txt in __instance.GetComponentsInChildren<TMP_Text>(true))
            {
                txt.text = StringStore.translationString.ContainsKey(txt.text + "_code") ? StringStore.TranslateText(txt.text + "_code") : StringStore.TranslateText(txt.text);
            }
        }
    }
}