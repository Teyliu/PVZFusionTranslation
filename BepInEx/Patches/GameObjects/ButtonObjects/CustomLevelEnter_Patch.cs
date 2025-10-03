using HarmonyLib;
using System;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using System.Linq;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.ButtonObjects
{
	[HarmonyPatch(typeof(CustomLevelEnter))]
	public static class CustomLevelEnter_Patch
    {
		[HarmonyPatch(nameof(CustomLevelEnter.Start))]
		[HarmonyPostfix]
		private static void Show(CustomLevelEnter __instance)
		{
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

			foreach(TextMeshProUGUI txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
			{
				string text = txt.text;
				Transform menuTransform = __instance.transform.parent.parent.parent.parent.parent.parent;
				string customIZStringKey = StringStore.translationString.FirstOrDefault(x => x.Value == text).Key + "_IZ";
				bool hasCustomIZString = StringStore.translationString.ContainsKey(customIZStringKey);

				if (hasCustomIZString && menuTransform.name.Contains("IZMenu"))
				{
					txt.text = StringStore.TranslateText(customIZStringKey);
				}
				else
				{
					txt.text = StringStore.TranslateText(text);
				}
				txt.font = fontAsset;
            }
		}
	}
}
