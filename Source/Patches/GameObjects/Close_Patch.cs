#if false
using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(Close))]
public static class Close_Patch
{
    [HarmonyPatch(nameof(Close.Start)), HarmonyPostfix]
    private static void Close_Start(Close __instance)
    {
        TextMeshPro closeText = __instance.transform.GetChild(0).GetComponent<TextMeshPro>();
        closeText.text = "合上";
        closeText = StringStore.TranslateText(closeText);
        closeText.autoSizeTextContainer = true;

        var almanacTransform = __instance.transform.parent.transform;
        var nameTransform = almanacTransform.Find("Name");

        if (nameTransform != null)
        {
            var nameTMP = nameTransform.transform.GetComponent<TextMeshPro>();

            if (nameTMP)
            {
                nameTMP = StringStore.TranslateText(nameTMP);
                nameTMP.autoSizeTextContainer = true;
            }

            var nameShadowTransform = nameTransform.Find("NameShadow");

            if (nameShadowTransform)
            {
                var nameShadowTMP = nameShadowTransform.transform.GetComponent<TextMeshPro>();

                if (nameShadowTMP)
                {
                    nameShadowTMP = StringStore.TranslateText(nameShadowTMP);
                    nameShadowTMP.autoSizeTextContainer = true;
                }
            }
        }

        StringStore.TranslateTextTransform(almanacTransform.Find("Back"), true);
        StringStore.TranslateTextTransform(almanacTransform.Find("NextPage"));
        StringStore.TranslateTextTransform(almanacTransform.Find("LastPage"));
    }
}
#endif
