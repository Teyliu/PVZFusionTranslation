using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
	[HarmonyPatch(typeof(TravelRefresh))]
	public static class TravelRefresh_Patch
	{
		[HarmonyPatch(nameof(TravelRefresh.Start))]
		[HarmonyPostfix]
		private static void Start(TravelRefresh __instance)
		{
            __instance.text = StringStore.TranslateText(__instance.text);
            __instance.text_shadow = StringStore.TranslateText(__instance.text_shadow);

            //TextMeshProUGUI pointsText = __instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
            //pointsText = StringStore.TranslateText(pointsText);
            //pointsText.autoSizeTextContainer = true;


            //Transform TravelMenuTransform = __instance.transform.parent.transform;

            //Transform refreshTransform = TravelMenuTransform.Find("Refresh2").transform.Find("bank");
            //if (refreshTransform != null)
            //{
            //	Transform text_1Transform = refreshTransform.Find("text_1");
            //	if (text_1Transform != null)
            //	{
            //		TextMeshProUGUI text_1 = text_1Transform.GetComponent<TextMeshProUGUI>();

            //		if (text_1)
            //		{
            //			text_1 = StringStore.TranslateText(text_1);
            //			text_1.autoSizeTextContainer = true;
            //		}
            //	}

            //	Transform text_2Transform = refreshTransform.Find("text_2");
            //	if (text_2Transform != null)
            //	{
            //		TextMeshProUGUI text_2 = text_2Transform.GetComponent<TextMeshProUGUI>();

            //		if (text_2)
            //		{
            //			text_2 = StringStore.TranslateText(text_2);
            //			text_2.autoSizeTextContainer = true;
            //		}
            //	}
            //}
        }

        [HarmonyPatch(nameof(TravelRefresh.OnMouseUpAsButton))]
        [HarmonyPostfix]
        private static void OnMouseUpAsButton(TravelRefresh __instance)
        {
            __instance.text = StringStore.TranslateText(__instance.text);
            __instance.text_shadow = StringStore.TranslateText(__instance.text_shadow);

            //TextMeshProUGUI pointsText = __instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
            //pointsText = StringStore.TranslateText(pointsText);
            //pointsText.autoSizeTextContainer = true;


            //Transform TravelMenuTransform = __instance.transform.parent.transform;

            //Transform refreshTransform = TravelMenuTransform.Find("Refresh2").transform.Find("bank");
            //if (refreshTransform != null)
            //{
            //	Transform text_1Transform = refreshTransform.Find("text_1");
            //	if (text_1Transform != null)
            //	{
            //		TextMeshProUGUI text_1 = text_1Transform.GetComponent<TextMeshProUGUI>();

            //		if (text_1)
            //		{
            //			text_1 = StringStore.TranslateText(text_1);
            //			text_1.autoSizeTextContainer = true;
            //		}
            //	}

            //	Transform text_2Transform = refreshTransform.Find("text_2");
            //	if (text_2Transform != null)
            //	{
            //		TextMeshProUGUI text_2 = text_2Transform.GetComponent<TextMeshProUGUI>();

            //		if (text_2)
            //		{
            //			text_2 = StringStore.TranslateText(text_2);
            //			text_2.autoSizeTextContainer = true;
            //		}
            //	}
            //}
        }
    }
}
