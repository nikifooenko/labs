using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            if (str.Contains('w') && str.Contains('o') 
                && str.Contains('r') && str.Contains('k'))
            {
                Console.WriteLine("Содержит");
            }
            else
            {
                Console.WriteLine("Не содержит");
            }
        }
    }
}
