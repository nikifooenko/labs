using System;
using System.Text;

namespace Task2
{
    class Program
    {
        public static bool IsLatin(char letter)
        {
            int code = (int)letter;
            return code >= 65 && code <= 90 || code >= 97 && code <= 122;
        }

        public static string LatinLettersReplace(string str, char replaceSymbol)
        {
            StringBuilder sb = new StringBuilder(str);
            for (int i = 0; i < sb.Length; i++)
            {
                if (IsLatin(sb[i]))
                {
                    sb[i] = replaceSymbol;
                }
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = LatinLettersReplace(text, '+');
            Console.WriteLine(result);
        }
    }
}
