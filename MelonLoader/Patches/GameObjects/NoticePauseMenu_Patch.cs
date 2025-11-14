using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.Json;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(NoticeMenu))]
	public class NoticePauseMenu_Patch
	{
		[HarmonyPrefix]
		[HarmonyPatch(nameof(NoticeMenu.Awake))]
		private static void Pre_Awake(NoticeMenu __instance)
		{
            GameObject contentObject = __instance.transform.FindChild("Scroll View").GetChild(0).GetChild(0).gameObject; //bc normal Find or FindChild didn't work

            TextMeshProUGUI contentText = contentObject.GetComponent<TextMeshProUGUI>();
            File.WriteAllText(Path.Combine(FileLoader.GetAssetDir(FileLoader.AssetType.Dumps), "changelog.txt"), contentText.text);
        }
	
		[HarmonyPostfix]
		[HarmonyPatch(nameof(NoticeMenu.Awake))]
		private static void Post_Awake(NoticeMenu __instance)
		{
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
			string changelogText = File.ReadAllText(Path.Combine(FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language), "changelog.txt"));
			
            GameObject contentObject = __instance.transform.FindChild("Scroll View").GetChild(0).GetChild(0).gameObject; //bc normal Find or FindChild didn't work
            
			TextMeshProUGUI contentText = contentObject.GetComponent<TextMeshProUGUI>();
			contentText.text = changelogText;

            ContentSizeFitter sizeFitter = contentObject.AddComponent<ContentSizeFitter>();
            sizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
        }
	}
}