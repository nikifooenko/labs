using System;

namespace Task9
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

        public static void MoveRight(int[] array, int n)
        {
            n %= array.Length;
            Array.Reverse(array, 0, array.Length - n);
            Array.Reverse(array, array.Length - n, n);
            Array.Reverse(array);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введине длину массива: ");
            int length = GetValue();
            int[] array = GetFilledArray(length);
            Console.WriteLine("На сколько позиций сместить?: ");
            int n = GetValue();
            while (n < 0)
            {
                Console.WriteLine("Значение находится вне диапазона, повторите попытку");
                n = GetValue();
            }
            MoveRight(array, n);
            ShowArray(array);
        }
    }
}
