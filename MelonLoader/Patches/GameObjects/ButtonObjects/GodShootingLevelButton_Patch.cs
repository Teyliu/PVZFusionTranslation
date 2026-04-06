using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using MelonLoader;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects
{
	[HarmonyPatch(typeof(GodShootingLevelButton))]
	public static class GodShootingLevelButton_Patch
    {
		[HarmonyPatch(nameof(GodShootingLevelButton.Awake))]
		[HarmonyPostfix]
		private static void Awake(GodShootingLevelButton __instance)
		{
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

			foreach(TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
			{
				string originalKey = StringStore.translationString.FirstOrDefault(x => x.Value == txt.text).Key;
				txt.text = (StringStore.translationString.ContainsKey(originalKey + "_GS")) ? StringStore.TranslateText(originalKey + "_GS") : StringStore.TranslateText(txt.text);
                txt.font = fontAsset;
            }
		}
	}
}
