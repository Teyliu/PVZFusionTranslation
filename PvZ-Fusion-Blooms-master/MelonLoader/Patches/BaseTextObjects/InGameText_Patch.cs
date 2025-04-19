using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.BaseTextObjects
{
	[HarmonyPatch(typeof(InGameText))]
	public static class InGameText_Patch
	{
		[HarmonyPatch(nameof(InGameText.ShowText), new Type[] { typeof(string), typeof(float), typeof(bool) })]
		[HarmonyPrefix]
		private static void ShowText(InGameText __instance, ref string text) => text = StringStore.TranslateText(text, true);

		[HarmonyPatch(nameof(InGameText.ShowText), new Type[] { typeof(string), typeof(float), typeof(bool) })]
		[HarmonyPostfix]
		private static void ShowText(InGameText __instance)
		{

			#if MULTI_LANGUAGE
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
			#else
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont();
			#endif
			
			foreach (TextMeshProUGUI txt in __instance.textMeshes)
			{
				txt.text = StringStore.TranslateText(txt.text, true);
                txt.font = fontAsset;
			}
		}
	}
}