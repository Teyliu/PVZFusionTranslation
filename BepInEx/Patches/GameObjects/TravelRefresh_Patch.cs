using HarmonyLib;
using System;
using System.Runtime.CompilerServices;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
	[HarmonyPatch(typeof(TravelRefresh))]
	public static class TravelRefresh_Patch
	{
		[HarmonyPatch(nameof(TravelRefresh.Awake))]
		[HarmonyPostfix]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void Awake(TravelRefresh __instance)
		{
			if (__instance.text != null)
				__instance.text.text = StringStore.TranslateText(__instance.text.text);
			if (__instance.text_shadow != null)
				__instance.text_shadow.text = StringStore.TranslateText(__instance.text_shadow.text);
        }

        [HarmonyPatch(nameof(TravelRefresh.OnMouseUpAsButton))]
		[HarmonyPostfix]
		[MethodImpl(MethodImplOptions.NoInlining)]
        private static void OnMouseUpAsButton(TravelRefresh __instance)
        {
			if (__instance.text != null)
				__instance.text.text = StringStore.TranslateText(__instance.text.text);
			if (__instance.text_shadow != null)
				__instance.text_shadow.text = StringStore.TranslateText(__instance.text_shadow.text);
        }
    }
}
