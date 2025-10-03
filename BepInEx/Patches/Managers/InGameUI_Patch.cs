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
                    array2[i] = StringStore.TranslateText(array2[i]);
                    array2[i].text = array2[i].text.Replace("\n", " ");
                }
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
			var shovelBank = root.Find("ShovelBank");
			if (!shovelBank) return;

			string currentLanguage = Utils.Language.ToString();
			var fontAsset = FontStore.LoadTMPFont(currentLanguage);


			for (int i = 0; i < shovelBank.childCount; i++)
			{
				var child = shovelBank.GetChild(i);
				var tmp = child.GetComponent<TextMeshProUGUI>();
				if (tmp == null) continue;

				string orig = tmp.text;
				string translated = StringStore.TranslateText(orig, false);
				if (translated != orig)
				{
					tmp.text = translated;
					if (fontAsset != null) tmp.font = fontAsset;
				}
				else
				{
					if (fontAsset != null) tmp.font = fontAsset;
				}
			}
		}
    }

	[HarmonyPatch(typeof(InGameUI_IZ))]
	public static class InGameUI_IZ_Patch
	{
		[HarmonyPatch(nameof(InGameUI_IZ.Awake))]
		[HarmonyPostfix]
		private static void Awake(InGameUI_IZ __instance)
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

		// [HarmonyPatch(nameof(InGameUI_IZ.Update))]
        // [HarmonyPostfix]
        // private static void Update(InGameUI_IZ __instance)
        // {
        //     ApplyShovelBankTranslations(__instance.transform);
        // }

        // private static void ApplyShovelBankTranslations(Transform root)
        // {
        //     var shovelBank = root.Find("ShovelBank");
        //     if (!shovelBank) return;

        //     string currentLanguage = Utils.Language.ToString();
        //     var fontAsset = FontStore.LoadTMPFont(currentLanguage);


        //     for (int i = 0; i < shovelBank.childCount; i++)
        //     {
        //         var child = shovelBank.GetChild(i);
        //         var tmp = child.GetComponent<TextMeshProUGUI>();
        //         if (tmp == null) continue;

        //         string orig = tmp.text;
        //         string translated = StringStore.TranslateText(orig, false);
        //         if (translated != orig)
        //         {
        //             tmp.text = translated;
        //             if (fontAsset != null) tmp.font = fontAsset;
        //         }
        //         else
        //         {
        //             if (fontAsset != null) tmp.font = fontAsset;
        //         }
        //     }
        // }
    }
}
