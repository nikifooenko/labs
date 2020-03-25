﻿using System;

namespace Task4
{
    class Program
    {
        public static int GetNegativesAmount(int[,] array)
        {
            int counter = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < 0)
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
            int negatives = GetNegativesAmount(array);
            Console.WriteLine($"Количество элементов меньше 0: {negatives}");
        }
    }
}
