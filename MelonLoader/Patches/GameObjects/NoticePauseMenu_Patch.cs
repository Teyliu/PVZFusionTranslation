using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using UnityEngine.UI;
using static PvZ_Fusion_Translator.FileLoader;

namespace PvZ_Fusion_Translator.Patches.GameObjects
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

            //float textHeight = contentText.preferredHeight;
            //RectTransform contentRect = contentObject.GetComponent<RectTransform>();
            //contentRect.sizeDelta = new Vector2(contentRect.sizeDelta.x, textHeight);

            ContentSizeFitter sizeFitter = contentObject.AddComponent<ContentSizeFitter>();
            sizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
        }
    }
}