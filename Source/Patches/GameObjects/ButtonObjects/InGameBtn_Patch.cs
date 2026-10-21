using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects;

[HarmonyPatch(typeof(InGameBtn))]
public static class InGameBtn_Patch
{
    [HarmonyPatch(nameof(InGameBtn.Start)), HarmonyPostfix]
    private static void Start(InGameBtn __instance)
    {
        var sceneText = __instance.transform.FindChild("SceneText");

        if (sceneText != null)
        {
            var sceneTextTMP = sceneText.transform.GetComponent<TextMeshProUGUI>();

            if (sceneTextTMP != null)
                StringStore.TranslateText(sceneTextTMP);

            var sceneTextShadow = sceneText.transform.FindChild("SceneText");

            if (sceneTextShadow != null)
            {
                var sceneTextShadowTMP = sceneTextShadow.transform.GetComponent<TextMeshProUGUI>();

                if (sceneTextShadowTMP != null)
                    StringStore.TranslateText(sceneTextShadowTMP);
            }
        }

        foreach (var text in __instance.transform.GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateText(text.text);
    }
}
