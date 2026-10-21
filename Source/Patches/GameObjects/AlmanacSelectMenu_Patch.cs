using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(AlmanacSelectMenu))]
public static class AlmanacSelectMenu_Patch
{
#pragma warning disable CA2211
    public static Dictionary<string, string> DetailStrings = new();
#pragma warning restore CA2211
    public static readonly Dictionary<string, string> DetailTranslateStrings = new();

    [HarmonyPatch(nameof(AlmanacSelectMenu.Awake)), HarmonyPostfix]
    public static void Awake(AlmanacSelectMenu __instance)
    {
        TranslateAlmanacSelectMenu(__instance);

        foreach (var uiButton in __instance.GetComponentsInChildren<UIButton>()
           .Where(uiButton => uiButton.gameObject.name.Contains("Selection(Clone)")))
            uiButton.clickEvent.AddListener(new Action(() => { TranslateAlmanacSelectMenu(__instance); }));
    }

    [HarmonyPatch(nameof(AlmanacSelectMenu.InitMenu)), HarmonyPostfix]
    public static void InitMenu(AlmanacSelectMenu __instance) => TranslateAlmanacSelectMenu(__instance);

    public static void TranslateAlmanacSelectMenu(AlmanacSelectMenu __instance)
    {
        var font = FontStore.LoadTMPFont(Utils.Language.ToString());

        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = DetailTranslateStrings.TryGetValue(txt.text, out var s)
                ? s
                : StringStore.TranslateText(txt.text);

            txt.font = font;
        }
    }
}
