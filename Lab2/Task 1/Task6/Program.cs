using System;

namespace Task6
{
    class Program
    {

        public static void ShowArray(double[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }

        public static int GetIntValue()
        {
            int input;
            while (!Int32.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Введено некорректное значение, повторите попытку");
            }
            return input;
        }

        public static double GetDoubleValue()
        {
            double input;
            while (!Double.TryParse(Console.ReadLine(), out input))
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
                array[i] = GetDoubleValue();
            }
            return array;
        }

        public static int CountSighChanges(double[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length - 1; i += 2)
            {
                if (array[i] < 0 && array[i + 1] > 0
                    || array[i] > 0 && array[i + 1] < 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введине длину массива: ");
            int length = GetIntValue();
            double[] array = GetFilledArray(length);
            Console.WriteLine($"Количетсво изменений знака: {CountSighChanges(array)}");
        }
    }
}
