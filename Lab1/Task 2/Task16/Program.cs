using System;
using System.Linq;

namespace Task16
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
            double[] numbers = GetFilledArray(4);
            double result;
            if (IsSortedByAscending(numbers))
            {
                Console.WriteLine("Массив отсортирован по возрастанию, найдено среднее арифметическое:");
                result = numbers.Average();
                Console.WriteLine($"Результат: {result}");
            }
            else if (IsSortedByDescending(numbers))
            {
                Console.WriteLine("Массив отсортирован по убыванию, действий не требуется");
            }
            else
            {
                Console.WriteLine("Найдено среднее геометрическое:");
                result = Math.Pow(numbers.Aggregate((x, y) => x * y), 1d / numbers.Length);
                Console.WriteLine($"Результат: {result}");
            }
            
        }
    }
}
