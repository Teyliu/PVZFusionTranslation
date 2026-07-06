using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Il2Cpp;
using UnityEngine;
using HarmonyLib;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(PumpinerChestMenu))]
    public static class PumpinerChestMenu_Patch
    {
        [HarmonyPatch(nameof(PumpinerChestMenu.InitPlants))]
        [HarmonyPostfix]
        public static void Post_InitPlants(PumpinerChestMenu __instance)
        {
            Transform closeBtnTransform = __instance.transform.Find("SampleButton");
            TextMeshProUGUI txt = closeBtnTransform.GetComponentInChildren<TextMeshProUGUI>();
            txt.text = StringStore.TranslateText("合上");
        }
    }
}
