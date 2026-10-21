using PvZ_Fusion_Translator.Patches.BaseTextObjects;
using System.Text.RegularExpressions;

namespace PvZ_Fusion_Translator.AssetStore;

public static class StringStore
{
    // ReSharper disable once CollectionNeverQueried.Global
    internal static readonly Dictionary<string, string> StringsDict = [];

    public static readonly Dictionary<string, string> TranslationStringRegex = new();

    public static readonly Dictionary<string, string> TranslationString = new();

    public static readonly Dictionary<string, string> CustomLevelStringRegex = new();

    public static readonly Dictionary<string, string> CustomLevelString = new();

    public static readonly Dictionary<string, string> IZLevelTipDictionary = new();

    public static readonly Dictionary<string, string> IZTipCollectionString = new();

    public static readonly Dictionary<string, string> FSLevelTipDictionary = new();

    public static readonly Dictionary<string, string> FSTipCollectionString = new();

    public static readonly Dictionary<string, Dictionary<string, string>> PatchesStore = new()
    {
        {
            "Difficulty", new()
            {
                { "English", "Difficulty:" },
                { "French", "Difficulté:" },
                { "Italian", "Difficoltà:" },
                { "German", "Schwierigkeit:" },
                { "Spanish", "Dificultad:" },
                { "Portuguese", "Dificuldade:" },
                { "Filipino", "Ang Hirap:" },
                { "Vietnamese", "Độ Khó:" },
                { "Indonesian", "Kesulitan:" },
                { "Russian", "Сложность:" },
                { "Japanese", "困難:" },
                { "Korean", "난이도:" },
                { "Javanese", "Kesulitan:" },
                { "Polish", "Trudność:" },
                { "Hungarian", "Nehézség:" },
                { "Arabic", "صعوبة:" },
                // { "Ukrainian" , "Складність:" },
                // { "Slovak" , "Náročnosť:" },
            }
        },
        {
            "Zombies", new()
            {
                { "English", "Zombies:" },
                { "French", "Les Zombies:" },
                { "Italian", "Zombi:" },
                { "German", "Zombies:" },
                { "Spanish", "Zombis:" },
                { "Portuguese", "Zumbis:" },
                { "Filipino", "Mga Zombie:" },
                { "Vietnamese", "Thây Ma:" },
                { "Indonesian", "Zombi:" },
                { "Russian", "Зомби:" },
                { "Japanese", "ゾンビ:" },
                { "Korean", "좀비:" },
                { "Javanese", "Mayit:" },
                { "Polish", "Zombi:" },
                { "Hungarian", "Zombik:" },
                { "Arabic", "الزومبي:" },
                // { "Ukrainian" , "Зомбі:" },
                // { "Slovak" , "Zombíci:"}
            }
        },
    };

    internal static void Init() => FileLoader.LoadStrings();

    internal static void Reload()
    {
        TranslationString.Clear();
        TranslationStringRegex.Clear();
        CustomLevelString.Clear();
        CustomLevelStringRegex.Clear();
        IZLevelTipDictionary.Clear();
        IZTipCollectionString.Clear();
        FSLevelTipDictionary.Clear();
        FSTipCollectionString.Clear();
        InGameText_Patch.CurrentText = "";
        Utils.RegisterPlantIndices();
        FileLoader.LoadStrings();
    }

    public static TextMeshPro TranslateText(TextMeshPro originalTMP, bool isLog = false)
    {
        var fontAsset = FontStore.LoadTMPFont(ModFeatures.IsMultiLanguage ? Utils.Language.ToString() : null);
        var translatedText = TranslateText(originalTMP.text);
        originalTMP.font = fontAsset;
        originalTMP.text = translatedText;
        return originalTMP;
    }

    public static TextMeshProUGUI TranslateText(TextMeshProUGUI originalTMP, bool isLog = false)
    {
        var fontAsset = ModFeatures.IsMultiLanguage
            ? FontStore.LoadTMPFont(Utils.Language.ToString())
            : FontStore.LoadTMPFont();

        var translatedText = TranslateText(originalTMP.text);
        originalTMP.font = fontAsset;
        originalTMP.text = translatedText;
        return originalTMP;
    }

    public static string TranslateText(string originalText, bool isLog = false)
    {
        var text = DoTranslateText(originalText);

        if (!ModFeatures.IsDebug)
            return text;

        Regex regex = new("\\p{IsCJKUnifiedIdeographs}+");
        var match = regex.Match(text);

        if (match.Success)
            FileLoader.DumpUntranslatedStrings(text);

        return text;
    }

    public static string TranslateText(string originalText, string pattern, bool isLog = false)
    {
        if (TestRegex(originalText, pattern))
        {
            if (TranslationStringRegex.TryGetValue(pattern, out var value))
            {
                // Extract dynamic parts from the original text
                var regex = new Regex(pattern);
                var match = regex.Match(originalText);
                var groupCount = match.Groups.Count;

                if (isLog)
                    Log.LogDebug("Text found in translationStringRegex {0}: {1}", match, groupCount);

                // List to hold formatted dynamic parts
                List<string> dynamicParts = [];

                // Loop through each group and determine its translation
                for (var i = 1; i < groupCount; i++)
                {
                    var groupValue = match.Groups[i].Value;
                    var translatedValue = DoTranslateString(groupValue);
                    dynamicParts.Add(translatedValue);
                }

                // Format the output string with dynamic parts
                return string.Format(value, [..dynamicParts]);
            }

            if (!CustomLevelStringRegex.TryGetValue(pattern, out var value1))
                return originalText;

            {
                // Extract dynamic parts from the original text
                var regex = new Regex(pattern);
                var match = regex.Match(originalText);
                var groupCount = match.Groups.Count;

                if (isLog)
                    Log.LogDebug("Text found in customLevelStringRegex {0}: {1}", match, groupCount);

                // List to hold formatted dynamic parts
                List<string> dynamicParts = [];

                // Loop through each group and determine its translation
                for (var i = 1; i < groupCount; i++)
                {
                    var groupValue = match.Groups[i].Value;
                    var translatedValue = CustomLevelString.GetValueOrDefault(groupValue, groupValue);
                    dynamicParts.Add(translatedValue);
                }

                // Format the output string with dynamic parts
                return string.Format(value1, [..dynamicParts]);
            }
        }

        if (isLog)
            Log.LogDebug($"Text '{originalText}' not translated");

        FileLoader.DumpUntranslatedStrings(originalText);
        return originalText;
    }

    public static string DoTranslateString(string originalText, bool isLog = false)
    {
        if (string.IsNullOrEmpty(originalText))
        {
            if (isLog)
                Log.LogError("Text Null or Empty");

            return string.Empty;
        }

        if (TranslationString.TryGetValue(originalText, out var s))
        {
            if (isLog)
                Log.LogDebug($"Text '{originalText} found in translationString");

            return s;
        }

        if (IZTipCollectionString.TryGetValue(originalText, out var translateString))
        {
            if (isLog)
                Log.LogDebug($"Text '{originalText}' found in izTipCollectionString");

            return translateString;
        }

        if (FSTipCollectionString.TryGetValue(originalText, out var doTranslateString))
        {
            if (isLog)
                Log.LogDebug($"Text '{originalText}' found in fsTipCollectionString");

            return doTranslateString;
        }

        if (CustomLevelString.TryGetValue(originalText, out var s1))
        {
            if (isLog)
                Log.LogDebug($"Text '{originalText}' found in customLevelString");

            return s1;
        }

        if (!Utils.PlantIndiceString.TryGetValue(originalText, out var translateString1))
            return originalText;

        if (isLog)
            Log.LogDebug($"Text '{originalText}' found in plantIndiceString");

        return translateString1;
    }

    public static string DoTranslateText(string originalText, bool isLog = false)
    {
        if (string.IsNullOrEmpty(originalText))
        {
            if (isLog)
                Log.LogError("Text Null or Empty");

            return string.Empty;
        }

        if (!Utils.CheckForUntranslatedText(originalText) && !originalText.Contains('_'))
            return originalText;

        if (TranslationString.TryGetValue(originalText, out var text))
        {
            if (isLog)
                Log.LogDebug($"Text '{originalText} found in translationString");

            return text;
        }

        if (IZTipCollectionString.TryGetValue(originalText, out var translateText))
        {
            if (isLog)
                Log.LogDebug($"Text '{originalText}' found in izTipCollectionString");

            return translateText;
        }

        if (FSTipCollectionString.TryGetValue(originalText, out var doTranslateText))
        {
            if (isLog)
                Log.LogDebug($"Text '{originalText}' found in fsTipCollectionString");

            return doTranslateText;
        }

        if (CustomLevelString.TryGetValue(originalText, out var text1))
        {
            if (isLog)
                Log.LogDebug($"Text '{originalText}' found in customLevelString");

            return text1;
        }

        if (Utils.PlantIndiceString.TryGetValue(originalText, out var translateText1))
        {
            if (isLog)
                Log.LogDebug($"Text '{originalText}' found in plantIndiceString");

            return translateText1;
        }

        // Regex-based dynamic translation
        foreach (var entry in TranslationStringRegex)
            if (TestRegex(originalText, entry.Key))
            {
                // Extract dynamic parts from the original text
                var regex = new Regex(entry.Key);
                var match = regex.Match(originalText);
                var groupCount = match.Groups.Count;

                if (isLog)
                    Log.LogDebug("Text found in translationStringRegex {0}: {1}", match, groupCount);

                // List to hold formatted dynamic parts
                List<string> dynamicParts = [];

                // Loop through each group and determine its translation
                for (var i = 1; i < groupCount; i++)
                {
                    var groupValue = match.Groups[i].Value;
                    var translatedValue = DoTranslateString(groupValue);
                    dynamicParts.Add(translatedValue);
                }

                // Format the output string with dynamic parts
                return string.Format(entry.Value, [..dynamicParts]);
            }

        foreach (var entry in CustomLevelStringRegex)
            if (TestRegex(originalText, entry.Key))
            {
                // Extract dynamic parts from the original text
                var regex = new Regex(entry.Key);
                var match = regex.Match(originalText);
                var groupCount = match.Groups.Count;

                if (isLog)
                    Log.LogDebug("Text found in customLevelRegex {0}: {1}", match, groupCount);

                // List to hold formatted dynamic parts
                List<string> dynamicParts = [];

                // Loop through each group and determine its translation
                for (var i = 1; i < groupCount; i++)
                {
                    var groupValue = match.Groups[i].Value;
                    var translatedValue = CustomLevelString.GetValueOrDefault(groupValue, groupValue);
                    dynamicParts.Add(translatedValue);
                }

                // Format the output string with dynamic parts
                return string.Format(entry.Value, [..dynamicParts]);
            }

        if (isLog)
            Log.LogDebug($"Text '{originalText}' not translated");

        if (Utils.CheckForUntranslatedText(originalText))
            FileLoader.DumpUntranslatedStrings(originalText);

        return originalText;
    }

    public static string TranslateColorText(string originalText, bool isLog = false)
    {
        var text = TranslateColorSegments(originalText);

        if (!ModFeatures.IsDebug)
            return text;

        Regex regex = new("\\p{IsCJKUnifiedIdeographs}+");
        var match = regex.Match(text);

        if (match.Success)
            // Log.LogDebug("Untranslated String: " + match.Value);
            FileLoader.DumpUntranslatedStrings(text);

        return text;
    }

    public static string TranslateColorSegments(string input)
    {
        var result = "";
        const string Pattern = @"<color=[^>]+>[\s\S]*?(?:<\/color>|$)|(?:<(?!color=)|[^<])+";
        const string SmallPattern = "(<color=[^>]+>)(.*?)(</color>)";
        var matches = Regex.Matches(input, Pattern);

        for (var i = 0; i < matches.Count; i++)
        {
            var match = matches[i];

            if (Regex.Match(match.Value, SmallPattern, RegexOptions.Singleline).Success)
                result += TranslateColorSegment(match.Value);
            else
                result += DoTranslateText(match.Value);
        }

        return result;
    }

    public static string TranslateColorSegment(string input)
    {
        const string Pattern = "(<color=[^>]+>)(.*?)(</color>)";
        var match = Regex.Match(input, Pattern, RegexOptions.Singleline);
        var translatedText = DoTranslateText(match.Groups[2].Value);

        if (Utils.CheckForUntranslatedText(translatedText))
            FileLoader.DumpUntranslatedStrings(translatedText);

        return match.Groups[1].Value + translatedText + match.Groups[3].Value;
    }

    public static bool TestRegex(string originalText, string pattern, bool singleLine = false)
    {
        var options = singleLine ? RegexOptions.None : RegexOptions.Singleline;
        return Regex.IsMatch(originalText, pattern, options);
    }

    private static TextAlignmentOptions TextAnchorToTMPAlignment(TextAnchor anchor) =>
        anchor switch
        {
            TextAnchor.UpperLeft => TextAlignmentOptions.TopLeft,
            TextAnchor.UpperCenter => TextAlignmentOptions.Top,
            TextAnchor.UpperRight => TextAlignmentOptions.TopRight,
            TextAnchor.MiddleLeft => TextAlignmentOptions.MidlineLeft,
            TextAnchor.MiddleCenter => TextAlignmentOptions.Center,
            TextAnchor.MiddleRight => TextAlignmentOptions.MidlineRight,
            TextAnchor.LowerLeft => TextAlignmentOptions.BottomLeft,
            TextAnchor.LowerCenter => TextAlignmentOptions.Bottom,
            TextAnchor.LowerRight => TextAlignmentOptions.BottomRight,
            _ => TextAlignmentOptions.Center,
        };

    public static TextMeshProUGUI ConvertToTextMeshPro(
        UnityEngine.UI.Text oldText,
        TMP_FontAsset fontAsset,
        bool isLog = false
    )
    {
        if (oldText == null)
        {
            Log.LogError("UnityEngine.UI.Text component is null.");
            return null;
        }

        if (fontAsset == null)
        {
            Log.LogError("TMP_FontAsset is null. Conversion cannot proceed.");
            return null;
        }

        // Log.LogInfo($"Converting UnityEngine.UI.Text: {oldText.name}");

        var textObject = oldText.gameObject;

        // Preserve text content and settings
        var originalText = oldText.text;
        originalText = TranslateText(originalText, isLog);
        var alignment = oldText.alignment;
        var color = oldText.color;

        // Remove old Text component
        UnityEngine.Object.DestroyImmediate(oldText);

        // Add TextMeshProUGUI component
        var newTMP = textObject.AddComponent<TextMeshProUGUI>();

        if (newTMP == null)
        {
            Log.LogError($"Failed to add TextMeshProUGUI to object: {textObject.name}");
            return null;
        }

        // Configure TextMeshProUGUI
        newTMP.text = originalText;
        newTMP.color = color;
        newTMP.alignment = TextAnchorToTMPAlignment(alignment);
        newTMP.font = fontAsset;

        // Log.LogInfo($"Successfully converted {textObject.name} to TextMeshProUGUI.");

        return newTMP;
    }

    public static void TranslateTextTransform(
        Transform baseTransform,
        bool isAutoTextContainer = false,
        bool isLog = false
    )
    {
        if (!baseTransform)
            return;

        var currentLanguage = ModFeatures.IsMultiLanguage ? Utils.Language.ToString() : null;
        var fontAsset = FontStore.LoadTMPFont(currentLanguage);

        if (fontAsset == null)
        {
            Log.LogError(
                ModFeatures.IsMultiLanguage
                    ? $"Font for language '{currentLanguage}' not found. Translation aborted."
                    : "Font not found. Translation aborted."
            );

            return;
        }

        // Local function for processing transforms
        void ProcessTextTransform(Transform textTransform)
        {
            if (!textTransform)
                return;

            // Handle TextMeshPro components
            var textTMP = textTransform.GetComponent<TextMeshPro>();

            if (textTMP)
            {
                textTMP.text = TranslateText(textTMP.text, isLog);
                textTMP.autoSizeTextContainer = isAutoTextContainer;
                textTMP.font = fontAsset;
            }

            var textTmpugui = textTransform.GetComponent<TextMeshProUGUI>();

            if (textTmpugui)
            {
                textTmpugui.text = TranslateText(textTmpugui.text, isLog);
                textTmpugui.enableAutoSizing = isAutoTextContainer;
                textTmpugui.font = fontAsset;
            }

            // Handle UnityEngine.UI.Text components
            var textUI = textTransform.GetComponent<UnityEngine.UI.Text>();

            if (textUI)
                ConvertToTextMeshPro(textUI, fontAsset, isLog);
        }

        // Process specific text paths
        ProcessTextTransform(baseTransform.Find("text"));
        ProcessTextTransform(baseTransform.Find("text1"));
        // ProcessTextTransform(baseTransform.Find("text2"));

        var shadowTransform = baseTransform.Find("text/shadow");

        if (shadowTransform)
            ProcessTextTransform(shadowTransform);

        shadowTransform = baseTransform.Find("text1/shadow");

        if (shadowTransform)
            ProcessTextTransform(shadowTransform);

        if (!ModFeatures.IsTesting)
            return;

        var childTransform = baseTransform.GetChild(0);

        if (childTransform)
            ProcessTextTransform(childTransform);
    }

    public static void TranslateTextUI(TextMeshPro textTMP, bool? isAutoTextContainer = null, bool isLog = false)
    {
        var currentLanguage = Utils.Language.ToString();

        if (!textTMP)
            return;

        textTMP.text = TranslateText(textTMP.text, isLog);

        if (isAutoTextContainer != null)
            textTMP.autoSizeTextContainer = isAutoTextContainer.Value;

        textTMP.font = FontStore.LoadTMPFont(currentLanguage);
    }

    public static void TranslateTextUI(TextMeshProUGUI textTMP, bool? isAutoTextContainer = null, bool isLog = false)
    {
        var currentLanguage = Utils.Language.ToString();

        if (!textTMP)
            return;

        var origText = textTMP.text;

        textTMP.text = TranslateText(origText, isLog) == "" ? origText : TranslateText(origText, isLog);

        if (isAutoTextContainer != null)
            textTMP.autoSizeTextContainer = isAutoTextContainer.Value;

        if (origText != textTMP.text)
            textTMP.font = FontStore.LoadTMPFont(currentLanguage);
    }

    public static void TranslateTextUI(TMP_InputField textInput)
    {
        var currentLanguage = Utils.Language.ToString();

        if (!textInput)
            return;

        var oriText = textInput.m_Text;
        textInput.m_Text = TranslateText(oriText);
        textInput.m_OriginalText = TranslateText(oriText);
        textInput.fontAsset = FontStore.LoadTMPFont(currentLanguage);
    }

    public static void LogAll()
    {
        Log.LogInfo("Logging all StringStore entries.");
        Log.LogInfo("Regex Entries: {0}", TranslationStringRegex.Count);
        Log.LogInfo("String Entries: {0}", TranslationString.Count);
    }
}
