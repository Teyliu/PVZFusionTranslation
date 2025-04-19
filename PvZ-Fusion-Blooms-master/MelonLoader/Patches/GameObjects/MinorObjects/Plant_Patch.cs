#if FIX
using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects
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
#endif