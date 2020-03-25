using System;
using System.Linq;


namespace Task12
{
    class Program
    {
        public static double GetValue()
        {
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Введено некорректное значение, повторите попытку");
            }
            return input;
        }

        public static double[] GetFilledArray(int size)
        {
            double[] array = new double[size];
            bool hasZero = false;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент массива");
                double value = GetValue();
                if (!array.Contains(value))
                {
                    array[i] = value;
                }
                else if (!hasZero && value == 0)
                {
                    array[i] = value;
                    hasZero = true;
                }
                else
                {
                    Console.WriteLine("Необходимо ввести уникальные значения, повторите попытку");
                    i--;
                }
            }
            return array;
        }

        public static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void ReplaceWithHalfSum(double[] numbers, double element)
        {
            numbers[Array.IndexOf(numbers, element)] = numbers.Select(i => i).Where(i => i != element).Sum() / (numbers.Length - 1);
        }

        static void Main(string[] args)
        {
            double[] numbers = GetFilledArray(3);
            if (numbers.Sum() < 1)
            {
                ReplaceWithHalfSum(numbers, numbers.Max());
            }
            else
            {
                ReplaceWithHalfSum(numbers, numbers.Min());
            }
            Console.WriteLine("Результат:");
            PrintArray(numbers);
        }
    }
}
