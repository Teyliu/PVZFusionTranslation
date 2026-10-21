using HarmonyLib;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects;

[HarmonyPatch(typeof(GardenStoreMenu))]
public static class GardenStoreMenu_Patch
{
    [HarmonyPatch(nameof(GardenStoreMenu.InitGoodsList)), HarmonyPatch(nameof(GardenStoreMenu.GetDatas)),
     HarmonyPatch(nameof(GardenStoreMenu.PurchaseGoods)), HarmonyPatch(nameof(GardenStoreMenu.Update)),
     HarmonyPatch(nameof(GardenStoreMenu.Start)), HarmonyPostfix]
    public static void TranslateGardenStoreMenu(GardenStoreMenu __instance)
    {
        foreach (var slot in __instance.GetComponentsInChildren<GardenShopSlot>())
            TranslateGardenShopSlot(slot);
    }

    [HarmonyPatch(nameof(GardenShopSlot.Start)), HarmonyPostfix]
    public static void TranslateGardenShopSlot(GardenShopSlot __instance)
    {
        foreach (var txt in __instance.GetComponentsInChildren<TextMeshProUGUI>())
        {
            txt.text = StringStore.TranslateText(txt.text);
            txt.font = FontStore.LoadTMPFont(Utils.Language.ToString());
        }
    }
}
