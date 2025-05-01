using HarmonyLib;

using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(NoticeMenu))]
	public class NoticePauseMenu_Patch
	{
		[HarmonyPostfix]
		[HarmonyPatch(nameof(NoticeMenu.Start))]
		private static void Start(NoticeMenu __instance)
		{
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
			Transform warningTransform = __instance.transform.FindChild("窗口");
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