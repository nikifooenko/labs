using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            var onlyLower = str.Except(str.ToUpper()).ToArray();
            Console.WriteLine(onlyLower);
        }
    }
}
