using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.Managers
{
    [HarmonyPatch(typeof(IZBottomMenu))]
	public static class IZBottomMenu_Patch
    {
		[HarmonyPatch(nameof(IZBottomMenu.ChangeString))]
		[HarmonyPostfix]
		public static void ChangeStringz(IZBottomMenu __instance)
		{
			TextMeshProUGUI[] array =
            [
                __instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>(),
				__instance.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>(),
			];
			for (int i = 0; i < array.Length; i++)
			{
                string fStr = StringStore.translationStringRegex["([^\\s]+)，推荐难度：(\\d+)"];
                string[] parts = array[i].text.Split("，推荐难度：");

                if(new Regex("([^\\s]+)，推荐难度：(\\d+)").IsMatch(array[i].text))
                {
                    array[i].text = string.Format(fStr, StringStore.TranslateText(parts[0]), parts[1]);
                }
                
                array[i] = StringStore.TranslateText(array[i]);
				array[i].text = array[i].text.Replace("\n", " ");
			}
		}

        [HarmonyPatch(nameof(IZBottomMenu.SetLevelName))]
        [HarmonyPostfix]
        public static void SetLevelName(IZBottomMenu __instance)
        {
            TextMeshProUGUI[] array =
            [
                __instance.transform.GetChild(0).GetComponent<TextMeshProUGUI>(),
                __instance.transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>(),
            ];
            for (int i = 0; i < array.Length; i++)
            {
                string fStr = StringStore.translationStringRegex["([^\\s]+)，推荐难度：(\\d+)"];
                string[] parts = array[i].text.Split("，推荐难度：");

                if (new Regex("([^\\s]+)，推荐难度：(\\d+)").IsMatch(array[i].text))
                {
                    array[i].text = string.Format(fStr, StringStore.TranslateText(parts[0]), parts[1]);
                }

                array[i] = StringStore.TranslateText(array[i]);
                array[i].text = array[i].text.Replace("\n", " ");
            }
        }
    }
}