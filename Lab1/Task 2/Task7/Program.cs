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

        static void Main(string[] args)
        {
            int[] numbers = GetFilledArray(3);
            int positiveNumbers = numbers.Where(i => i > 0).Count();
            int negativeNumbers = numbers.Where(i => i < 0).Count();
            Console.WriteLine($"Положительных элементов: {positiveNumbers}");
            Console.WriteLine($"Отрицательных элементов: {negativeNumbers}");
        }
    }
}
