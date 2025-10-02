using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using UnityEngine;
using PvZ_Fusion_Translator.AssetStore;
	
namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects
{
    [HarmonyPatch(typeof(MainMenu_Btn))]
	public static class MainMenu_Btn_Patch
    {
		//public static List<GameObject> speechBubbles = new List<GameObject>();

		//[HarmonyPatch(nameof(MainMenu_Btn.OnMouseEnter))]
		//[HarmonyPostfix]
		//private static void OnMouseEnter(MainMenu_Btn __instance)
		//{
		//	string textToShow = null;
			
		//	if(__instance.transform.parent.name == "recipe")
		//	{
		//		textToShow = "探索模式";
		//	} 
		//	else if (__instance.name == "mysterious")
		//	{
		//		textToShow = "神秘模式";
		//	}

		//	if(textToShow != null)
		//	{
		//		InGameText.Instance.ShowText(textToShow, 2.0f);
		//	}
  //      }
	}

}
