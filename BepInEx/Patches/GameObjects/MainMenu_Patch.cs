using HarmonyLib;

using TMPro;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
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
