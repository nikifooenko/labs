using System;

namespace Task8
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

        public static int GetInversionsAmount(int[] array)
        {
            int invesrionsAmount = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    invesrionsAmount++;
                }
            }
            return invesrionsAmount;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введине длину массива: ");
            int length = GetValue();
            int[] array = GetFilledArray(length);
            Console.WriteLine($"Количество инверсий в массивве: {GetInversionsAmount(array)}");
        }
    }
}
