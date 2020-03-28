using System;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int amount = 0;
            if (str.Count(i => i == ':') == 2)
            {
                amount = str.Substring(str.IndexOf(':'), str.LastIndexOf(':') - str.IndexOf(':') - 1).Length;
                Console.WriteLine($"Количетсво символов между двоеточиями: {amount}");
            }
            else
            {
                Console.WriteLine("Строка не удовлетворяет условиям");
            }
        }
    }
}
