using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(UIDifficulty))]
	public static class UIDifficulty_Patch
	{
		[HarmonyPatch(nameof(UIDifficulty.Update))]
		[HarmonyPostfix]
		private static void Update(UIDifficulty __instance)
		{

			#if MULTI_LANGUAGE
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
			string difficultyText = StringStore.patchesStore["Difficulty"][Utils.Language.ToString()];
			__instance.t.text = string.Format(difficultyText + " {0}", GameAPP.difficulty);
			#else
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont();
			string difficultyText = StringStore.patchesStore["Difficulty"]["Spanish"];
			__instance.t.text = string.Format("Difficulty: {0}", GameAPP.difficulty);
            #endif

			__instance.t.autoSizeTextContainer = false;
			__instance.t.font = fontAsset;
		}
	}
}
