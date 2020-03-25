using System;
using System.Linq;

namespace Task17
{
    class Program
    {
        public static double GetValue()
        {
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Введено некорректное значение, повторите попытку");
            }
            return input;
        }

        public static double[] GetFilledArray(int size)
        {
            double[] array = new double[size];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент массива");
                array[i] = GetValue();
            }
            return array;
        }

        public static bool IsSortedByAscending(double[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsSortedByDescending(double[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] <= array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            double[] numbers = GetFilledArray(3);
            if (numbers.Contains(0))
            {
                Console.WriteLine("Массив содержит 0:");
                numbers = numbers.Select(i => (numbers.Sum() - i) / 2).ToArray();
            }
            else
            {
                Console.WriteLine("Элементы массива заменены минимальным:");
                double min = numbers.Min();
                numbers = numbers.Select(i => min).ToArray();
            }
            PrintArray(numbers);
        }
    }
}
