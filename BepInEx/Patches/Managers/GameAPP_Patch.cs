using HarmonyLib;
using System;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
	[HarmonyPatch(typeof(GameAPP))]
	public class GameAPP_Patch
    {
		[HarmonyPatch(nameof(GameAPP.Update))]
		[HarmonyPostfix]
		private static void Update(GameAPP __instance)
		{
			Core.Instance.OnUpdate();
		}
	}
}