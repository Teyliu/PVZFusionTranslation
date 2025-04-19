using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(MainMenu))]
    public class MainMenu_Patch
    {
        [HarmonyPostfix]
        [HarmonyPatch(nameof(MainMenu.FixedUpdate))]
        private static void FixedUpdate(MainMenu __instance)
        {
            NoticeMenu noticeMenu = NoticeMenu.Instance;
            WarningStore.WarningReload(Utils.Language, noticeMenu);
        }
    }
}
