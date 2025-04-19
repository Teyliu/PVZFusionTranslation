using HarmonyLib;
using Il2Cpp;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects
{
	[HarmonyPatch(typeof(MagnetInterface))]
	public class MagnetInterface_Patch
	{
		[HarmonyPostfix]
		[HarmonyPatch(nameof(MagnetInterface.Update))]
		private static void Update(MagnetInterface __instance)
		{
			StringStore.TranslateTextTransform(__instance.transform);
		}
	}
}