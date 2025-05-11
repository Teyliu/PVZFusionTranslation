using HarmonyLib;

using TMPro;
using System;
using System.Collections.Generic;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using Unity.VisualScripting;
using UnityEngine;
using System.Text.RegularExpressions;
using UnityEngine.UI;


namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(AbyssMenu))]
    public static class AbyssMenu_Patch
    {
        public static GameObject ConvertToTextMeshProUGUI(GameObject originalText, Transform parent, string name)
        {
            GameObject newObj = new GameObject(name);
            newObj.transform.position = originalText.transform.position;
            newObj.AddComponent<CanvasRenderer>();
            newObj.AddComponent<RectTransform>();
            newObj.AddComponent<TextMeshProUGUI>();
            newObj.transform.SetParent(parent);
            newObj.transform.localScale = Vector3.one;

            UnityEngine.Object.Destroy(originalText);
            return newObj;
        }

        private static void ConvertButtonText(Transform original, string name)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            Transform transform = original.FindChild(name);
            Transform textTransform = transform.FindChild("text");
            string text = textTransform.GetComponent<Text>().text;
            Color color = textTransform.GetComponent<Text>().color;

            TextMeshProUGUI newGoBackText = ConvertToTextMeshProUGUI(textTransform.gameObject, transform, "text2").GetComponent<TextMeshProUGUI>();
            newGoBackText.autoSizeTextContainer = true;
            newGoBackText.text = StringStore.TranslateText(text, false);
            newGoBackText.font = fontAsset;
            newGoBackText.color = color;
        }

        [HarmonyPatch(nameof(AbyssMenu.Awake))]
        [HarmonyPostfix]
        private static void Awake(AbyssMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.levelInfo)
            {
                txt.text = StringStore.TranslateText(txt.text, false);
                txt.font = fontAsset;
            }

            ConvertButtonText(__instance.transform, "Goback");
        }

        [HarmonyPatch(nameof(AbyssMenu.UpdateLevelInfo))]
        [HarmonyPostfix]
        private static void UpdateLevelInfo(AbyssMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.levelInfo)
            {
                string regexStr = "第(\\d+)关\n场景：([^\\s]+)\n总波数：(\\d+)波\n特殊环境：([^\\s：]+)\n减伤强度：(\\d+)";

                Regex regex = new Regex(regexStr);

                if(regex.IsMatch(txt.text))
                {   
                    Match match = regex.Match(txt.text);
                    int groupCount = match.Groups.Count;

                    List<string> dynamicParts = [];

                    for (int i = 1; i < groupCount; i++)
                    {
                        string groupValue = match.Groups[i].Value;
                        string translatedValue = StringStore.translationString.ContainsKey(groupValue) ? StringStore.translationString[groupValue] : groupValue;
                        dynamicParts.Add(translatedValue);
                    }

                    txt.text = string.Format(StringStore.translationStringRegex[regexStr], [.. dynamicParts]);
                    txt.font = fontAsset;
                }
            }
        }
    }
}
