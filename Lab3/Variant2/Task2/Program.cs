using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Trim().Split(' ');
            Console.WriteLine($"Количетсво слов в строке: {words.Length}");
        }
    }
}
