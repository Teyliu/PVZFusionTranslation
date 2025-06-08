using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using MelonLoader;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(UIZombieNum))]
    public static class UIZombieNum_Patch
    {
        [HarmonyPatch("Update")]
        [HarmonyPrefix]
        private static void Update_Prefix(UIZombieNum __instance)
        {
            int zombieCount = __instance.board.enermyCount;
            float Score = __instance.board.thePoints;
                    
            string zombieText = StringStore.TranslateText($"场上敌人数量：{zombieCount}");
            string scoreText = StringStore.TranslateText($"当前分数：{Score}");
                    
            string translatedText = $"{zombieText}\n{scoreText}";
            __instance.t.text = translatedText;
            __instance.t.font = FontStore.LoadTMPFont(Utils.Language.ToString());
        }
    }
}
