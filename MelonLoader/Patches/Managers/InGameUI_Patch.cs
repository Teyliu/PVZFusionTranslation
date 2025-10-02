using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;
using Unity.Collections;

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
	}
}
