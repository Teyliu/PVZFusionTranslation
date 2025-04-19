using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects
{
    [HarmonyPatch(typeof(PauseMenu_Btn))]
	public static class PauseMenu_Btn_Patch
	{
		[HarmonyPatch(nameof(PauseMenu_Btn.Start))]
		[HarmonyPostfix]
		private static void Start(PauseMenu_Btn __instance) => StringStore.TranslateTextTransform(__instance.transform);
	}

}
