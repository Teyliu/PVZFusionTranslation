using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(GameSpeedMgr))]
    public class PauseMenu_Patch
    {
        [HarmonyPatch(nameof(GameSpeedMgr.Update))]
        [HarmonyPostfix]
        public static void Update(GameSpeedMgr __instance)
        {
            if(__instance.tmp != null)
            {
                __instance.tmp.text = StringStore.TranslateText(__instance.tmp.text);
            }
        }
    }
}