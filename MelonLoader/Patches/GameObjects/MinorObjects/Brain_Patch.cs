using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects
{
    [HarmonyPatch(typeof(Brain))]
    public static class Brain_Patch
    {
        [HarmonyPostfix]
        [HarmonyPatch(nameof(Brain.Awake))]
        private static void Awake(Brain __instance)
        {
            // reposition original points
            Transform pointsTransform = __instance.points.transform;
            GameObject pointsObject = __instance.points.gameObject;
            pointsTransform.position = new Vector3(-6.5f, pointsTransform.position.y, pointsTransform.position.z);

            // instantiate and move new shadow
            GameObject pointsShadowObject = UnityEngine.Object.Instantiate(pointsObject, parent: pointsTransform);
            pointsShadowObject.SetActive(true);
            Transform pointsShadowTransform = pointsShadowObject.transform;
            pointsShadowTransform.position = new Vector3(-6.485f, pointsTransform.position.y - 0.015f, pointsTransform.position.z);

            // set points text
            TextMeshPro pointsShadowText = pointsShadowObject.GetComponent<TextMeshPro>();
            pointsShadowText.text = __instance.points.text;
            pointsShadowText.sortingOrder -= 2;
            pointsShadowText.color = Color.black;
        }

        [HarmonyPostfix]
        [HarmonyPatch(nameof(Brain.Update))]
        private static void Update(Brain __instance)
        {
            if(__instance.transform.Find("Points").GetChild(0) != null)
            {
                TextMeshPro shadowText = __instance.transform.Find("Points").GetChild(0).GetComponent<TextMeshPro>();
                shadowText.text = __instance.points.text;
            }
        }

        [HarmonyPostfix]
        [HarmonyPatch(nameof(Brain.WinAction))]
        private static void WinAction(Brain __instance)
        {
            if (__instance.transform.Find("Points").GetChild(0) != null)
            {
                TextMeshPro shadowText = __instance.transform.Find("Points").GetChild(0).GetComponent<TextMeshPro>();
                shadowText.text = __instance.points.text;
            }
        }
    }
}