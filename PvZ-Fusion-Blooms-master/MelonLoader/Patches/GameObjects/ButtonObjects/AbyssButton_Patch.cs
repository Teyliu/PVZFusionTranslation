using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects.ButtonObjects
{
    [HarmonyPatch(typeof(AbyssButton))]
    public static class AbyssButton_Patch
    {
        [HarmonyPatch(nameof(AbyssButton.Start))]
        [HarmonyPostfix]
        private static void Start(AbyssButton __instance)
        {
            StringStore.TranslateTextTransform(__instance.transform, true);
            Transform parentTransform = __instance.transform.parent.transform;
			if (__instance.name == "Goback")
			{
				Transform backgroundTransform = parentTransform.Find("Background");
				backgroundTransform.Find("Name").GetComponent<TMP_Text>().autoSizeTextContainer = true;
				backgroundTransform.Find("Shadow").GetComponent<TMP_Text>().autoSizeTextContainer = true;
			}
        }
    }
}
