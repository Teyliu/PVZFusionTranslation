using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(Close))]
	public static class Close_Patch
	{
		[HarmonyPatch(nameof(Close.Start))]
		[HarmonyPostfix]
		private static void Close_Start(Close __instance)
		{

			TextMeshPro closeText = __instance.transform.GetChild(0).GetComponent<TextMeshPro>();
			closeText.text = "合上";
			closeText = StringStore.TranslateText(closeText);
			closeText.autoSizeTextContainer = true;

			Transform AlmanacTransform = __instance.transform.parent.transform;

			Transform nameTransform = AlmanacTransform.Find("Name");
			if (nameTransform != null)
			{
				TextMeshPro nameTMP = nameTransform.transform.GetComponent<TextMeshPro>();
				if (nameTMP)
				{
					nameTMP = StringStore.TranslateText(nameTMP);
					nameTMP.autoSizeTextContainer = true;
				}

				Transform nameShadowTransform = nameTransform.Find("NameShadow");
				if (nameShadowTransform)
				{
					TextMeshPro nameShadowTMP = nameShadowTransform.transform.GetComponent<TextMeshPro>();
					if (nameShadowTMP)
					{
						nameShadowTMP = StringStore.TranslateText(nameShadowTMP);
						nameShadowTMP.autoSizeTextContainer = true;
					}
				}
			}

			StringStore.TranslateTextTransform(AlmanacTransform.Find("Back"), true);
			StringStore.TranslateTextTransform(AlmanacTransform.Find("NextPage"));
			StringStore.TranslateTextTransform(AlmanacTransform.Find("LastPage"));

		}
	}
}
