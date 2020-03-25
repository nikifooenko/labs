using System;
using System.Linq;

namespace Task14
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

        public static bool IsSortedByAscending(int[] array)
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

        public static bool IsSortedByDescending(int[] array)
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
            int[] numbers = GetFilledArray(4);
            if (IsSortedByAscending(numbers))
            {
                Console.WriteLine("Массив отсортирован по возрастанию, элементы заменены на остаток деления на 10:");
                numbers = numbers.Select(i => i % 10).ToArray();
            }
            else if (IsSortedByDescending(numbers))
            {
                Console.WriteLine("Массив отсортирован по убыванию, действий не требуется");
            }
            else
            {
                Console.WriteLine("Элементы массива заменены кубом:");
                numbers = numbers.Select(i => i * i * i).ToArray();
            }
            PrintArray(numbers);
        }
    }
}
