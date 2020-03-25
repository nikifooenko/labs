using System;

namespace Task7
{
    class Program
    {

        public static int GetWordPosition(string sentence, string word)
        {
            return Array.IndexOf(sentence.Split(), word);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string sentence = Console.ReadLine();
            Console.WriteLine("Введите слово: ");
            string word = Console.ReadLine();
            Console.WriteLine($"Позиция слова в предложении {GetWordPosition(sentence, word)}");
        }
    }
}
