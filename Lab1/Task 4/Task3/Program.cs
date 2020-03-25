using System;

namespace Task3
{
    class Program
    {
        public static int GetValue()
        {
            int input;
            while (!Int32.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Введено некорректное значение, повторите попытку");
            }
            return input;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = GetValue();
            char firstDigitChar = number.ToString()[0];
            int firstDigit = firstDigitChar - '0';
            Console.WriteLine($"Первая цифра числа: {firstDigit}");
        }
    }
}
