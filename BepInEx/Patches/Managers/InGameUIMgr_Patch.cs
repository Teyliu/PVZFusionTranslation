using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using TMPro;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
	[HarmonyPatch(typeof(InGameUIMgr))]
	public static class InGameUIMgr_Patch
	{
		[HarmonyPatch(nameof(InGameUIMgr.Start))]
		[HarmonyPostfix]
		private static void Start(InGameUIMgr __instance)
		{
			TextMeshProUGUI[] array = new TextMeshProUGUI[]
			{
					__instance.transform.GetChild(4).GetComponent<TextMeshProUGUI>(),
					__instance.transform.GetChild(4).GetChild(0).GetComponent<TextMeshProUGUI>(),
					__instance.transform.GetChild(5).GetComponent<TextMeshProUGUI>(),
					__instance.transform.GetChild(5).GetChild(0).GetComponent<TextMeshProUGUI>(),
					__instance.transform.GetChild(6).GetComponent<TextMeshProUGUI>(),
					__instance.transform.GetChild(6).GetChild(0).GetComponent<TextMeshProUGUI>()
			};
			TextMeshProUGUI[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{

				array2[i] = StringStore.TranslateText(array2[i]);
				array2[i].text = array2[i].text.Replace("\n", " ");
			}
		}
	}
}
