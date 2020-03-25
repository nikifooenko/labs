using System.Text.RegularExpressions;
using System.Linq;

namespace TextHelper
{
    public static class SymbolsCount
    {
        private static char ToLowerChar(char ch)
        {
            return ch.ToString().ToLower()[0];
        }

        public static int CountInLine(this string str)
        {
            str = Regex.Replace(str, "[^0-9a-zA-ZА-я]+", "");
            return str.Count(i => i.ToString()[0] == ToLowerChar(i));
        }
    }
}
