using Il2CppTMPro;
using System.Text.RegularExpressions;
using UnityEngine;

namespace PvZ_Fusion_Translator.AssetStore
{
    public static partial class StringStore
    {
        public static string TranslateColorSegments(string input)
        {
            string result = "";
            string pattern = @"<color=[^>]+>[\s\S]*?(?:<\/color>|$)|(?:<(?!color=)|[^<])+";
            string smallPattern = @"(<color=[^>]+>)(.*?)(</color>)";
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Match colorMatch = Regex.Match(match.Value, smallPattern, RegexOptions.Singleline);
                if (colorMatch.Success)
                {
                    result += colorMatch.Groups[1].Value + DoTranslateText(colorMatch.Groups[2].Value) + colorMatch.Groups[3].Value;
                }
                else
                {
                    result += DoTranslateText(match.Value);
                }
            }

            return result;
        }
    }
}

    public static string TranslateColorSegments(string input)
    {
        string result = "";
        string pattern = @"<color=[^>]+>[\s\S]*?(?:<\/color>|$)|(?:<(?!color=)|[^<])+";
        string smallPattern = @"(<color=[^>]+>)(.*?)(</color>)";
        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            Match colorMatch = Regex.Match(match.Value, smallPattern, RegexOptions.Singleline);
            if (colorMatch.Success)
            {
                result += colorMatch.Groups[1].Value + DoTranslateText(colorMatch.Groups[2].Value) + colorMatch.Groups[3].Value;
            }
            else
            {
                result += DoTranslateText(match.Value);
            }
        }

        return result;
    }
}
