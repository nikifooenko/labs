using System.Text.RegularExpressions;
using System.Linq;

namespace TextHelper
{
    public static class SymbolsCount
    {
        public static int CountInLine(this string str)
        {
            str = Regex.Replace(str, "[^0-9a-zA-ZА-я]+", "");
            return str.Count(i => i == Char.ToLower(i));
        }
    }
}
