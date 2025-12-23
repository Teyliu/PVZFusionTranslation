using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using static PvZ_Fusion_Translator.Patches.Managers.TravelMgr_Patch;
using UnityEngine;
using MelonLoader;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(TravelBuffMenu))]
    public static class TravelBuffMenu_Patch
    {
        [HarmonyPatch(nameof(TravelBuffMenu.RefeshOptions))]
        [HarmonyPostfix]
        private static void RefeshOptions(TravelBuffMenu __instance)
        {
            foreach (TravelBuffOptionButton button in __instance.options)
            {
                List<string> buffSet = translatedTravelBuffs[buffLinks[button.buffType]];
                string buffText = (button.buffIndex < buffSet.Count && button.show != null) ? buffSet[button.buffIndex] : StringStore.TranslateText(button.introduce.text);
                button.introduce.text = buffText;
            }
        }
    }
}