using System;
using System.Linq;

namespace Task7
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

        public static int TaskFunc(int[] array)
        {
            return array.Where(i => i > 7 && i % 2 == 0).Count();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность: ");
            int size = GetValue();
            int[] array = GetFilledArray(size);
            Console.WriteLine($"Количество элементов больше 7 и кратных 2: {TaskFunc(array)}");
        }
    }
}
