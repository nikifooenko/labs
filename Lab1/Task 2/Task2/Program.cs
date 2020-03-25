using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        public static int GetIntValue()
        {
            int input;
            while (!Int32.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Введено некорректное значение, повторите попытку");
            }
            return input;
        }

        public static bool IsUnique(int[] numbers, int number)
        {
            return numbers.Count(i => i == number) == 1;
        }

        static void Main(string[] args)
        {
            int result;
            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Введите число №{i}");
                numbers[i] = GetIntValue();
            }
            if (numbers.Count(i => i % 2 == 0) > 0)
            {
                result = numbers.Max();
                if (IsUnique(numbers, result))
                {
                    Console.WriteLine($"Максимальный элемент: {result}");
                }
                else
                {
                    Console.WriteLine($"Невозможно однозначно определить максимальный элемент");
                }
            }
            else
            {
                result = numbers.Min();
                if (IsUnique(numbers, result))
                {
                    Console.WriteLine($"Минальный элемент: {result}");
                }
                else
                {
                    Console.WriteLine($"Невозможно однозначно определить минальный элемент");
                }
            }
        }
    }
}
