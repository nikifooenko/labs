using System;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int starCount = str.Substring(str.LastIndexOf(':')).Count(i => i == '*');
            Console.WriteLine(starCount);
        }
    }
}
