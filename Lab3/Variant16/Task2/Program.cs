using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int[] numbers = str.Split(' ').Select(i => i.Length).ToArray();
            string result = string.Join(' ', numbers);
            Console.WriteLine(result);
        }
    }
}
