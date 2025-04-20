using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(TravelBuffOptionButton))]
    public static class TravelBuffOptionButton_Patch
    {
        [HarmonyPatch(nameof(TravelBuffOptionButton.SetBuff))]
        [HarmonyPostfix]
        private static void Start(TravelBuffOptionButton __instance)
        {
            __instance.introduce.text = StringStore.TranslateText(__instance.introduce.text);
        }
        //[HarmonyPatch(nameof(TravelMenuMgr.SetText))]
        //[HarmonyPostfix]
        //private static void SetText(TravelMenuMgr __instance)
        //{
        //	foreach(TextMeshProUGUI text in __instance.textMesh)
        //	{
        //		text.text = StringStore.TranslateText(text.text);
        //	}
        //	foreach(TextMeshProUGUI text in __instance.textMeshShadow)
        //	{
        //		text.text = StringStore.TranslateText(text.text);
        //	}
        //}
        //[HarmonyPatch(nameof(TravelMenuMgr.SetRichText), [typeof(int), typeof(int), typeof(TextMeshProUGUI), typeof(string)])]
        //[HarmonyPostfix]
        //private static void SetRichText(TravelMenuMgr __instance)
        //{
        //	foreach(TextMeshProUGUI text in __instance.textMesh)
        //	{
        //		text.text = StringStore.TranslateText(text.text);
        //	}
        //	foreach(TextMeshProUGUI text in __instance.textMeshShadow)
        //	{
        //		text.text = StringStore.TranslateText(text.text);
        //	}
        //}
    }
}
