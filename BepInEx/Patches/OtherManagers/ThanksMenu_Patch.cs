using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.OtherManagers
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
