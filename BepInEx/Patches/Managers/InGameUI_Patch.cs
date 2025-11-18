using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using System.Text.RegularExpressions;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
    [HarmonyPatch(typeof(InGameUI))]
    public static class InGameUI_Patch
    {
        [HarmonyPatch(nameof(InGameUI.Start))]
        [HarmonyPostfix]
        private static void Start(InGameUI __instance)
        {
            TextMeshProUGUI[] array = new TextMeshProUGUI[]
            {
                __instance.transform.GetChild(4).GetComponent<TextMeshProUGUI>(),
                __instance.transform.GetChild(4).GetChild(0).GetComponent<TextMeshProUGUI>(),
                __instance.transform.GetChild(5).GetComponent<TextMeshProUGUI>(),
                __instance.transform.GetChild(5).GetChild(0).GetComponent<TextMeshProUGUI>(),
                __instance.transform.GetChild(6).GetComponent<TextMeshProUGUI>(),
                __instance.transform.GetChild(6).GetChild(0).GetComponent<TextMeshProUGUI>()};
            TextMeshProUGUI[] array2 = array;
            for (int i = 0; i < array2.Length; i++)
            {
                string originalText = array2[i].text;
                array2[i].text = array2[i].text.Replace("\n", " ");
                Regex checkFusionChallenge = new Regex("^超级([^\\s：]+)(：?挑战1?)");

                if (array2[i].text.Contains("配方：") && !checkFusionChallenge.IsMatch(array2[i].text))
                {
                    string[] lines = array2[i].text.Split("：");
                    lines[1] = Utils.GetPlantNameFromAlmanac(lines[1]);
                    if (lines[1] == "")
                    {
                        Log.LogError("Couldn't find plant! (Fusion Showcase)");
                        lines[1] = StringStore.TranslateText(lines[1]);
                    }
                    array2[i].text = StringStore.TranslateText("配方：") + lines[1];
                    array2[i].autoSizeTextContainer = true;
                }
                else
                {
                    array2[i].text = (StringStore.translationString.ContainsKey(array2[i].text + "_MG")) ? StringStore.TranslateText(array2[i].text + "_MG") : StringStore.TranslateText(array2[i].text);
                    array2[i].text = array2[i].text.Replace("\n", " ");
                }
            }
        }

        [HarmonyPatch(nameof(InGameUI.Update))]
        [HarmonyPostfix]
        private static void Update(InGameUI __instance)
        {
            foreach(TextMeshProUGUI txt in __instance.ShovelBank.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
        }
    }

    [HarmonyPatch(typeof(InGameUI_IZ))]
    public static class InGameUI_IZ_Patch
    {
        [HarmonyPatch(nameof(InGameUI_IZ.Update))]
        [HarmonyPostfix]
        private static void Update(InGameUI_IZ __instance)
        {
            foreach (TextMeshProUGUI txt in __instance.shovel.GetComponentsInChildren<TextMeshProUGUI>())
            {
                txt.text = StringStore.TranslateText(txt.text);
                txt.font = FontStore.LoadTMPFont(Utils.Language.ToString());
            }
        }
    }
}
