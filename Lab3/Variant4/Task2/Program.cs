using System;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Regex pattern = new Regex(@"[^\d]");
            string numbers = pattern.Replace(str, string.Empty);
            Console.WriteLine($"Цифры в строке:\n{numbers}");
        }
    }
}
