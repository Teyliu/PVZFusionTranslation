using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(ExploreEnterWindow))]
    public static class ExploreEnterWindow_Patch
    {
        [HarmonyPatch(nameof(ExploreEnterWindow.Awake))]
        [HarmonyPostfix]
        private static void Awake(ExploreEnterWindow __instance)
        {
            PlantType thePlantType = (PlantType)__instance.selfType;

            __instance.nameText.text = Utils.GetPlantNameFromAlmanac(thePlantType);

            if(__instance.nameText.text == "")
            {
                StringStore.TranslateText(__instance.nameText.text);
            }

            __instance.nameText.font = FontStore.LoadTMPFont(Utils.Language.ToString());
        }

        [HarmonyPatch(nameof(ExploreEnterWindow.SetInfo))]
        [HarmonyPostfix]
        private static void SetInfo(ExploreEnterWindow __instance)
        {
            PlantType thePlantType = (PlantType)__instance.selfType;

            __instance.nameText.text = Utils.GetPlantNameFromAlmanac(thePlantType);

            if (__instance.nameText.text == "")
            {
                StringStore.TranslateText(__instance.nameText.text);
            }

            __instance.nameText.font = FontStore.LoadTMPFont(Utils.Language.ToString());
        }

        [HarmonyPatch(nameof(ExploreEnterWindow.SetIcon))]
        [HarmonyPostfix]
        private static void SetIcon(ExploreEnterWindow __instance)
        {
            PlantType thePlantType = (PlantType)__instance.selfType;

            __instance.nameText.text = Utils.GetPlantNameFromAlmanac(thePlantType);

            if (__instance.nameText.text == "")
            {
                StringStore.TranslateText(__instance.nameText.text);
            }

            __instance.nameText.font = FontStore.LoadTMPFont(Utils.Language.ToString());
        }

        [HarmonyPatch(nameof(ExploreEnterWindow.SetDisable))]
        [HarmonyPostfix]
        private static void SetDisable(ExploreEnterWindow __instance)
        {
            if (__instance.disabled)
            {
                __instance.nameText.text = StringStore.TranslateText("敬请期待");
            }

            __instance.nameText.font = FontStore.LoadTMPFont(Utils.Language.ToString());
        }
    }
}
