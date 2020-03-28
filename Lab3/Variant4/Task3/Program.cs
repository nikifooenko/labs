using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str = str.Replace(',', ' ');
            int wordAmount = str.Split(' ').Length;
            Console.WriteLine($"Количество слов: {wordAmount}");
        }
    }
}
