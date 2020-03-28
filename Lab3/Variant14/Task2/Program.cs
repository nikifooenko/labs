using System;
using System.Text;

namespace Task2
{
    class Program
    {

        public static string LettersReplace(string str, char letter, char replaceSymbol)
        {
            StringBuilder sb = new StringBuilder(str);
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == letter)
                {
                    sb[i] = replaceSymbol;
                }
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = LettersReplace(text, 'А', '*');
            Console.WriteLine(result);
        }
    }
}
