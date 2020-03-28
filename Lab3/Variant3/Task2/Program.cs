using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string sentence = Console.ReadLine();
            Regex regex = new Regex("[А-яA-z0-9\\s@%$&|№\\#^*)({}/><~\\[\\]]");
            int prepositions = regex.Replace(sentence, string.Empty).Length;
            Console.WriteLine($"Количество знаков препинания: {prepositions}");
        }
    }
}
