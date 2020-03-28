using System;

namespace Task3
{
    class Program
    {
        public static bool IsFirstAndLetterSame(string str)
        {
            return str[0] == str[str.Length - 1];
        }


        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] words = str.Split(',');
            int counter = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (IsFirstAndLetterSame(words[i].Trim()))
                {
                    counter++;
                }
            }
            Console.WriteLine($"Количество: {counter}");
        }
    }
}
