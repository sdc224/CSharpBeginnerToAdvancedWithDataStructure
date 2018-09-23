using System;
using System.Linq;

namespace CSharpAdvanced
{
    //Step 1
    // Create a static class with name like this..... <Class to extend>Extensions
    public static class StringExtensions
    {
        // The first argument of this function shows the actual instance, as we are calling it like post.Shorten()
        public static string Shorten(this string str, int numberOfWords)
        {
            if(numberOfWords < 0)
                throw new ArgumentOutOfRangeException("Number of words cannot be less than 0");

            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            return numberOfWords > words.Length ? str : string.Join(" ", words.Take(numberOfWords)) + " . . .";

            // Note that Take() is an extension method created by .NET itself using Linq (as they have already sealed the string class)
        }
    }
}