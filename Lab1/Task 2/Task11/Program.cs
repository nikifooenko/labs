using System;
using System.Linq;

namespace Task11
{
    class Program
    {
        public static double GetValue()
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
                array[i] = GetValue();
            }
            return array;
        }

        public static bool IsSortedByAscending(double[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsSortedByDescending(double[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] <= array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            double[] numbers = GetFilledArray(4);
            if (IsSortedByAscending(numbers))
            {
                Console.WriteLine("Массив отсортирован по возрастанию, элементы заменены полусуммой максимального и минимального элементов:");
                //неоптимальынй запрос
                numbers = numbers.Select(i => (numbers.Where(j => j != i).Max() + numbers.Where(j => j != i).Min()) / 2).ToArray();
            }
            else if (IsSortedByDescending(numbers))
            {
                Console.WriteLine("Массив отсортирован по убыванию, числа заменены модулем максимального элемента:");
                numbers = numbers.Select(i => Math.Abs(numbers.Where(j => j != i).Max())).ToArray();
            }
            else
            {
                Console.WriteLine("Элементы массива заменены квадратом наибольшего элемента:");
                double squareMax = Math.Pow(numbers.Max(), 2);
                numbers = numbers.Select(i => squareMax).ToArray();
            }
            PrintArray(numbers);
        }
    }
}
