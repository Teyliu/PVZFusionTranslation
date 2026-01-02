using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(AbyssStoreMenu))]
    public static class AbyssStoreMenu_Patch
    {
        [HarmonyPatch(nameof(AbyssStoreMenu.Update))]
        [HarmonyPostfix]
        private static void Update(AbyssStoreMenu __instance)
        {
            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());

            foreach(TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.text = StringStore.TranslateText(text.text);
                text.font = fontAsset;
            }
        }
    }
}
