using HarmonyLib;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
	[HarmonyPatch(typeof(TravelBuff))]
	public static class TravelBuff_Patch
	{
		[HarmonyPatch(nameof(TravelBuff.OnMouseUpAsButton))]
		[HarmonyPostfix]
		private static void OnMouseUpAsButton()
		{
			if (TravelBuffMgr.Instance == null) return;
			TravelBuffMgr.Instance.text = AssetStore.StringStore.TranslateText(TravelBuffMgr.Instance.text);
			TravelBuffMgr.Instance.text2 = AssetStore.StringStore.TranslateText(TravelBuffMgr.Instance.text2);
		}
	}
}
