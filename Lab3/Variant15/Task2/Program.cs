using System;
using System.Linq;

namespace Task2
{
    class Program
    {

        public static bool IsPalindrom(string str)
        {
            str = str.Replace(" ", string.Empty).ToLower();
            return str.Reverse().SequenceEqual(str);
        }

        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            if (IsPalindrom(word))
            {
                Console.WriteLine("Это палиндром");
            }
            else
            {
                Console.WriteLine("Это не палиндром");
            }
        }
    }
}
