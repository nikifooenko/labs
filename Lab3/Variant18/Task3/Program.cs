using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        public static string GetWord(string sentence, int wordNum)
        {
            string[] words = Regex.Split(sentence, @"[,\s+]");
            return words.Length > wordNum - 1 ? words[wordNum - 1] : null;
        }

        public static int CountSymbol(string str, char symbol)
        {
            return str.Count(i => i == symbol);
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string thirdWord = GetWord(str, 4);
            if (thirdWord != null)
            {
                Console.WriteLine($"Количество символов 'r': {CountSymbol(thirdWord, 'r')}");
            }
            else
            {
                Console.WriteLine("Слово отсутствует");
            }
        }
    }
}
