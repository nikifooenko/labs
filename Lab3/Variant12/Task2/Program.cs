using System;
using System.Text;

namespace Task2
{
    class Program
    {

        public static string LetterExchange(string str, int firstLetter, int secondLetter)
        {
            StringBuilder sb = new StringBuilder(str);
            char temp = sb[firstLetter];
            sb[firstLetter] = sb[secondLetter];
            sb[secondLetter] = temp;

            return sb.ToString();
        }

        public static string FirstAndLastLetterExhange(string str)
        {
            //нужно учесть ситуацию, когда слова разделены более чем одни пробелом
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = LetterExchange(words[i], 0, words[i].Length - 1);
            }
            return string.Join(" ", words);
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = FirstAndLastLetterExhange(text);
            Console.WriteLine(result);
        }
    }
}
