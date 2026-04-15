using HarmonyLib;
using PvZ_Fusion_Translator__BepInEx_.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator__BepInEx_.Patches.GameObjects
{
    [HarmonyPatch(typeof(SpriteRenderer))]
    public static class SpriteRenderer_Patch
    {
        [HarmonyPatch("InvokeSpriteChanged")]
        [HarmonyPostfix]
        private static void InvokeSpriteChanged(SpriteRenderer __instance)
        {
            if (__instance.sprite == null)
                return;

            bool hasBorder = TextureStore.spriteDict.ContainsKey(__instance.sprite.name) && __instance.drawMode != SpriteDrawMode.Sliced;
            if (hasBorder)
            {
                __instance.drawMode = SpriteDrawMode.Sliced;
            }
        }
    }
}