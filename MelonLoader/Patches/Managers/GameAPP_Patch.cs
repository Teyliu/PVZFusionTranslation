using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace PvZ_Fusion_Translator.Patches.Managers
{
    [HarmonyPatch(typeof(GameAPP))]
    public static class GameAPP_Patch
    {
        [HarmonyPatch(nameof(GameAPP.Update))]
        [HarmonyPrefix]
        private static bool Update(GameAPP __instance)
        {
            if(EventSystem.current.currentSelectedGameObject != null)
            {
                if (EventSystem.current.currentSelectedGameObject.TryGetComponent<TMP_InputField>(out TMP_InputField field))
                {
                    __instance.MusicUpdate();
                    return false;
                }
            }
            return true;
        }
    }
}
