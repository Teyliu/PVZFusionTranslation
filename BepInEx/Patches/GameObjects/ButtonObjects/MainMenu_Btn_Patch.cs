using HarmonyLib;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects.ButtonObjects
{
    [HarmonyPatch(typeof(MainMenu_Btn))]
    public static class MainMenu_Btn_Patch
    {
        [HarmonyPatch(nameof(MainMenu_Btn.OnMouseEnter))]
        [HarmonyPostfix]
        private static void OnMouseEnter(MainMenu_Btn __instance)
        {
            string textToShow = null;

            if (__instance.transform.parent.name == "recipe")
            {
                textToShow = "探索模式";
            }
            else if (__instance.name == "mysterious")
            {
                textToShow = "神秘模式";
            }

            if (textToShow != null)
            {
                InGameText.Instance.ShowText(textToShow, 2.0f);
            }
        }
    }
}


