using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"[^0-9\s]");
            Regex spaces = new Regex(@"\s+");
            string str = Console.ReadLine();
            str = regex.Replace(str, " ");
            str = spaces.Replace(str, " ");
            int result = str.Trim().Split(' ').Select(i => Int32.Parse(i)).ToArray().Sum();
            Console.WriteLine($"Результат: {result}");
        }
    }
}
