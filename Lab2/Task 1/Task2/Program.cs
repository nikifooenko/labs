using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        public static void ShowArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }

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

        public static int SumBetweenNegatives(int[] array)
        {
            int firstNegativeIndex = -1;
            int secondNegativeIndex = -1;
            for (int i = 0; i < array.Length - 1; i += 2)
            {
                if (firstNegativeIndex != 0 && array[i] < 0)
                {
                    firstNegativeIndex = i;
                }
                if (secondNegativeIndex != 0 && array[i + 1] < 0)
                {
                    secondNegativeIndex = i + 1;
                }
            }
            if (firstNegativeIndex == -1 || secondNegativeIndex == -1)
            {
                throw new ArgumentException("В массиве недостаточно отрицательных элементов!");
            }
            int sum = 0;
            for (int i = firstNegativeIndex + 1; i < secondNegativeIndex; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введине длину массива: ");
            int length = GetValue();
            int[] array = GetFilledArray(length);
            int minIndex = Array.IndexOf(array, array.Min());
            Console.WriteLine($"Индекс минимального элемента: {minIndex}");
            int sumBetweenNegatives = 0;
            try
            {
                sumBetweenNegatives = SumBetweenNegatives(array);
                Console.WriteLine($"Сумма между двумя отрицательными элементами: {sumBetweenNegatives}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
