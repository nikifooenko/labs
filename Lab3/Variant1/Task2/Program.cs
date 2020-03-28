using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            int zeroAmount = str.Count(i => i == '0');
            int oneAmount = str.Count(i => i == '1');
            Console.WriteLine($"Количество нулей: {zeroAmount}, количество единиц: {oneAmount}");
        }
    }
}
