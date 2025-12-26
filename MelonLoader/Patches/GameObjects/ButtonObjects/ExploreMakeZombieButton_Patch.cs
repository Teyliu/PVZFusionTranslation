using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects
{
	[HarmonyPatch(typeof(ExploreMakeZombieButton))]
	public class ExploreMakeZombieButton_Patch
    {
		[HarmonyPostfix]
		[HarmonyPatch(nameof(ExploreMakeZombieButton.Start))]
		public static void Start(ExploreMakeZombieButton __instance)
		{
			__instance.sceneText.text = Utils.GetZombieNameFromAlmanac(__instance.theZombieType);
			__instance.sceneText.font = FontStore.LoadTMPFont(Utils.Language.ToString());
		}
	}
}