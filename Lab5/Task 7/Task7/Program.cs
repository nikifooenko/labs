using System;

namespace Task7
{
    class Program
    {
        public static int[] GetFilledArray(int size)
        {
            int[] array = new int[size];
            Random rn = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rn.Next(6, 52) * 19;
            }
            return array;
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

        public static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность: ");
            int size = GetValue();
            int[] array = GetFilledArray(size);
            PrintArray(array);
        }
    }
}
