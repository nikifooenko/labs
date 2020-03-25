
using System;

namespace Task5
{
    class Program
    {

        public static void PrintArray<T>(T[] array)
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
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 20);
            }
            return array;
        }

        public static void Replace(int[] array, int left, int right)
        {
            for (int i = left + 1; i < right; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array[i] = array[i - 1] + array[i + 1];
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введине длину массива: ");
            int length = GetValue();
            int[] array = GetFilledArray(length);
            Console.WriteLine("Исходный массив: ");
            PrintArray(array);
            Console.WriteLine("Введите левую границу промежутка: ");
            int left = GetValue();
            while (left < 0 || left > length - 1)
            {
                Console.WriteLine("Ошибка ввода, повторите поптыку");
                left = GetValue();
            }
            Console.WriteLine("Введите правую границу промежутка: ");
            int right = GetValue();
            while (left < 0 || left > length - 1 || right < left)
            {
                if (right < left)
                {
                    Console.WriteLine("Правая граница не может быть меньше левой");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода, повторите поптыку");
                }
                right = GetValue();
            }
            Replace(array, left, right);
            Console.WriteLine("Изменённый массив: ");
            PrintArray(array);
        }
    }
}
