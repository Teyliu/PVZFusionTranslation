using PvZ_Fusion_Translator.AssetStore;
using UnityEngine.UI;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

public static class NoticePauseMenu_Patch
{
#pragma warning disable CA2211
    public static string ChangelogText = "";
#pragma warning restore CA2211
    public static void Pre_Awake(BaseMenu __instance)
    {
        var contentObject = __instance.transform.FindChild("Scroll View/Viewport/Content").gameObject;

        var contentText = contentObject.GetComponent<TextMeshProUGUI>();

        File.WriteAllText(
            Path.Combine(FileLoader.GetAssetDir(FileLoader.AssetType.Dumps), "changelog.txt"),
            contentText.text
        );

        var stringDir = FileLoader.GetAssetDir(FileLoader.AssetType.Strings, Utils.Language);
        var changelogDir = Path.Combine(stringDir, "changelog.txt");

        if (!File.Exists(changelogDir))
            File.WriteAllText(changelogDir, contentText.text);
    }

    public static void Post_Awake(BaseMenu __instance)
    {
        _ = FontStore.LoadTMPFont(Utils.Language.ToString());
        FileLoader.LoadChangelogText();

        var contentObject = __instance.transform.FindChild("Scroll View/Viewport/Content").gameObject;

        var contentText = contentObject.GetComponent<TextMeshProUGUI>();
        contentText.text = ChangelogText;
        contentText.margin = new(6, 2, 12, 0);

        contentText.enableWordWrapping = true;
        contentText.overflowMode = TextOverflowModes.ScrollRect;

        Canvas.ForceUpdateCanvases();
        contentText.ForceMeshUpdate();

        //float textHeight = contentText.preferredHeight;
        //RectTransform contentRect = contentObject.GetComponent<RectTransform>();
        //contentRect.sizeDelta = new Vector2(contentRect.sizeDelta.x, textHeight);

        var sizeFitter = contentObject.AddComponent<ContentSizeFitter>();
        sizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
    }
}
