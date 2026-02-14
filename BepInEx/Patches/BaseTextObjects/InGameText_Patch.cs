using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using PvZ_Fusion_Translator__BepInEx_.Patches.Managers;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.BaseTextObjects
{
	[HarmonyPatch(typeof(InGameText))]
	public static class InGameText_Patch
	{
		[HarmonyPatch(nameof(InGameText.ShowText), new Type[] { typeof(string), typeof(float), typeof(bool), typeof(bool) })]
		[HarmonyPrefix]
		private static void ShowText_Pre(InGameText __instance, ref string text) => text = StringStore.TranslateText(text, true);

		[HarmonyPatch(nameof(InGameText.ShowText), new Type[] { typeof(string), typeof(float), typeof(bool), typeof(bool) })]
		[HarmonyPostfix]
		private static void ShowText_Post(InGameText __instance)
		{
			#if MULTI_LANGUAGE
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
			#else
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont();
			#endif

			foreach (TextMeshProUGUI txt in __instance.textMeshes)
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
				else if(System.Text.RegularExpressions.Regex.Match(txt.text, @"(<color[^>]*>.*?</color>)", System.Text.RegularExpressions.RegexOptions.Singleline).Success && !StringStore.translationString.ContainsKey(txt.text))
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
		}
	}
}
