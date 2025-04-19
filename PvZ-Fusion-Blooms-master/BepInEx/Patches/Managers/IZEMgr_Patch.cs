using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using TMPro;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
	[HarmonyPatch(typeof(IZEMgr))]
	public static class IZEMgr_Patch
	{
		[HarmonyPatch(nameof(IZEMgr.Start))]
		[HarmonyPostfix]
		public static void Start(IZEMgr __instance)
		{
			TextMeshProUGUI[] array =
			[
					__instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>(),
					__instance.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>(),
			];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = StringStore.TranslateText(array[i]);
				array[i].text = array[i].text.Replace("\n", " ");
			}
		}
	}
}
