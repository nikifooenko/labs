using System;
using System.Linq;

namespace Task7
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

        public static int GetMaxElementNumber(int[] array)
        {
            return Array.IndexOf(array, array.Max()); 
        }

        public static int MultEvenElements(int[] array)
        {
            int multiplication = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    multiplication *= array[i];
                }
            }

            return multiplication;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введине длину массива: ");
            int length = GetValue();
            int[] array = GetFilledArray(length);
            Console.WriteLine("Исходный массив: ");
            PrintArray(array);
            Console.WriteLine($"Номер максимального элемента {GetMaxElementNumber(array)}");
            Console.WriteLine($"Произведение элементов, стоящих на чётных местах {MultEvenElements(array)}");
        }
    }
}
