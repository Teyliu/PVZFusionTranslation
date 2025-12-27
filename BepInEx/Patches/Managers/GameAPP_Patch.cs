using HarmonyLib;
using TMPro;
using UnityEngine.EventSystems;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.Managers
{
	[HarmonyPatch(typeof(GameAPP))]
	public class GameAPP_Patch
    {
		[HarmonyPatch(nameof(GameAPP.Update))]
		[HarmonyPrefix]
		private static bool Update(GameAPP __instance)
		{
            Core.Instance.OnUpdate();

            if (EventSystem.current?.currentSelectedGameObject != null)
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