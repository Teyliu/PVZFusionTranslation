#if FIX
using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using MelonLoader;
using PvZ_Fusion_Translator.AssetStore;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    [HarmonyPatch(typeof(UIZombieNum))]
    public static class UIZombieNum_Patch
    {
        [HarmonyPatch(nameof(UIZombieNum.Update))]
        [HarmonyPostfix]
        private static void Update(UIZombieNum __instance)
        {
            /// Tạm thời không biết vì dịch được nhưng chưa biết regex là gì
            //Board board = __instance.board;
            //TextMeshProUGUI textMeshProUGUI = __instance.t;
            //// Lấy số lượng kẻ địch
            //int enermyCount = board.enermyCount;

            //// Dịch chuỗi hiển thị số lượng kẻ địch
            //string originalText = string.Format("场上敌人数量：{0}", enermyCount);
            //string translatedText = StringStore.TranslateText(originalText);
            //textMeshProUGUI.text = translatedText;

            //// Lấy điểm số hiện tại và dịch chuỗi
            //string currentScoreText = textMeshProUGUI.text;
            //string originalScoreText = string.Format("\n当前分数：{0}", currentScoreText);
            //string translatedScoreText = StringStore.TranslateText(originalScoreText);

            //// Gán chuỗi đã dịch
            //textMeshProUGUI.text = currentScoreText + translatedScoreText;


            /// Dịch được nhưng chỉ hiện số Zombie
            //if (__instance.t != null)
            //{
            //    __instance.t.text = StringStore.TranslateText(__instance.t.text);

            //    // Áp dụng font và styling cho ngôn ngữ đích
            //    StringStore.TranslateTextUI(__instance.t);
            //}

            //// Patch cho tất cả TextMeshProUGUI components con
            //foreach (TextMeshProUGUI text in __instance.GetComponentsInChildren<TextMeshProUGUI>())
            //{
            //    string originalText = text.text;
            //    MelonLogger.Msg($"Original text: {originalText}");
            //    string translatedText = StringStore.TranslateText(originalText);

            //    if (originalText != translatedText)
            //    {
            //        text.text = translatedText;
            //        MelonLogger.Msg($"Translated text: {originalText} -> {translatedText}");
            //        StringStore.TranslateTextUI(text);
            //    }
            //}


        }
    }
}
#endif

using HarmonyLib;
using Il2Cpp;
using Il2CppTMPro;
using MelonLoader;
using PvZ_Fusion_Translator.AssetStore;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator.Patches.GameObjects
{
    //[HarmonyPatch(typeof(UIZombieNum))]
    //public static class UIZombieNum_Patch
    //{
    //    //private static readonly Regex ZombieScoreRegex = new Regex(@"场上敌人数量：(\d+)\n当前分数：(\d+)$");
    //    private static readonly Regex ZombieScoreRegex = new Regex(@"场上敌人数量：(\d+)\s*\n\s*当前分数：(\d+)\s*");

    //    private static string lastProcessedText = "";

    //    [HarmonyPatch(nameof(UIZombieNum.Update))]
    //    [HarmonyPostfix]
    //    private static void Update(UIZombieNum __instance)
    //    {
    //        if (__instance.t != null)
    //        {
    //            string currentText = __instance.t.text;
    //            TMP_FontAsset fontAsset = FontStore.LoadTMPFont(Utils.Language.ToString());
    //            // Tránh process lại text đã được translate
    //            if (currentText != lastProcessedText && ZombieScoreRegex.IsMatch(currentText))
    //            {
    //                MelonLogger.Msg($"[TRANSLATION] Processing text: '{currentText}'");

    //                var match = ZombieScoreRegex.Match(currentText);

    //                if (match.Success)
    //                {
    //                    string zombieCount = match.Groups[1].Value;
    //                    string scoreCount = match.Groups[2].Value;

    //                    string translatedText = $"Số Zombie: {zombieCount}\nSố Điểm: {scoreCount}";
    //                    //string translatedText = StringStore.TranslateText($"场上敌人数量：{zombieCount}\n当前分数：{scoreCount}");
    //                    __instance.t.text = translatedText;
    //                    __instance.t.font = fontAsset; // Đặt font cho TextMeshProUGUI
    //                    MelonLogger.Msg($"[TRANSLATION] Success: '{translatedText}'");

    //                    // Áp dụng font styling
    //                    //StringStore.TranslateTextUI(__instance.t);

    //                    lastProcessedText = translatedText;
    //                    __instance.t.font = fontAsset; // Đặt font cho TextMeshProUGUI
    //                }
    //                else
    //                {
    //                    MelonLogger.Warning($"[TRANSLATION] No match for text: '{currentText}'");

    //                    // Test với các pattern khác nếu cần
    //                    //TestAlternativePatterns(currentText);
    //                }
    //            }
    //        }
    //    }

    //    //private static void TestAlternativePatterns(string text)
    //    //{
    //    //    var alternativePatterns = new[]
    //    //    {
    //    //        @"^场上敌人数量：(\d+)$",  // Chỉ có zombie count
    //    //        @"^当前分数：(\d+)$",      // Chỉ có score
    //    //        @"场上敌人数量：(\d+)",    // Không anchor
    //    //        @"当前分数：(\d+)"         // Không anchor
    //    //    };

    //    //    foreach (string pattern in alternativePatterns)
    //    //    {
    //    //        try
    //    //        {
    //    //            var regex = new Regex(pattern);
    //    //            var match = regex.Match(text);

    //    //            if (match.Success)
    //    //            {
    //    //                MelonLogger.Msg($"[ALT PATTERN] Match found with: '{pattern}'");
    //    //                for (int i = 1; i < match.Groups.Count; i++)
    //    //                {
    //    //                    MelonLogger.Msg($"  Group {i}: '{match.Groups[i].Value}'");
    //    //                }
    //    //            }
    //    //        }
    //    //        catch (Exception ex)
    //    //        {
    //    //            MelonLogger.Error($"[ALT PATTERN] Error with '{pattern}': {ex.Message}");
    //    //        }
    //    //    }
    //    //}
    //}

    [HarmonyPatch(typeof(UIZombieNum))]
    public static class UIZombieNum_Patch
    {
        [HarmonyPatch("Update")]
        [HarmonyPrefix]
        private static bool Update_Prefix(UIZombieNum __instance)
        {
            try
            {
                if (__instance.t != null && __instance.board != null)
                {

                    int zombieCount = __instance.board.enermyCount;
                    float Score = __instance.board.thePoints;
                    
                    // Translate each part separately, then combine
                    string zombieText = StringStore.TranslateText($"场上敌人数量：{zombieCount}");
                    string scoreText = StringStore.TranslateText($"当前分数：{Score}");
                    
                    // Combine the translated parts
                    string translatedText = $"{zombieText}\n{scoreText}";

                    __instance.t.text = translatedText;
                    __instance.t.font = FontStore.LoadTMPFont(Utils.Language.ToString());

                    return false; // Skip original method
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"UIZombieNum patch error: {ex}");
            }

            return true; // Run original if error
        }
    }
}
