using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;
using static PvZ_Fusion_Translator.Patches.Modes.Odyssey.TravelMgr_Patch;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey;

[HarmonyPatch(typeof(TravelLookBuff))]
public static class TravelLookBuff_Patch
{
    [HarmonyPatch(nameof(TravelLookBuff.Clear)), HarmonyPostfix]
    public static void Post_Clear(TravelLookBuff __instance)
    {
        __instance.introduce.text = StringStore.TranslateText("无");
        __instance.set = false;

        foreach (var text in __instance.transform.FindChild("Images")
           .FindChild("Button")
           .GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateText(text.text);
    }

    [HarmonyPatch(nameof(TravelLookBuff.OnMouseUpAsButton)), HarmonyPostfix]
    public static void Post_OnMouseUpAsButton(TravelLookBuff __instance)
    {
        foreach (var text in __instance.transform.FindChild("Images")
           .FindChild("Button")
           .GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateText(text.text);
    }

    [HarmonyPatch(nameof(TravelLookBuff.SetBuff)), HarmonyPostfix]
    public static void Post_SetBuff(TravelLookBuff __instance)
    {
        /*SortedDictionary<int, string> buffSet = translatedTravelBuffs[buffLinks[__instance.buffType]];
        string buffText = buffSet.ContainsKey(__instance.buffIndex) ? buffSet[__instance.buffIndex] : StringStore.TranslateText(__instance.introduce.text);
        __instance.introduce.text = buffText;*/

        foreach (var text in __instance.transform.FindChild("Images")
           .FindChild("Introduce")
           .GetComponentsInChildren<TextMeshProUGUI>())
        {
            if (TravelBuffString.TryGetValue(text.text, out var translatedBuff))
                text.text = AddBuffName(translatedBuff);

            if (!Utils.CheckForUntranslatedText(text.text))
                text.text = AddBuffName(text.text);

            if (!TravelBuffString.ContainsKey(text.text) && Utils.CheckForUntranslatedText(text.text))
                text.text = StringStore.TranslateText(text.text);
        }

        foreach (var text in __instance.transform.FindChild("Images")
           .FindChild("Button")
           .GetComponentsInChildren<TextMeshProUGUI>())
            text.text = StringStore.TranslateText(text.text);
    }
}
