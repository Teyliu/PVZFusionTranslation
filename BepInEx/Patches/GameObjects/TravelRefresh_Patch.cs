using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using TMPro;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
	[HarmonyPatch(typeof(TravelRefresh))]
	public static class TravelRefresh_Patch
	{
		[HarmonyPatch(nameof(TravelRefresh.Update))]
		[HarmonyPostfix]
		private static void Update(TravelRefresh __instance)
		{
			TextMeshProUGUI pointsText = __instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
			pointsText = StringStore.TranslateText(pointsText);
			pointsText.autoSizeTextContainer = true;

			Transform TravelMenuTransform = __instance.transform.parent.transform;
			Transform refreshTransform = TravelMenuTransform.Find("Refresh2").transform.Find("bank");
			if (refreshTransform != null)
			{
				Transform text_1Transform = refreshTransform.Find("text_1");
				if (text_1Transform != null)
				{
					TextMeshProUGUI text_1 = text_1Transform.GetComponent<TextMeshProUGUI>();
					if (text_1)
					{
						text_1 = StringStore.TranslateText(text_1);
						text_1.autoSizeTextContainer = true;
					}
				}

				Transform text_2Transform = refreshTransform.Find("text_2");
				if (text_2Transform != null)
				{
					TextMeshProUGUI text_2 = text_2Transform.GetComponent<TextMeshProUGUI>();
					if (text_2)
					{
						text_2 = StringStore.TranslateText(text_2);
						text_2.autoSizeTextContainer = true;
					}
				}
			}
		}
	}
}
