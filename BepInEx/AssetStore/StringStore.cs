using TMPro;
using System.Text.RegularExpressions;
using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System;

namespace PvZ_Fusion_Translator__BepInEx_.AssetStore
{
	public static class StringStore
	{
		internal static Dictionary<string, string> stringsDict = [];

		public static Dictionary<string, string> translationStringRegex = new();

		public static Dictionary<string, string> translationString = new();

		private static Dictionary<string, Regex> compiledRegexCache = new();

		private static Dictionary<string, string> translationResultCache = new Dictionary<string, string>();
		private const int MAX_CACHE_SIZE = 5000;

		public static Dictionary<string, Dictionary<string, string>> patchesStore = new()
		{
			{ "Difficulty", new Dictionary<string, string>
				{
					{ "English" , "Difficulty:" },
					{ "French" , "Difficulté:" },
					{ "Italian" , "Difficoltà:" },
					{ "German" , "Schwierigkeit:" },
					{ "Spanish" , "Dificultad:" },
					{ "Portuguese" , "Dificuldade:" },
					{ "Filipino" , "Ang Hirap:" },
					{ "Vietnamese" , "Độ Khó:" },
					{ "Indonesian" , "Kesulitan:" },
					{ "Russian" , "Сложность:" },
					{ "Japanese" , "困難:" },
					{ "Korean", "난이도:" },
					{ "Javanese" , "Kesulitan:" },
					{ "Polish",  "Trudność:"},
					{ "Hungarian",  "Nehézség:"},
					{ "Arabic",  "صعوبة:"},
					// { "Ukrainian" , "Складність:" },
					// { "Slovak" , "Náročnosť:" },
				}
			},
			{ "Zombies", new Dictionary<string, string>
				{
					{ "English" , "Zombies:" },
					{ "French" , "Les Zombies:" },
					{ "Italian" , "Zombi:" },
					{ "German" , "Zombies:" },
					{ "Spanish" , "Zombis:" },
					{ "Portuguese" , "Zumbis:" },
					{ "Filipino" , "Mga Zombie:" },
					{ "Vietnamese" , "Thây Ma:" },
					{ "Indonesian" , "Zombi:" },
					{ "Russian" , "Зомби:" },
					{ "Japanese" , "ゾンビ:" },
					{ "Korean", "좀비:" },
					{ "Javanese" , "Mayit:" },
					{ "Polish" , "Zombi:" },
					{ "Hungarian" , "Zombik:" },
					{ "Arabic" , "الزومبي:" },
					// { "Ukrainian" , "Зомбі:" },
					// { "Slovak" , "Zombíci:"}
				}
			}

		};

		internal static void Init()
		{
			FileLoader.LoadStrings();
			CompileRegexCache();
		}

		private static void CompileRegexCache()
		{
			try
			{
				foreach (var entry in translationStringRegex)
				{
					try
					{
						compiledRegexCache[entry.Key] = new Regex(entry.Key, RegexOptions.Compiled);
					}
					catch (Exception ex)
					{
						Log.LogWarning($"Failed to compile regex pattern '{entry.Key}': {ex.Message}");
					}
				}
				Log.LogInfo($"Compiled {compiledRegexCache.Count} regex patterns");
			}
			catch (Exception ex)
			{
				Log.LogError($"Error compiling regex cache: {ex.Message}");
			}
		}

		internal static void Reload()
		{
			translationResultCache.Clear();
			translationString.Clear();
			translationStringRegex.Clear();
			compiledRegexCache.Clear();
			FileLoader.LoadStrings();
			CompileRegexCache();
		}

		public static TextMeshPro TranslateText(TextMeshPro originalTMP, bool isLog = false)
		{
			#if MULTI_LANGUAGE
			string currentLanguage = Utils.Language.ToString();
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(currentLanguage);
			#else
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont();
			#endif

			string translatedText = TranslateText(originalTMP.text);
			originalTMP.font = fontAsset;
			originalTMP.text = translatedText;

			return originalTMP;
		}

		public static TextMeshProUGUI TranslateText(TextMeshProUGUI originalTMP, bool isLog = false)
		{
			#if MULTI_LANGUAGE
			string currentLanguage = Utils.Language.ToString();
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(currentLanguage);
			#else
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont();
			#endif

			string translatedText = TranslateText(originalTMP.text);
			originalTMP.font = fontAsset;
			originalTMP.text = translatedText;

			return originalTMP;
		}

		public static string TranslateText(string originalText, bool isLog = false)
		{
			// Check cache first
			if (translationResultCache.TryGetValue(originalText, out string cachedResult))
			{
				return cachedResult;
			}

			string text = DoTranslateText(originalText, false);

			// Add to cache with size limit
			if (translationResultCache.Count < MAX_CACHE_SIZE)
			{
				translationResultCache[originalText] = text;
			}

			string checkText;
			#if DEBUG
			Regex regex = new("\\p{IsCJKUnifiedIdeographs}+");
			Match match = regex.Match(text);

			if(match.Success)
			{
				// Log.LogDebug("Untranslated String: " + match.Value);
				FileLoader.DumpUntranslatedStrings(text);
			}
			#endif

			checkText = text;

			return checkText;
		}

		public static string TranslateText(string originalText, string pattern, bool isLog = false)
        {
            if (TestRegex(originalText, pattern) && translationStringRegex.ContainsKey(pattern))
            {
                // Extract dynamic parts from the original text
                var regex = compiledRegexCache.TryGetValue(pattern, out var cachedRegex) ? cachedRegex : new Regex(pattern);
                var match = regex.Match(originalText);
                int groupCount = match.Groups.Count;

                if (isLog)
                    Log.LogDebug("Text found in translationStringRegex {0}: {1}", match, groupCount);

                // List to hold formatted dynamic parts
                List<string> dynamicParts = [];

                // Loop through each group and determine its translation
                for (int i = 1; i < groupCount; i++)
                {
                    string groupValue = match.Groups[i].Value;
                    string translatedValue = translationString.ContainsKey(groupValue)
                        ? translationString[groupValue]
                        : groupValue;
                    dynamicParts.Add(translatedValue);
                }

                // Format the output string with dynamic parts
                return string.Format(translationStringRegex[pattern], [.. dynamicParts]);
            }
            else
            {
                if (isLog)
                    Log.LogDebug($"Text '{originalText}' not translated");
#if DEBUG
				FileLoader.DumpUntranslatedStrings(originalText);
#endif
                return originalText;
            }
        }

	public static string TranslateColorText(string originalText, bool isLog = false)
	{
		string pattern = @"(<color[^>]*>.*?</color>)";
		if (TestRegex(originalText, pattern))
		{
			return DoTranslateText(originalText, isLog);
		}
		return originalText;
	}

        public static string DoTranslateText(string originalText, bool isLog = false)
        {
			if (string.IsNullOrEmpty(originalText))
			{
				if (isLog)
					Log.LogError("Text Null or Empty");

				return string.Empty;
			}

			if (translationString.ContainsKey(originalText))
			{
				if (isLog)
					Log.LogDebug($"Text '{originalText} found in translationString");
				return translationString[originalText];
			}

			// Regex-based dynamic translation
			foreach (var entry in translationStringRegex)
			{
				if (TestRegex(originalText, entry.Key))
				{
                    // Extract dynamic parts from original text
                    var regex = compiledRegexCache.TryGetValue(entry.Key, out var cachedRegex) ? cachedRegex : new Regex(entry.Key);
                    var match = regex.Match(originalText);
					int groupCount = match.Groups.Count;

					if (isLog)
						Log.LogDebug("Text found in translationStringRegex {0}: {1}", match, groupCount);

					// List to hold formatted dynamic parts
					List<string> dynamicParts = [];

					// Loop through each group and determine its translation
					for (int i = 1; i < groupCount; i++)
					{
						string groupValue = match.Groups[i].Value;
						string translatedValue = translationString.ContainsKey(groupValue)
							? translationString[groupValue]
							: groupValue;
						dynamicParts.Add(translatedValue);
					}

					// Format the output string with dynamic parts
					return string.Format(entry.Value, [.. dynamicParts]);
				}
			}

			if (isLog)
				Log.LogDebug($"Text '{originalText}' not translated");
			return originalText;
		}

        public static bool TestRegex(string originalText, string pattern)
        {
            if (compiledRegexCache.TryGetValue(pattern, out var cachedRegex))
            {
                return cachedRegex.IsMatch(originalText);
            }
            return Regex.IsMatch(originalText, pattern);
        }

        private static TextAlignmentOptions TextAnchorToTMPAlignment(TextAnchor anchor)
		{
			return anchor switch
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
				_ => TextAlignmentOptions.Center
			};
		}

		public static TextMeshProUGUI ConvertToTextMeshPro(UnityEngine.UI.Text oldText, TMP_FontAsset fontAsset, bool isLog = false)
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

			GameObject textObject = oldText.gameObject;

			// Preserve text content and settings
			string originalText = oldText.text;
			originalText = TranslateText(originalText, isLog);
			TextAnchor alignment = oldText.alignment;
			Color color = oldText.color;

			// Remove old Text component
			UnityEngine.Object.DestroyImmediate(oldText);

			// Add TextMeshProUGUI component
			TextMeshProUGUI newTMP = textObject.AddComponent<TextMeshProUGUI>();
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

		public static void TranslateTextTransform(Transform baseTransform, bool isAutoTextContainer = false, bool isLog = false)
		{
			if (!baseTransform) return;

#if MULTI_LANGUAGE
			string currentLanguage = Utils.Language.ToString();
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(currentLanguage);
#else
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont();
#endif

			if (fontAsset == null)
			{
#if MULTI_LANGUAGE
				Log.LogError($"Font for language '{currentLanguage}' not found. Translation aborted.");
#else
				Log.LogError("Font not found. Translation aborted.");
#endif
				return;
			}

			// Local function for processing transforms
			void ProcessTextTransform(Transform textTransform)
			{
				if (!textTransform) return;

				// Handle TextMeshPro components
				TextMeshPro textTMP = textTransform.GetComponent<TextMeshPro>();
				if (textTMP)
				{
					textTMP.text = TranslateText(textTMP.text, isLog);
					textTMP.autoSizeTextContainer = isAutoTextContainer;
					textTMP.font = fontAsset;
				}

				TextMeshProUGUI textTMPUGUI = textTransform.GetComponent<TextMeshProUGUI>();
				if (textTMPUGUI)
				{
					textTMPUGUI.text = TranslateText(textTMPUGUI.text, isLog);
					textTMPUGUI.enableAutoSizing = isAutoTextContainer;
					textTMPUGUI.font = fontAsset;
				}

				// Handle UnityEngine.UI.Text components
				UnityEngine.UI.Text textUI = textTransform.GetComponent<UnityEngine.UI.Text>();
				if (textUI)
				{
					ConvertToTextMeshPro(textUI, fontAsset, isLog);
				}
			}

			// Process specific text paths
			ProcessTextTransform(baseTransform.Find("text"));
			ProcessTextTransform(baseTransform.Find("text1"));
			// ProcessTextTransform(baseTransform.Find("text2"));

			Transform shadowTransform = baseTransform.Find("text/shadow");
			if (shadowTransform) ProcessTextTransform(shadowTransform);

			shadowTransform = baseTransform.Find("text1/shadow");
			if (shadowTransform) ProcessTextTransform(shadowTransform);
			
#if TESTING
			Transform childTransform = baseTransform.GetChild(0);
			if (childTransform) ProcessTextTransform(childTransform);
#endif
		}

		public static void TranslateTextUI(TextMeshPro textTMP, bool? isAutoTextContainer = null, bool isLog = false)
		{
			string currentLanguage = Utils.Language.ToString();
			if (textTMP)
			{
				textTMP.text = TranslateText(textTMP.text, isLog);
				if (isAutoTextContainer!=null) textTMP.autoSizeTextContainer = isAutoTextContainer.Value;
				textTMP.font = FontStore.LoadTMPFont(currentLanguage);
			}
		}
		public static void TranslateTextUI(TextMeshProUGUI textTMP, bool? isAutoTextContainer = null, bool isLog = false)
		{
			string currentLanguage = Utils.Language.ToString();
			if (textTMP)
			{
				string origText = textTMP.text;

				textTMP.text = TranslateText(origText, isLog) == "" ? origText : TranslateText(origText, isLog);
				if (isAutoTextContainer != null) textTMP.autoSizeTextContainer = isAutoTextContainer.Value;
				if (origText != textTMP.text)
					textTMP.font = FontStore.LoadTMPFont(currentLanguage);
			}
		}

		public static void TranslateTextUI(TMP_InputField TextInput)
		{
			string currentLanguage = Utils.Language.ToString();
			if (TextInput)
			{
				string oriText = TextInput.m_Text;
				TextInput.m_Text = TranslateText(oriText);
				TextInput.m_OriginalText = TranslateText(oriText);
				TextInput.fontAsset = FontStore.LoadTMPFont(currentLanguage);
			}
		}

		public static void LogAll()
		{
			Log.LogInfo("Logging all StringStore entries.");
			Log.LogInfo("Regex Entries: {0}", translationStringRegex.Count);
			Log.LogInfo("String Entries: {0}", translationString.Count);
		}
	}
}