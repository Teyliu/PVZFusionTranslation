using HarmonyLib;
using TMPro;
using UnityEngine.EventSystems;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
	[HarmonyPatch(typeof(Screen))]
	public class Screen_Patch
    {
		[HarmonyPatch(nameof(Screen.SetResolution), new Type[] { typeof(int), typeof(int), typeof(bool) })]
		[HarmonyPrefix]
		private static bool SetResolution(Screen __instance)
		{
            if (EventSystem.current?.currentSelectedGameObject != null)
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
