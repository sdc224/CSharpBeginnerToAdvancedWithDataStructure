using System;
using System.Collections.Generic;

namespace CSharpBeginner
{
    public class StringUtility
    {
        public static string SummarizeTextTool(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
                return text;

            var words = text.Split(' ');
            var totalWords = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalWords += word.Length + 1;
                if (totalWords > maxLength)
                    break;
            }

            return String.Join(" ", summaryWords) + "...";
        }
    }
}