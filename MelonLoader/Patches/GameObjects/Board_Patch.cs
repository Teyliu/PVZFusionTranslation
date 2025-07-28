using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using PvZ_Fusion_Translator.AssetStore;
using UnityEngine;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(Board))]
    public static class Board_Patch
    {
        [HarmonyPatch(nameof(Board.Update))]
        [HarmonyPostfix]
        private static void Update(Board __instance)
        {
            foreach (SpriteRenderer spriteRenderer in __instance.GetComponentsInChildren<SpriteRenderer>())
            {
                if (spriteRenderer.sprite != null)
                {
                    if (TextureStore.spriteDict.ContainsKey(spriteRenderer.sprite.name) && spriteRenderer.drawMode != SpriteDrawMode.Sliced)
                    {
                        spriteRenderer.drawMode = SpriteDrawMode.Sliced;
                    }
                }
            }
        }
    }
}
