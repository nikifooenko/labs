using System;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int amountAmount = str.Count(i => i == ':');
            int symbolsAmount = 0;
            if (amountAmount == 2)
            {
                symbolsAmount = str.Substring(str.IndexOf(':') + 1, str.LastIndexOf(':') - str.IndexOf(':') - 1).Length;
                Console.WriteLine($"Количетсво символов: {symbolsAmount}");
            }
            else
            {
                Console.WriteLine($"Количетсво символов: {symbolsAmount}");
            }
        }
    }
}
