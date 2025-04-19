using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects
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