using System;

namespace Task2
{
    class Program
    {
        public static string RemoveFirstLetter(string str)
        {
            string[] words = str.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Substring(1, words[i].Length - 1);
            }
            return string.Join(" ", words);
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = RemoveFirstLetter(text);
            Console.WriteLine(result);
        }
    }
}
