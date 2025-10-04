using HarmonyLib;
using TMPro;
using BepInEx.Unity.IL2CPP;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
     [HarmonyPatch(typeof(SpriteRenderer))]
    public static class SpriteRenderer_Patch
    {
        [HarmonyPatch(nameof(SpriteRenderer.InvokeSpriteChanged))]
        [HarmonyPostfix]
        private static void InvokeSpriteChanged(SpriteRenderer __instance)
        {
            if (__instance.sprite != null)
            {
                if (TextureStore.spriteDict.ContainsKey(__instance.sprite.name) && __instance.drawMode != SpriteDrawMode.Sliced)
                {
                    __instance.drawMode = SpriteDrawMode.Sliced;
                }
            }
        }
    }
}