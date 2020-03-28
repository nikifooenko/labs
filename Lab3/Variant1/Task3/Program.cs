using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int amount = str.Split("abc").Length - 1;
            Console.WriteLine($"число вхождений: {amount}");
        }
    }
}
