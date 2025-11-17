using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects
{
	[HarmonyPatch(typeof(ExploreMakeSceneButton))]
	public class ExploreMakeSceneButton_Patch
    {
		[HarmonyPostfix]
		[HarmonyPatch(nameof(ExploreMakeSceneButton.Start))]
		public static void Start(ExploreMakeSceneButton __instance)
		{
			__instance.sceneText.text = (StringStore.translationString.ContainsKey(__instance.sceneText.text + "_FS")) ? StringStore.TranslateText(__instance.sceneText.text + "_FS") : StringStore.TranslateText(__instance.sceneText.text);
			__instance.sceneText.font = FontStore.LoadTMPFont(Utils.Language.ToString());
        }
	}
}