using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects;

[HarmonyPatch(typeof(UIButton))]
public static class UIButton_Patch
{
    [HarmonyPatch(typeof(UIButton), nameof(UIButton.Start)), HarmonyPostfix]
    public static void Start(UIButton __instance)
    {
        if (__instance.transform.childCount >= 2)
        {
            var font = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach (var text in __instance.transform.GetComponentsInChildren<TextMeshProUGUI>())
            {
                if (__instance.transform.name == "Goback")
                    text.text = "合上";

                text.text = StringStore.TranslateText(text.text);
                text.font = font;
            }
        }
        else
        {
            StringStore.TranslateTextTransform(__instance.transform);

            if (__instance.transform.name != "Goback")
                return;

            foreach (var text in __instance.transform.GetComponentsInChildren<TextMeshProUGUI>())
                text.text = StringStore.TranslateText("合上");
        }
    }

    [HarmonyPatch(nameof(UIButton.OnMouseUpAsButton)), HarmonyPostfix]
    public static void Postfix_OnMouseUpAsButton(UIButton __instance)
    {
        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = StringStore.TranslateText(txt.text);
            txt.font = FontStore.LoadTMPFont(Utils.Language.ToString());
        }
    }
}
