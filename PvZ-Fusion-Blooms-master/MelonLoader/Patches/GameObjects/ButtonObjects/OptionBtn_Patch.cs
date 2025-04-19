using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects
{
	[HarmonyPatch(typeof(OptionBtn))]
	public static class OptionBtn_Patch
	{
		[HarmonyPatch(nameof(OptionBtn.Awake))]
		[HarmonyPostfix]
		private static void Awake(OptionBtn __instance)
		{
			Transform text_1Transform = __instance.transform.GetChild(0)?.transform;
			if (text_1Transform != null)
			{
				TextMeshProUGUI text_1 = text_1Transform.GetComponent<TextMeshProUGUI>();
				text_1 = StringStore.TranslateText(text_1);
				text_1.autoSizeTextContainer = false;
			}

			Transform textTransform = __instance.transform.GetChild(1)?.transform;
			if (textTransform != null)
			{
				TextMeshProUGUI text = textTransform.GetComponent<TextMeshProUGUI>();
				text = StringStore.TranslateText(text);
				text.autoSizeTextContainer = false;
			}

			Transform text2Transform = __instance.transform.GetChild(2)?.transform;
			if (text2Transform != null)
			{
				TextMeshProUGUI text2 = text2Transform.GetComponent<TextMeshProUGUI>();
				text2 = StringStore.TranslateText(text2);
				text2.autoSizeTextContainer = false;
			}
		}

		[HarmonyPatch("OnMouseUpAsButton")]
		[HarmonyPostfix]
		private static void OnMouseUpAsButtonPostfix(OptionBtn __instance)
		{
			Transform text_1Transform = __instance.transform.GetChild(0)?.transform;
			if (text_1Transform != null)
			{
				TextMeshProUGUI text_1 = text_1Transform.GetComponent<TextMeshProUGUI>();
				text_1 = StringStore.TranslateText(text_1);
				text_1.autoSizeTextContainer = false;
			}

			Transform textTransform = __instance.transform.GetChild(1)?.transform;
			if (textTransform != null)
			{
				TextMeshProUGUI text = textTransform.GetComponent<TextMeshProUGUI>();
				text = StringStore.TranslateText(text);
				text.autoSizeTextContainer = false;
			}

			Transform text2Transform = __instance.transform.GetChild(2)?.transform;
			if (text2Transform != null)
			{
				TextMeshProUGUI text2 = text2Transform.GetComponent<TextMeshProUGUI>();
				text2 = StringStore.TranslateText(text2);
			}
		}
	}
}
