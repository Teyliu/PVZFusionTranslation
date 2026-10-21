using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(SpriteRenderer))]
public static class SpriteRenderer_Patch
{
    [HarmonyPatch(nameof(SpriteRenderer.InvokeSpriteChanged)), HarmonyPostfix]
    private static void InvokeSpriteChanged(SpriteRenderer __instance)
    {
        if (__instance.sprite == null)
            return;

        if (TextureStore.SpriteDict.ContainsKey(__instance.sprite.name) && __instance.drawMode != SpriteDrawMode.Sliced)
            __instance.drawMode = SpriteDrawMode.Sliced;
    }
}
