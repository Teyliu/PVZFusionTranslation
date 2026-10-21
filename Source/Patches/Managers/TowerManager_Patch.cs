using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Managers;

[HarmonyPatch(typeof(TowerManager))]
public static class TowerManager_Patch
{
    public static readonly List<Transform> UpdatedText = [];

    public static void UpdateText()
    {
        foreach (var transform in UpdatedText.Where(transform => transform != null)
           .Where(transform => transform.gameObject.active))
            transform.GetComponent<TextMeshProUGUI>().text =
                StringStore.TranslateText(transform.GetComponent<TextMeshProUGUI>().text);
    }
}
