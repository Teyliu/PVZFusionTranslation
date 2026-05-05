using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace PvZ_Fusion_Translator.Patches.Managers
{
    [HarmonyPatch(typeof(Screen))]
    public static class Screen_Patch
    {
        [HarmonyPatch(nameof(Screen.SetResolution), argumentTypes: [typeof(int), typeof(int), typeof(bool)])]
        [HarmonyPrefix]
        private static bool SetResolution(Screen __instance)
        {
            if(EventSystem.current.currentSelectedGameObject != null)
            {
                if (EventSystem.current.currentSelectedGameObject.TryGetComponent<TMP_InputField>(out TMP_InputField field))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
