using System;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Regex pattern = new Regex(@"\W*z");
            int wordsAmount = pattern.Split(str).Length - 1;
            Console.WriteLine(wordsAmount);
        }
    }
}
