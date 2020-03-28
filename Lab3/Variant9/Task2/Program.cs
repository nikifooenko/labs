using System;
using System.Text;

namespace Task2
{
    class Program
    {
        public static string ToLowerTitleCase(string str)
        {
            StringBuilder sb = new StringBuilder(str);
            sb[0] = Char.ToLower(sb[0]);
            for (int i = 1; i < sb.Length; i++)
            {
                if (sb[i] != ' ' && sb[i - 1] == ' ')
                {
                    sb[i] = Char.ToLower(sb[i]);
                }
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = ToLowerTitleCase(text);
            Console.WriteLine(result);
        }
    }
}
