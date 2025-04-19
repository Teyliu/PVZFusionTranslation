using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects
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
			string zombieText = StringStore.patchesStore["Zombies"][Utils.Language.ToString()];
			__instance.t.text = string.Format(zombieText + " {0}", Board.Instance.enermyCount);
			#else
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont();
			string zombieText = StringStore.patchesStore["Zombies"]["Spanish"];
			__instance.t.text = string.Format(zombieText + " {0}", Board.Instance.enermyCount);
            #endif
			
			__instance.t.font = fontAsset;
		}
	}
}
