using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Managers
{
    [HarmonyPatch(typeof(InGameUI))]
	public static class InGameUIMgr_Patch
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
