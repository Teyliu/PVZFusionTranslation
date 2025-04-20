using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.MinorObjects
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
