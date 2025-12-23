//using HarmonyLib;
//using Il2Cpp;
//using Il2CppTMPro;
//using PvZ_Fusion_Translator.AssetStore;
//using UnityEngine;
//using UnityEngine.UI;

//namespace PvZ_Fusion_Translator.Patches.GameObjects
//{
//    [HarmonyPatch(typeof(UIBtn))]
//    public static class UIBtn_Patch
//    {
//        [HarmonyPatch(nameof(UIBtn.Awake))]
//        [HarmonyPostfix]
//        private static void Postfix_Awake(UIBtn __instance)
//        {
//            if(__instance.TryGetComponent<BackToIndex>(out BackToIndex component))
//            {
//                Utils.ConvertButtonText(__instance.transform.parent, component.name);
//            }
//        }
//    }
//}
