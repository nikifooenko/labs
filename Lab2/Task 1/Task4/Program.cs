using System;

namespace Task4
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

        public static int GetMultAmount(int[] array, int value)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % value == 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введине длину массива: ");
            int length = GetValue();
            int[] array = GetFilledArray(length);
            int firstMult = GetMultAmount(array, array[0]);
            int lastMult = GetMultAmount(array, array[array.Length - 1]);
            if (firstMult > lastMult)
            {
                Console.WriteLine("Больше тех чисел, которые делятся на первый элемент");
            }
            else if (firstMult < lastMult)
            {
                Console.WriteLine("Больше тех чисел, которые делятся на последний элемент");
            }
            else
            {
                Console.WriteLine("Количетсво одинаково");
            }
        }
    }
}
