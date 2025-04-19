using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using TMPro;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
	[HarmonyPatch(typeof(UIZombieNum))]
	public static class UIZombieNum_Patch
	{
		[HarmonyPatch(nameof(UIZombieNum.Update))]
		[HarmonyPostfix]
		private static void Update(UIZombieNum __instance)
		{
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
			string zombieText = StringStore.patchesStore["Zombies"][Utils.Language.ToString()];

			__instance.t.text = string.Format(zombieText + " {0}", Board.Instance.enermyCount);
			__instance.t.font = fontAsset;
		}
	}
}
