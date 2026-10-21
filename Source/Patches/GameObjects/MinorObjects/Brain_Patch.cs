using HarmonyLib;

namespace PvZ_Fusion_Translator.Patches.GameObjects.MinorObjects;

[HarmonyPatch(typeof(Brain))]
public static class Brain_Patch
{
    [HarmonyPostfix, HarmonyPatch(nameof(Brain.Awake))]
    private static void Awake(Brain __instance)
    {
        // reposition original points
        var pointsTransform = __instance.points.transform;
        var pointsObject = __instance.points.gameObject;
        pointsTransform.position = new(-6.5f, pointsTransform.position.y, pointsTransform.position.z);

        // instantiate and move new shadow
        var pointsShadowObject = UnityEngine.Object.Instantiate(pointsObject, pointsTransform);
        pointsShadowObject.SetActive(true);
        var pointsShadowTransform = pointsShadowObject.transform;
        pointsShadowTransform.position = new(-6.485f, pointsTransform.position.y - 0.015f, pointsTransform.position.z);

        // set points text
        var pointsShadowText = pointsShadowObject.GetComponent<TextMeshPro>();
        pointsShadowText.text = __instance.points.text;
        pointsShadowText.sortingOrder -= 2;
        pointsShadowText.color = Color.black;
    }

    [HarmonyPostfix, HarmonyPatch(nameof(Brain.Update))]
    private static void Update(Brain __instance)
    {
        if (__instance.transform.Find("Points").GetChild(0) == null)
            return;

        var shadowText = __instance.transform.Find("Points").GetChild(0).GetComponent<TextMeshPro>();
        shadowText.text = __instance.points.text;
    }

    [HarmonyPostfix, HarmonyPatch(nameof(Brain.WinAction))]
    private static void WinAction(Brain __instance)
    {
        if (__instance.transform.Find("Points").GetChild(0) == null)
            return;

        var shadowText = __instance.transform.Find("Points").GetChild(0).GetComponent<TextMeshPro>();
        shadowText.text = __instance.points.text;
    }
}
