using System;

namespace Task6
{
    class Program
    {
        public static int AmountOfMultiples(int[,] array, int value)
        {
            int counter = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % value == 0)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        public static int GetInt()
        {
            int input;
            while (!Int32.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Введено некорректное значение, повторите попытку: ");
            }
            return input;
        }

        public static int[,] GetFilledMatrix(int rows, int columns)
        {
            int[,] array = new int[rows, columns];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine($"Введите [{i}][{j}]: ");
                    array[i, j] = GetInt();
                }
            }
            return array;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк: ");
            int rows = GetInt();
            Console.WriteLine("Введите количество столбцов: ");
            int columns = GetInt();
            int[,] array = GetFilledMatrix(rows, columns);
            int mutiplesOfTwo = AmountOfMultiples(array, 2);
            Console.WriteLine($"Количество элементов кратных 2: {mutiplesOfTwo}");
        }
    }
}
