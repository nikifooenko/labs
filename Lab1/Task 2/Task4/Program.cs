using System;

namespace Task4
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

        public static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        
        static void Main(string[] args)
        {
            int[] numbers = GetFilledArray(3);
            Array.Sort(numbers);
            Array.Reverse(numbers);
            int sum;
            if (numbers[0] != numbers[1])
            {
                sum = numbers[0] + numbers[1];
                Console.WriteLine($"Сумма двух наибольших элементов массива: {sum}");
            }
            else
            {
                Console.WriteLine("Нельзя найти 2 наибольших");
            }
        }
    }
}
