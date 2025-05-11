using HarmonyLib;

using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(UIZombieNum))]
	public static class UIZombieNum_Patch
	{
		[HarmonyPatch(nameof(UIZombieNum.Update))]
		[HarmonyPostfix]
		private static void Update(UIZombieNum __instance)
		{
			
			#if MULTI_LANGUAGE
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
			string zombieText = StringStore.TranslateText(__instance.t.text);
			__instance.t.text = zombieText;
			#else
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont();
			string zombieText = StringStore.patchesStore["Zombies"]["Spanish"];
			__instance.t.text = string.Format(zombieText + " {0}", Board.Instance.enermyCount);
            #endif
			
			__instance.t.font = fontAsset;
		}
	}
}
