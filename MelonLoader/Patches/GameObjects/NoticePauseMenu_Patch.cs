using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using UnityEngine.UI;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(NoticeMenu))]
	public class NoticePauseMenu_Patch
	{
		[HarmonyPrefix]
		[HarmonyPatch(nameof(NoticeMenu.Awake))]
		private static void Pre_Awake(NoticeMenu __instance)
		{
            GameObject contentObject = __instance.transform.FindChild("Scroll View/Viewport/Content").gameObject;

            TextMeshProUGUI contentText = contentObject.GetComponent<TextMeshProUGUI>();
            File.WriteAllText(Path.Combine(FileLoader.GetAssetDir(FileLoader.AssetType.Dumps), "changelog.txt"), contentText.text);

            string stringDir = FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language);
            string changelogDir = Path.Combine(stringDir, "changelog.txt");

            if (!File.Exists(changelogDir))
            {
                File.WriteAllText(changelogDir, contentText.text);
            }
        }
	
		[HarmonyPostfix]
		[HarmonyPatch(nameof(NoticeMenu.Awake))]
		private static void Post_Awake(NoticeMenu __instance)
		{
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
            string stringDir = FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language);
            string changelogDir = Path.Combine(stringDir, "changelog.txt");

            string changelogText = File.ReadAllText(changelogDir);

            GameObject contentObject = __instance.transform.FindChild("Scroll View").GetChild(0).GetChild(0).gameObject; //bc normal Find or FindChild didn't work
            
			TextMeshProUGUI contentText = contentObject.GetComponent<TextMeshProUGUI>();
            contentText.text = changelogText;

            ContentSizeFitter sizeFitter = contentObject.AddComponent<ContentSizeFitter>();
            sizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
        }
	}
}