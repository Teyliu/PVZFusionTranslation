using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects
{
	[HarmonyPatch(typeof(MagnetBox))]
	public class MagnetBox_Patch
	{
		[HarmonyPostfix]
		[HarmonyPatch(nameof(MagnetBox.Update))]
		private static void Update(MagnetBox __instance)
		{
			StringStore.TranslateTextTransform(__instance.transform);
		}
	}
}