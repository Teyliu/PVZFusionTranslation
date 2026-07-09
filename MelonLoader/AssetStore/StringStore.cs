using Il2CppTMPro;
using System.Text.RegularExpressions;
using UnityEngine;

namespace PvZ_Fusion_Translator.AssetStore
{
	public static class StringStore
	{
		internal static Dictionary<string, string> stringsDict = [];

		public static Dictionary<string, string> translationStringRegex = new();

		public static Dictionary<string, string> translationString = new();

		public static Dictionary<string, string> izLevelTipDictionary = new();

		public static Dictionary<string, string> izTipCollectionString = new();

		public static Dictionary<string, string> fsLevelTipDictionary = new();

		public static Dictionary<string, string> fsTipCollectionString = new();

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
		}

		internal static void Reload()
		{
			translationString.Clear();
			translationStringRegex.Clear();
			izLevelTipDictionary.Clear();
			izTipCollectionString.Clear();
			fsLevelTipDictionary.Clear();
			fsTipCollectionString.Clear();
			FileLoader.LoadStrings();
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
			string text = DoTranslateText(originalText, false);
#if DEBUG
			Regex regex = new("\\p{IsCJKUnifiedIdeographs}+");
			Match match = regex.Match(text);

			if(match.Success)
			{
				FileLoader.DumpUntranslatedStrings(text);
			}
#endif
			return text;
		}

        public static string TranslateText(string originalText, string pattern, bool isLog = false)
        {
            if (TestRegex(originalText, pattern) && translationStringRegex.ContainsKey(pattern))
            {
                var regex = new Regex(pattern);
                var match = regex.Match(originalText);
                int groupCount = match.Groups.Count;

                if (isLog)
                    Log.LogDebug("Text found in translationStringRegex {0}: {1}", match, groupCount);

                List<string> dynamicParts = [];

                for (int i = 1; i < groupCount; i++)
                {
                    string groupValue = match.Groups[i].Value;
                    string translatedValue = translationString.ContainsKey(groupValue)
                        ? translationString[groupValue]
                        : groupValue;
                    dynamicParts.Add(translatedValue);
                }

                return string.Format(translationStringRegex[pattern], [.. dynamicParts]);
            }
			else
			{
                if (isLog)
                    Log.LogDebug($"Text '{originalText}' not translated");
                FileLoader.DumpUntranslatedStrings(originalText);
				return originalText;
			}
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

			if(izTipCollectionString.ContainsKey(originalText))
			{
				if(isLog)
				{
					Log.LogDebug($"Text '{originalText}' found in izTipCollectionString");
				}
				return izTipCollectionString[originalText];
			}

			if(fsTipCollectionString.ContainsKey(originalText))
			{
				if(isLog)
				{
					Log.LogDebug($"Text '{originalText}' found in fsTipCollectionString");
				}
				return fsTipCollectionString[originalText];
			}

			foreach (var entry in translationStringRegex)
			{
				if (TestRegex(originalText, entry.Key))
				{
					var regex = new Regex(entry.Key);
					var match = regex.Match(originalText);
					int groupCount = match.Groups.Count;

					if (isLog)
						Log.LogDebug("Text found in translationStringRegex {0}: {1}", match, groupCount);

					List<string> dynamicParts = [];

					for (int i = 1; i < groupCount; i++)
					{
						string groupValue = match.Groups[i].Value;
						string translatedValue = translationString.ContainsKey(groupValue)
							? translationString[groupValue]
							: groupValue;
						dynamicParts.Add(translatedValue);
					}

					return string.Format(entry.Value, [.. dynamicParts]);
				}
			}

			if (isLog)
				Log.LogDebug($"Text '{originalText}' not translated");
			if(Utils.CheckForUntranslatedText(originalText))
			{
				FileLoader.DumpUntranslatedStrings(originalText);
			}
			return originalText;
		}

        public static string TranslateColorText(string originalText, bool isLog = false)
        {
            string text = TranslateColorSegments(originalText);
#if DEBUG
            Regex regex = new("\\p{IsCJKUnifiedIdeographs}+");
            Match match = regex.Match(text);

            if (match.Success)
            {
                FileLoader.DumpUntranslatedStrings(text);
            }
#endif
            return text;
        }

		public static string TranslateColorSegments(string input)
		{
			string result = "";
            string pattern = @"<color=[^>]+>[\s\S]*?(?:<\/color>|$)|(?:<(?!color=)|[^<])+";
            string smallPattern = @"(<color=[^>]+>)(.*?)(</color>)";
            MatchCollection matches = Regex.Matches(input, pattern);

            for (int i = 0; i < matches.Count; i++)
			{
				Match match = matches[i];
				if (Regex.Match(match.Value, smallPattern, RegexOptions.Singleline).Success)
				{
					result += TranslateColorSegment(match.Value);
                }
				else
				{
                    result += DoTranslateText(match.Value);
                }
            }

            return result;
		}

		public static string TranslateColorSegment(string input)
		{
			string result = input;
			string pattern = @"(<color=[^>]+>)(.*?)(</color>)";
			Match match = Regex.Match(input, pattern, RegexOptions.Singleline);
            string translatedText = DoTranslateText(match.Groups[2].Value);
			if(Utils.CheckForUntranslatedText(translatedText))
			{
				FileLoader.DumpUntranslatedStrings(translatedText);
			}
            result = match.Groups[1].Value + translatedText + match.Groups[3].Value;

            return result;
		}
        public static bool TestRegex(string originalText, string pattern, bool singleLine = false)
		{
			RegexOptions options = (singleLine) ? RegexOptions.None : RegexOptions.Singleline;
			return Regex.IsMatch(originalText, pattern, options);
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

			GameObject textObject = oldText.gameObject;

			string originalText = oldText.text;
			originalText = TranslateText(originalText, isLog);
			TextAnchor alignment = oldText.alignment;
			Color color = oldText.color;

			UnityEngine.Object.DestroyImmediate(oldText);

			TextMeshProUGUI newTMP = textObject.AddComponent<TextMeshProUGUI>();
			if (newTMP == null)
			{
				Log.LogError($"Failed to add TextMeshProUGUI to object: {textObject.name}");
				return null;
			}

			newTMP.text = originalText;
			newTMP.color = color;
			newTMP.alignment = TextAnchorToTMPAlignment(alignment);
			newTMP.font = fontAsset;

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

			void ProcessTextTransform(Transform textTransform)
			{
				if (!textTransform) return;

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

				UnityEngine.UI.Text textUI = textTransform.GetComponent<UnityEngine.UI.Text>();
				if (textUI)
				{
					ConvertToTextMeshPro(textUI, fontAsset, isLog);
				}
			}

			ProcessTextTransform(baseTransform.Find("text"));
			ProcessTextTransform(baseTransform.Find("text1"));

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
				string translatedText = TranslateText(origText, isLog);

				textTMP.text = translatedText == "" ? origText : translatedText;
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