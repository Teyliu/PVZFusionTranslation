using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(PlantDamageMenu))]
    public static class PlantDamageMenu_Patch
    {
        public static void Awake(BaseMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
            foreach(TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                string originalKey = StringStore.translationString.FirstOrDefault(x => x.Value == text.text).Key;
                text.text = StringStore.translationString.ContainsKey(originalKey + "_RM") ? StringStore.TranslateText(originalKey + "_RM") : StringStore.TranslateText(text.text);
                text.font = fontAsset;
            }
        }

        [HarmonyPatch(nameof(PlantDamageMenu.Awake))]
        [HarmonyPatch(nameof(PlantDamageMenu.InitCards))]
        [HarmonyPostfix]
        public static void InitCards(PlantDamageMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
            foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                string originalKey = StringStore.translationString.FirstOrDefault(x => x.Value == text.text).Key;
                text.text = StringStore.translationString.ContainsKey(originalKey + "_RM") ? StringStore.TranslateText(originalKey + "_RM") : StringStore.TranslateText(text.text);
                text.font = fontAsset;
            }
        }
    }
}
