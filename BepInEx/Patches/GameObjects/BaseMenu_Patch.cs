using HarmonyLib;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(BaseMenu))]
    public static class BaseMenu_Patch
    {
        [HarmonyPatch(nameof(BaseMenu.Awake))]
        [HarmonyPrefix]
        private static void Pre_Awake(BaseMenu __instance)
        {
            if(__instance.name.Contains("NoticePauseMenu"))
            {
                NoticePauseMenu_Patch.Pre_Awake(__instance);
            }
        }

        [HarmonyPatch(nameof(BaseMenu.Awake))]
        [HarmonyPostfix]
        private static void Post_Awake(BaseMenu __instance)
        {
            if(__instance.name.Contains("NoticePauseMenu"))
            {
                NoticePauseMenu_Patch.Post_Awake(__instance);
            }

            TranslateBaseMenu(__instance, "Level");
            TranslateBaseMenu(__instance, "Levels");
            TranslateBaseMenu(__instance, "CustomLevel");
        }

        public static void TranslateBaseMenu(BaseMenu __instance, string levelsName)
        {
            Transform levels = __instance.transform.Find(levelsName);
            if (levels != null)
            {
                List<Transform> children = levels.GetComponentsInChildren<Transform>(true).ToList();
                foreach (Transform child in children)
                {
                    if (child.name == "Nextpage" || child.name == "LastPage" || child.name == "BackToIndex")
                    {
                        StringStore.TranslateTextTransform(child);
                    }
                }

                StringStore.TranslateTextTransform(__instance.transform.Find("Goback"));
                StringStore.TranslateTextTransform(__instance.transform.Find("Switich"));
            }
        }
    }
}
