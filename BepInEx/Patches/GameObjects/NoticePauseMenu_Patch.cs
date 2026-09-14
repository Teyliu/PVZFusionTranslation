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
            if (__instance == null || __instance.transform == null) return;
            Transform contentTransform = __instance.transform.Find("Scroll View/Viewport/Content");
            if (contentTransform == null) return;

            TextMeshProUGUI contentText = contentTransform.GetComponent<TextMeshProUGUI>();
            if (contentText == null || string.IsNullOrEmpty(contentText.text)) return;

            try
            {
                File.WriteAllText(Path.Combine(FileLoader.GetAssetDir(FileLoader.AssetType.Dumps), "changelog.txt"), contentText.text);

                string stringDir = FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language);
                string changelogDir = Path.Combine(stringDir, "changelog.txt");

                if (!File.Exists(changelogDir))
                {
                    File.WriteAllText(changelogDir, contentText.text);
                }
            }
            catch (Exception ex)
            {
                Log.LogError($"[NoticePauseMenu_Patch.Pre_Awake] Error saving changelog: {ex.Message}");
            }
        }

		public static void Post_Awake(BaseMenu __instance)
		{
            if (__instance == null || __instance.transform == null) return;
            Transform contentTransform = __instance.transform.Find("Scroll View/Viewport/Content");
            if (contentTransform == null) return;

            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
            FileLoader.LoadChangelogText();

            TextMeshProUGUI contentText = contentTransform.GetComponent<TextMeshProUGUI>();
            if (contentText == null) return;

            contentText.text = changelogText;
            contentText.margin = new Vector4(6, 2, 12, 0);

            contentText.enableWordWrapping = true;
            contentText.overflowMode = TextOverflowModes.ScrollRect;

            Canvas.ForceUpdateCanvases();
            contentText.ForceMeshUpdate();

            ContentSizeFitter sizeFitter = contentTransform.gameObject.GetComponent<ContentSizeFitter>() ?? contentTransform.gameObject.AddComponent<ContentSizeFitter>();
            if (sizeFitter != null)
            {
                sizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
            }
        }
    }
}
