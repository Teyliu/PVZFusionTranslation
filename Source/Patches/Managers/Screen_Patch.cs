using HarmonyLib;
using UnityEngine.EventSystems;

namespace PvZ_Fusion_Translator.Patches.Managers;

[HarmonyPatch(typeof(Screen))]
public static class Screen_Patch
{
    [HarmonyPatch(nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool)), HarmonyPrefix]
    private static bool SetResolution(Screen __instance) =>
        EventSystem.current.currentSelectedGameObject == null ||
        !EventSystem.current.currentSelectedGameObject.TryGetComponent<TMP_InputField>(out _);
}
