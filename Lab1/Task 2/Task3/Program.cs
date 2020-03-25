using System;
using System.Linq;

namespace Task3
{
    

    class Program
    {
        public static double GetValue()
        {
            double input;
            while (!Double.TryParse(Console.ReadLine(), out input))
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

        public static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
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

        static void Main(string[] args)
        {
            double[] numbers = GetFilledArray(3);
            if (IsSortedByAscending(numbers) || IsSortedByDescending(numbers))
            {
                numbers = numbers.Select(i => i * 2).ToArray();
            }
            else
            {
                numbers = numbers.Select(i => i * -1).ToArray();
            }
            Console.WriteLine("Изменённый массив: ");
            PrintArray<double>(numbers);
        }
    }
}
