
using System;

namespace Task1
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

        public static int GetAmoutOfMultiples(int value, int number)
        {
            int amount = 0;
            while (value > 0)
            {
                if ((value % 10) % number == 0)
                {
                    amount++;
                }
                value /= 10;
            }
            return amount;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = GetValue();
            int result = GetAmoutOfMultiples(number, 3);
            Console.WriteLine($"Количество цифр, кратных 3: {result}");

        }
    }
}
