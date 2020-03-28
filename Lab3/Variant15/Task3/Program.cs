using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int amount = str.Split("dir").Length - 1;
            Console.WriteLine(amount);
        }
    }
}
