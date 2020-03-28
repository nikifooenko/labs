using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        public static int CountInLine(string str)
        {
            str = Regex.Replace(str, "[^0-9a-zA-ZА-я]+", "");
            return str.Count(i => i == Char.ToLower(i));
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine($"Количество строчных символов: {CountInLine(text)}");
        }
    }
}
