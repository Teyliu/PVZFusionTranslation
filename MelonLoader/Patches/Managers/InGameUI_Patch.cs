using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;
using PvZ_Fusion_Translator;

namespace PvZ_Fusion_Translator.Patches.Managers
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
				array2[i] = StringStore.TranslateText(array2[i]);
				array2[i].text = array2[i].text.Replace("\n", " ");
			}
		}

		[HarmonyPatch(nameof(InGameUI.Update))]
		[HarmonyPostfix]
		private static void Update(InGameUI __instance)
		{
			ApplyShovelBankTranslations(__instance.transform);
		}

		private static void ApplyShovelBankTranslations(Transform root)
		{
			var shovelBank = root.FindChild("ShovelBank");
			if (!shovelBank) return;

			string currentLanguage = Utils.Language.ToString();
			var fontAsset = FontStore.LoadTMPFont(currentLanguage);

			for (int i = 0; i < shovelBank.childCount; i++)
			{
				var child = shovelBank.GetChild(i);
				var hasTmp = child.TryGetComponent<TextMeshProUGUI>(out var comp);
				if (!hasTmp) continue;

				string orig = comp.text;
				string translated = StringStore.TranslateText(orig, false);
				if (translated != orig)
				{
					comp.text = translated;
					if (fontAsset != null) comp.font = fontAsset;
				}
				else
				{
					if (fontAsset != null) comp.font = fontAsset;
				}
			}
		}
    }

	[HarmonyPatch(typeof(InGameUI_IZ))]
	public static class InGameUI_IZ_Patch
	{

		[HarmonyPatch(nameof(InGameUI_IZ.Start))]
		[HarmonyPostfix]
		private static void Start(InGameUI_IZ __instance)
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
				array2[i] = StringStore.TranslateText(array2[i]);
				array2[i].text = array2[i].text.Replace("\n", " ");
			}
		}

		[HarmonyPatch(nameof(InGameUI_IZ.Update))]
		[HarmonyPostfix]
		private static void Update(InGameUI_IZ __instance)
		{
			InGameUI_Patch.ApplyShovelBankTranslations(__instance.transform);
		}
	}
}
