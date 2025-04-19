using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.OtherManagers
{
	[HarmonyPatch(typeof(ThanksMenu))]
	public class ThanksMenu_Patch
	{
		[HarmonyPostfix]
		[HarmonyPatch(nameof(ThanksMenu.Update))]
		private static void Update(ThanksMenu __instance)
		{
			TextMeshProUGUI textTransform = __instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
			if (textTransform != null)
			{
				textTransform.text = StringStore.TranslateText(textTransform.text);
				textTransform.autoSizeTextContainer = true;
			}
		}
	}
}