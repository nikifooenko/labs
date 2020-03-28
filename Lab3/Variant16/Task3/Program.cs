using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            if (str.Contains(':'))
            {
                int amount = str.Substring(str.LastIndexOf(':')).Split('l').Length - 1;
                Console.WriteLine(amount);
            }
            else
            {
                Console.WriteLine("В тексте не двоеточия");
            }
        }
    }
}
