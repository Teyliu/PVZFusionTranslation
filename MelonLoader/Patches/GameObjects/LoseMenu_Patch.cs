using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using MelonLoader;
using PvZ_Fusion_Translator.AssetStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(LoseMenu))]
    public static class LoseMenu_Patch
    {
        public static void TranslateLoseMenu(BaseMenu __instance)
        {
            if(__instance.TryGetComponent<LoseMenu>(out LoseMenu loseMenu))
            {
                loseMenu.title.text = StringStore.TranslateText(loseMenu.title.text);
            }
        }
    }
}
