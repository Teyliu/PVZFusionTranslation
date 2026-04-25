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
		[HarmonyPatch(nameof(InGameText.ShowText), new Type[] { typeof(string), typeof(float), typeof(bool) })]
		[HarmonyPrefix]
		private static void ShowText_Pre(InGameText __instance, ref string text) => text = StringStore.TranslateText(text, true);

		[HarmonyPatch(nameof(InGameText.ShowText), new Type[] { typeof(string), typeof(float), typeof(bool) })]
		[HarmonyPostfix]
		private static void ShowText_Post(InGameText __instance)
		{
			TranslateInGameText(__instance);
		}

		public static void TranslateInGameText(InGameText __instance)
		{
			TextMeshProUGUI txt = null;

			if (__instance.textMesh == null || __instance.textHead == null)
			{
				if (__instance.TryGetComponent<TextMeshProUGUI>(out TextMeshProUGUI selfTxt))
				{
					txt = selfTxt;
				}
			}
			else
			{
				txt = __instance.textMesh;
			}

			if (txt != null)
			{
				if (!txt.gameObject.active) return;

				TranslateInGameTextMesh(txt);
			}
		}

		public static void TranslateInGameTextMesh(TextMeshProUGUI txt)
		{
			if (txt == null) return;

			#if MULTI_LANGUAGE
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
			#else
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont();
			#endif

			string originalText = txt.text;
			string travelMatch = TravelMgr_Patch.MatchTravelBuff(originalText);

			if (txt.gameObject.name.Contains("shadow"))
			{
				return;
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
			else if (System.Text.RegularExpressions.Regex.Match(txt.text, @"(<color[^>]*>.*?</color>)", System.Text.RegularExpressions.RegexOptions.Singleline).Success && (!StringStore.translationString.ContainsKey(txt.text) && !StringStore.fsTipCollectionString.ContainsKey(txt.text) && !StringStore.izTipCollectionString.ContainsKey(txt.text)))
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
