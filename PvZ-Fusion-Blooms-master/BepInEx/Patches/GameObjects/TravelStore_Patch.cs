using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using System;
using TMPro;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
	[HarmonyPatch(typeof(TravelStore))]
	internal class TravelStore_Patch
	{
		[HarmonyPatch(nameof(TravelStore.Update))]
		[HarmonyPostfix]
		private static void Update(TravelStore __instance)
		{
			foreach (TextMeshProUGUI text in __instance.introduces)
			{
				text.text = StringStore.TranslateText(text.text);
			}

			Transform moneyTransform = __instance.transform.Find("Money");
			if (moneyTransform != null)
			{
				StringStore.TranslateTextTransform(moneyTransform);
			}
		}

		[HarmonyPatch(nameof(TravelStore.SetText), new Type[] { typeof(string)})]
		[HarmonyPostfix]
		private static void ShowText(TravelStore __instance)
		{
			foreach (TextMeshProUGUI text in __instance.introduces)
			{
				text.text = StringStore.TranslateText(text.text);
			}
		}
	}
}
