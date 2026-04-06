using HarmonyLib;
using UnityEngine.UI;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using System.IO;
using System;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
	public class NoticePauseMenu_Patch
	{
        public static string changelogText = "";

		public static void Pre_Awake(BaseMenu __instance)
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

		public static void Post_Awake(BaseMenu __instance)
		{
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
            FileLoader.LoadChangelogText();
            
            GameObject contentObject = __instance.transform.FindChild("Scroll View/Viewport/Content").gameObject;

            TextMeshProUGUI contentText = contentObject.GetComponent<TextMeshProUGUI>();
            contentText.text = changelogText;
            contentText.margin = new Vector4(6, 2, 12, 0);

            contentText.enableWordWrapping = true;
            contentText.overflowMode = TextOverflowModes.ScrollRect;

            Canvas.ForceUpdateCanvases();
            contentText.ForceMeshUpdate();

            ContentSizeFitter sizeFitter = contentObject.AddComponent<ContentSizeFitter>();
            sizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
        }
    }
}
