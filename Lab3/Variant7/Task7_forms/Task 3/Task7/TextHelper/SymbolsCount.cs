using System.Text.RegularExpressions;
using System.Linq;

namespace TextHelper
{
    public static class SymbolsCount
    {
        public static string GetWord(this string sentence, int wordNum)
        {
            string[] words = Regex.Split(sentence, @"\s+");
            return words.Length > wordNum - 1 ? words[wordNum - 1] : null;
        }

        public static int CountSymbol(this string str, char symbol)
        {
            return str.Count(i => i == symbol);
        }
    }
}