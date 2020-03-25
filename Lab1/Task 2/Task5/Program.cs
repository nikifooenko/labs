using System;
using System.Linq;

namespace Task5
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

        public static int[] GetFilledArray(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент массива");
                array[i] = GetValue();
            }
            return array;
        }

        public static bool IsUnique(int[] numbers, int number)
        {
            return numbers.Count(i => i == number) == 1;
        }

        static void Main(string[] args)
        {
            int[] numbers = GetFilledArray(3);
            int min = numbers.Min();
            int max = numbers.Max();
            if (IsUnique(numbers, min) && IsUnique(numbers, max))
            {
                Console.WriteLine($"Минимальное: {min}");
                Console.WriteLine($"Максимальное: {max}");
            }
            else
            {
                Console.WriteLine("Нельзя определить наибольшее/наименьшее число");
            }
        }
    }
}
