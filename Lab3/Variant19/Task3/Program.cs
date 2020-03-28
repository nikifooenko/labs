using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] words = Regex.Split(str, @"[,\s+]");
            int amount = words.Count(i => i.Count(i => i == 'z') == 2);
            Console.WriteLine($"Количетсво слов: {amount}");
        }
    }
}
