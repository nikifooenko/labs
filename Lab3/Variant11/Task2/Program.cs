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

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.Write("Введите номер первого символа: ");
            int first = Int32.Parse(Console.ReadLine());
            Console.Write("Введите номер второго символа: ");
            int second = Int32.Parse(Console.ReadLine());
            //нужно добавить проверку на допустимость значений
            string changed = LetterExchange(text, first, second);
            Console.WriteLine(changed);
        }
    }
}
