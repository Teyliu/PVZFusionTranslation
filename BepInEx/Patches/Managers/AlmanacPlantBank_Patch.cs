/*
 * [3.6 OBSOLETE] AlmanacPlantBank_Patch.cs
 *
 * HISTORY:
 * - AlmanacPlantBank.InitNameAndInfoFromJson() was REMOVED in 3.6
 *   The old InitNameAndInfoFromJson code has been removed. Active patches remain below.
 * - The new almanac system uses AlmanacDataLoader and AlmanacPlantWindow instead
 *
 * MAINTENANCE NOTE:
 * If you need to modify almanac behavior in 3.6+, look at:
 * - AlmanacPlantWindow_Patch.cs (for plant display)
 * - AlmanacPlantMenu_Patch.cs (for plant list and search)
 * - FileLoader.cs LoadAlmanac() (for data loading)
 */

using HarmonyLib;
using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
    [HarmonyPatch(typeof(AlmanacPlantBank))]
    public static partial class AlmanacPlantBank_Patch
    {
        // [3.6 NOTE] OnMouseDown still exists in 3.6, but may behave differently
        // Keeping this for potential future use if needed
        [HarmonyPatch(nameof(AlmanacPlantBank.OnMouseDown))]
        [HarmonyPrefix]
        private static bool OnMouseDown(AlmanacPlantBank __instance)
        {
            TextMeshPro component = __instance.introduce.GetComponent<TextMeshPro>();
            if (component != null)
            {
                component.pageToDisplay = component.pageToDisplay > component.m_pageNumber ? 1 : component.pageToDisplay + 1;
                return false;
            }
            return true;
        }

        // [3.6 NOTE] PVPInit still exists in 3.6, keeping for reference
        [HarmonyPatch(nameof(AlmanacPlantBank.PVPInit))]
        [HarmonyPostfix]
        private static void PVPInit(AlmanacPlantBank __instance)
        {
            if (__instance.introduce != null)
            {
                TextMeshPro component = __instance.introduce.GetComponent<TextMeshPro>();
                if (component != null)
                {
                    component.autoSizeTextContainer = false;
                }
            }

            Transform banTransform = __instance.transform.Find("Ban");
            if (banTransform != null && banTransform.childCount > 0)
            {
                Transform banChild = banTransform.GetChild(0);
                if (banChild != null)
                {
                    TextMeshPro banText = banChild.GetComponent<TextMeshPro>();
                    if (banText != null)
                    {
                        banText.text = StringStore.TranslateText(banText.text);
                    }
                }
            }
        }

        // [3.6 NOTE] Start still exists in 3.6 AlmanacPlantBank, keeping for reference
        [HarmonyPatch(nameof(AlmanacPlantBank.Start))]
        [HarmonyPostfix]
        public static void Post_Start(AlmanacPlantBank __instance)
        {
            if (__instance.skinButton == null || __instance.skinButton.transform == null)
            {
                Log.LogWarning("[AlmanacPlantBank_Patch] Skin button is null");
                return;
            }

            if (__instance.skinButton.transform.childCount == 0)
            {
                Log.LogWarning("[AlmanacPlantBank_Patch] Skin button has no children");
                return;
            }

            GameObject skinTextObj = __instance.skinButton.transform.GetChild(0).gameObject;
            if (skinTextObj == null)
            {
                Log.LogWarning("[AlmanacPlantBank_Patch] Skin text object is null");
                return;
            }

            GameObject skinShadowTextObj = UnityEngine.Object.Instantiate(skinTextObj, parent: __instance.skinButton.transform);
            if (skinShadowTextObj == null)
            {
                Log.LogWarning("[AlmanacPlantBank_Patch] Failed to instantiate skin shadow text");
                return;
            }

            TextMeshPro skinShadowText = skinShadowTextObj.GetComponent<TextMeshPro>();
            if (skinShadowText != null)
            {
                skinShadowText.text = StringStore.TranslateText("æ¢è‚¤_S");
                skinShadowText.sortingOrder -= 2;
            }

            skinShadowTextObj.transform.Translate(new Vector3(0.015f, -0.015f, 0));
            skinTextObj.transform.Translate(new Vector3(-0.022f, 0));
            skinShadowTextObj.transform.Translate(new Vector3(-0.022f, 0));
            __instance.skinButton.transform.localScale /= 1.75f;
            __instance.skinButton.transform.Translate(new Vector3(-0.075f, -0.15f, 0));

            if (__instance.skinButton.transform.childCount > 2)
            {
                __instance.skinButton.transform.GetChild(1).Translate(new Vector3(0.35f, 0));
                __instance.skinButton.transform.GetChild(2).Translate(new Vector3(-0.35f, 0));
            }
        }
    }
}
