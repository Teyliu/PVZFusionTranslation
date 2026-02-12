using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.Modes.Odyssey;

//using PvZ_Fusion_Translator.Patches.Modes.Odyssey;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.BaseTextObjects
{
	[HarmonyPatch(typeof(InGameText))]
	public static class InGameText_Patch
	{
        [HarmonyPatch(nameof(InGameText.ShowText))]
        [HarmonyPostfix]
        public static void ShowText(InGameText __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                string originalText = txt.text;
                string travelMatch = TravelMgr_Patch.MatchTravelBuff(originalText);

                if (txt.gameObject.name.Contains("shadow"))
                {
                    continue;
                }

                if (travelMatch != "")
                {
                    txt.text = travelMatch;
                    if (txt.gameObject.name.Contains("main"))
                    {
                        originalText = txt.text;
                        Transform shadowText = txt.transform.parent.Find("Text_shadow");
                        if (shadowText != null)
                        {
                            shadowText.GetComponent<TextMeshProUGUI>().text = Utils.RemoveColorTags(originalText);
                        }
                    }
                }
                else if((Regex.Match(txt.text, @"(<color[^>]*>.*?</color>)", RegexOptions.Singleline).Success) && !StringStore.translationString.ContainsKey(txt.text))
                {
                    txt.text = StringStore.TranslateColorText(txt.text, true);
                    if (txt.gameObject.name.Contains("main"))
                    {
                        originalText = txt.text;
                        Transform shadowText = txt.transform.parent.Find("Text_shadow");
                        if (shadowText != null)
                        {
                            shadowText.GetComponent<TextMeshProUGUI>().text = Utils.RemoveColorTags(originalText);
                        }
                    }
                }
                else
                {
                    txt.text = StringStore.TranslateText(txt.text, true);
                    if (txt.gameObject.name.Contains("main"))
                    {
                        originalText = txt.text;
                        Transform shadowText = txt.transform.parent.Find("Text_shadow");
                        if (shadowText != null)
                        {
                            shadowText.GetComponent<TextMeshProUGUI>().text = Utils.RemoveColorTags(originalText);
                        }
                    }
                }
                txt.font = fontAsset;
            }

            if(__instance.TryGetComponent<TextMeshProUGUI>(out TextMeshProUGUI text))
            {
                text.text = StringStore.TranslateText(text.text);
            }
        }
	}
}