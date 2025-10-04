using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects
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