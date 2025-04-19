using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects
{
	[HarmonyPatch(typeof(Zombie))]
	public static class Zombie_Patch
	{
		[HarmonyPostfix]
		[HarmonyPatch(nameof(Zombie.UpdateHealthText))]
		private static void UpdateHealthText(Zombie __instance)
		{
			Transform healthTransform = __instance.transform.Find("health");
			if (healthTransform != null)
			{
				StringStore.TranslateTextTransform(__instance.transform);
			}
		}
	}
}
