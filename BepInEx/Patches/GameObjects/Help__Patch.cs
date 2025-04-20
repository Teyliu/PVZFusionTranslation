using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using TMPro;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
	[HarmonyPatch(typeof(Help_))]
	public class Help__Patch
	{
		[HarmonyPostfix]
		[HarmonyPatch(nameof(Help_.Start))]
		private static void Start(Help_ __instance)
		{
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
			Transform warningTransform = __instance.transform.GetChild(0);
			Transform warningTextTransform = warningTransform.FindChild("文字");
			Transform warningTextShadowTransform = warningTransform.FindChild("文字2");
			Transform[] array = [warningTextTransform, warningTextShadowTransform];

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					array[i].GetComponent<TextMeshProUGUI>().text = StringStore.TranslateText(array[i].GetComponent<TextMeshProUGUI>().text);
					array[i].GetComponent<TextMeshProUGUI>().font = fontAsset;
				}
			}
		}
	}
}
