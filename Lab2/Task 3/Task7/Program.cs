﻿using System;

namespace Task7
{
    class Program
    {
        public static int GetInt()
        {
            int input;
            while (!Int32.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Введено некорректное значение, повторите попытку: ");
            }
            return input;
        }

        public static int[][] GetSteppedArray(int rows, int columnStartIndex)
        {
            int[][] array = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                array[i] = new int[columnStartIndex++];
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine($"Введите [{i}][{j}]: ");
                    array[i][j] = GetInt();
                }
            }
            return array;
        }

        public static void PrintArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]}\t");
                }
                Console.WriteLine();
            }
        }

        public static int AmountOfMultiples(int[][] array, int value)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % value == 0)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        static void Main(string[] args)
        {
            int[][] array = GetSteppedArray(4, 2);
            int mutiplesOfThree = AmountOfMultiples(array, 3);
            Console.WriteLine();
            PrintArray(array);
            Console.WriteLine($"Количество элементов кратных 3: {mutiplesOfThree}");
        }
    }
}
