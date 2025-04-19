using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Managers
{
	[HarmonyPatch(typeof(OppositeBuffManager))]
	public static class OppositeBuffManager_Patch
	{
		#if TESTING
		[HarmonyPatch(nameof(OppositeBuffManager.InitBuffPool))]
		[HarmonyPostfix]
		private static void InitBuffPool(OppositeBuffManager __instance)
		{
			foreach(TextMeshProUGUI text in __instance.textA_bad)
			{
				string stripText = text.text.Replace("但", "");
				string translatedText = StringStore.TranslateText(stripText);
				string replacementText = StringStore.translationString["但"] + translatedText;
				text.text = replacementText;
			}
			foreach(TextMeshProUGUI text in __instance.textA_good)
			{
				text.text = StringStore.TranslateText(text.text);
			}

			foreach(TextMeshProUGUI text in __instance.textB_bad)
			{
				string stripText = text.text.Replace("但", "");
				string translatedText = StringStore.TranslateText(stripText);
				string replacementText = StringStore.translationString["但"] + translatedText;
				text.text = replacementText;
			}
			foreach(TextMeshProUGUI text in __instance.textB_good)
			{
				text.text = StringStore.TranslateText(text.text);
			}
		}

		[HarmonyPatch(nameof(OppositeBuffManager.SetText), new Type[] { typeof(TextMeshProUGUI), typeof(BuffType), typeof(int)})]
		[HarmonyPostfix]
		private static void SetText(OppositeBuffManager __instance)
		{
			foreach(TextMeshProUGUI text in __instance.textA_bad)
			{
				string stripText = text.text.Replace("但", "");
				string translatedText = StringStore.TranslateText(stripText);
				string replacementText = StringStore.translationString["但"] + translatedText;
				text.text = replacementText;
			}
			foreach(TextMeshProUGUI text in __instance.textA_good)
			{
				text.text = StringStore.TranslateText(text.text);
			}

			foreach(TextMeshProUGUI text in __instance.textB_bad)
			{
				string stripText = text.text.Replace("但", "");
				string translatedText = StringStore.TranslateText(stripText);
				string replacementText = StringStore.translationString["但"] + translatedText;
				text.text = replacementText;
			}
			foreach(TextMeshProUGUI text in __instance.textB_good)
			{
				text.text = StringStore.TranslateText(text.text);
			}
		}
		#endif

		[HarmonyPatch(nameof(OppositeBuffManager.SetText), new Type[] { typeof(TextMeshProUGUI), typeof(BuffType), typeof(int)})]
		[HarmonyPostfix]
		private static void SetText(OppositeBuffManager __instance, ref TextMeshProUGUI text)
		{
			StringStore.TranslateTextUI(text);
		}

		[HarmonyPatch(nameof(OppositeBuffManager.Awake))]
		[HarmonyPostfix]
		private static void Awake(OppositeBuffManager __instance)
		{
			StringStore.TranslateTextUI(__instance.textA_bad[0]);
			StringStore.TranslateTextUI(__instance.textA_bad[1]);
			StringStore.TranslateTextUI(__instance.textB_bad[0]);
			StringStore.TranslateTextUI(__instance.textB_bad[1]);
		}

	}
}
