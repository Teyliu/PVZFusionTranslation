#if false
using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects;

[HarmonyPatch(typeof(PVPPotBtn))] // ReSharper disable once InconsistentNaming
public class PVPPotBtn_Patch
{
    [HarmonyPostfix]
    [HarmonyPatch(nameof(PVPPotBtn.OnMouseUpAsButton))]
    public static void OnMouseUpAsButton(PVPPotBtn __instance)
    {
        Transform sceneText = __instance.transform.FindChild("text");

        if (sceneText != null)
        {
            var sceneTextTMP = sceneText.transform.GetComponent<TextMeshProUGUI>();

            if (sceneTextTMP != null)
                sceneTextTMP.text = StringStore.TranslateText(sceneTextTMP.text);
        }

        var sceneTextShadow = sceneText.transform.FindChild("text_1");

        if (sceneTextShadow != null)
        {
            var sceneTextShadowTMP = sceneTextShadow.transform.GetComponent<TextMeshProUGUI>();

            if (sceneTextShadowTMP != null)
                sceneTextShadowTMP.text = StringStore.TranslateText(sceneTextShadowTMP.text);
        }

        if (!__instance.name.Equals("ChangeBg_3") && !__instance.name.Equals("ChangeBg_4"))
            return;

        __instance.gameObject.SetActive(false);
        __instance.gameObject.SetActive(true);
    }
}
#endif
