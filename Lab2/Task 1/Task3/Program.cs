using System;

namespace Task3
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

        public static (int , int) GetMinPairSum(int[] array)
        {
            int sum = array[0] + array[1];
            int currentPairSum;
            int firstIndex = 0;
            int secondIndex = 1;
            for (int i = 2; i < array.Length - 1; i += 2)
            {
                currentPairSum = array[i] + array[i + 1];
                if (sum > currentPairSum)
                {
                    sum = currentPairSum;
                    firstIndex = i;
                    secondIndex = i + 1;
                }
            }
            return (firstIndex, secondIndex);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введине длину массива: ");
            int length = GetValue();
            int[] array = GetFilledArray(length);
            (int, int) pair = GetMinPairSum(array);
            Console.WriteLine($"Индексы пары элементов с минимальной суммой: {pair}");
        }
    }
}
