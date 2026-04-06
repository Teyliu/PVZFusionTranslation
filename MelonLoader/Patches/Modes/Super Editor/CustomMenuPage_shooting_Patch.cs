using MelonLoader;
using HarmonyLib;
using UnityEngine;
using Il2Cpp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.Modes.Super_Editor
{
    [HarmonyPatch(typeof(CustomMenuPage_shooting))]
    public static class CustomMenuPage_shooting_Patch
    {
        [HarmonyPatch(nameof(CustomMenuPage_shooting.CreateRoute))]
        [HarmonyPostfix]
        public static void CreateRoute(CustomMenuPage_shooting __instance)
        {
            TranslateRoutes(__instance);
        }

        [HarmonyPatch(nameof(CustomMenuPage_shooting.CreateStage))]
        [HarmonyPostfix]
        public static void CreateStage(CustomMenuPage_shooting __instance)
        {
            TranslateRoutes(__instance);
        }

        [HarmonyPatch(nameof(CustomMenuPage_shooting.Awake))]
        [HarmonyPostfix]
        public static void Awake(CustomMenuPage_shooting __instance)
        {
            TranslateRoutes(__instance);
        }

        [HarmonyPatch(nameof(CustomMenuPage_shooting.SearchRoute))]
        [HarmonyPostfix]
        public static void SearchRoute(CustomMenuPage_shooting __instance)
        {
            TranslateRoutes(__instance);
        }

        [HarmonyPatch(nameof(CustomMenuPage_shooting.SearchAllRoute))]
        [HarmonyPostfix]
        public static void SearchAllRoute(CustomMenuPage_shooting __instance)
        {
            TranslateRoutes(__instance);
        }

        public static void TranslateRoutes(CustomMenuPage_shooting __instance)
        {
            foreach(TextMeshProUGUI text in __instance.scollContent.GetComponentsInChildren<TextMeshProUGUI>())
            {
                if (text.name == "PlantText")
                {
                    string plantName = Utils.GetPlantNameFromAlmanac(text.text);
                    text.text = (plantName != "") ? plantName : StringStore.TranslateText(text.text);
                }
            }
        }
    }
}
