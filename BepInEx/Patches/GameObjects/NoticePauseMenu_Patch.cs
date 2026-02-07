using HarmonyLib;
using UnityEngine.UI;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;
using System.IO;
using System;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
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

            // Highlight "JustNull" with purple bold color
            if (!string.IsNullOrEmpty(changelogText))
            {
                changelogText = changelogText.Replace("JustNull", "<b><color=#FF6B6B>JustNull</color></b>");
            }

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