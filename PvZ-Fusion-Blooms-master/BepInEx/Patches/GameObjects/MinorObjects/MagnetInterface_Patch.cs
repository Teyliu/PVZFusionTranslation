using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects
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
