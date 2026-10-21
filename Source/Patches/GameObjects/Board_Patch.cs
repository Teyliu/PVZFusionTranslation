using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(Board))]
public static class Board_Patch
{
    [HarmonyPatch(nameof(Board.Update)), HarmonyPostfix]
    private static void Update(Board __instance)
    {
        foreach (var spriteRenderer in __instance.GetComponentsInChildren<SpriteRenderer>()
           .Where(sr => sr.sprite != null)
           .Where(sr => TextureStore.SpriteDict.ContainsKey(sr.sprite.name) && sr.drawMode != SpriteDrawMode.Sliced))
            spriteRenderer.drawMode = SpriteDrawMode.Sliced;
    }
}
