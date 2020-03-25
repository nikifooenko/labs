using System;

namespace Task2
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

        public static int GetAmoutOfEvenNumbers(int number)
        {
            int amount = 0;
            while (number > 0)
            {
                if ((number % 10) % 2 == 0)
                {
                    amount++;
                }
                number /= 10;
            }
            return amount;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = GetValue();
            int result = GetAmoutOfEvenNumbers(number);
            Console.WriteLine($"Количество чётных цифр: {result}");

        }
    }
}
