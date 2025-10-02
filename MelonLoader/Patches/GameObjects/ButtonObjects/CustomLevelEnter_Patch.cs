using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using MelonLoader;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects
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
                Transform menuTransform = __instance.transform.parent.parent.parent.parent.parent.parent; // guys i'm really sorry please forgive me
                string customIZStringKey = StringStore.translationString.FirstOrDefault(x => x.Value == text).Key + "_IZ"; // dawg what the fuck
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
