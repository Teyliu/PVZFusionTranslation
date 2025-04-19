using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects
{
	[HarmonyPatch(typeof(PlayerName))]
	public static class PlayerName_Patch
	{
		[HarmonyPostfix]
		[HarmonyPatch(nameof(PlayerName.Update))]
		private static void Update(PlayerName __instance)
		{
			__instance.textMesh.text = StringStore.TranslateText(__instance.textMesh.text);
		}   
	}
}
