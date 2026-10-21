#if false
using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Odyssey;

[HarmonyPatch(typeof(OppositeBuffManager))]
public static class OppositeBuffManager_Patch
{
    public static Dictionary<BuffType, string> buffLinks = TravelMgr_Patch.buffLinks;

    public static Dictionary<string, SortedDictionary<int, string>> translatedTravelBuffs =
        TravelMgr_Patch.translatedTravelBuffs;

    public const string BadPattern = @"^但(.*)";

    public static readonly string BadFormat = StringStore.translationStringRegex.ContainsKey(BadPattern)
        ? StringStore.translationStringRegex[BadPattern]
        : "But, {0}";

    public static TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

    [HarmonyPatch(nameof(OppositeBuffManager.SetText)), HarmonyPostfix]
    private static void SetText(OppositeBuffManager __instance)
    {
        if (TravelMgr_Patch.travelBuffString.ContainsKey(__result))
            __result = TravelMgr_Patch.travelBuffString[__result];
        else if (TravelMgr_Patch.travelBuffString.ContainsKey(TravelMgr_Patch.RemoveBuffName(__result)))
            __result = TravelMgr_Patch.travelBuffString[TravelMgr_Patch.RemoveBuffName(__result)];
    }

    public static void TranslateOppositeText(
        Il2CppSystem.Collections.Generic.List<TextMeshProUGUI> textList,
        Il2CppSystem.Object buff,
        bool isBad = false
    )
    {
        var buffText = TravelMgr.Instance.GetText(buff);

        foreach (var text in textList)
        {
            text.text = isBad ? string.Format(BadFormat, buffText) : buffText;
            text.font = fontAsset;
        }
    }
}
#endif
