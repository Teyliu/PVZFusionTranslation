using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects
{
	[HarmonyPatch(typeof(DY))]
	public static class DY_Patch
	{
		[HarmonyPostfix]
		[HarmonyPatch(nameof(DY.Update))]
		private static void Update(DY __instance)
		{
			__instance.TextMeshPro.text = StringStore.TranslateText(__instance.TextMeshPro.text);
		}
	}
}