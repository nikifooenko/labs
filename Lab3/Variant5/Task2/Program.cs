using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            Regex numberPattern = new Regex(@"[\d]");
            int evenAmount = str.Where(i => numberPattern.IsMatch(i.ToString())).Select(i => Int32.Parse(i.ToString())).Count(i => i % 2 == 0);
            Console.WriteLine($"Количество чётных: {evenAmount}");
        }
    }
}
