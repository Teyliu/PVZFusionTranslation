using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects
{
	[HarmonyPatch(typeof(Plant))]
	public static class Plant_Patch
	{
		[HarmonyPostfix]
		[HarmonyPatch(nameof(Plant.UpdateHealthText))]
		private static void UpdateHealthText(Plant __instance)
		{
			Transform healthTransform = __instance.transform.Find("health");
			if (healthTransform != null)
			{
				StringStore.TranslateTextTransform(__instance.transform);
			}
		}
	}
}
