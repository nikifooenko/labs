using System;

namespace Task9
{
    class Program
    {
        ///<summary>Лучше использовать отдельно функции нахождения количество
        ///положительных и отрицательных элементов из других вариантов</summary>
        public static (int positive, int negative) PositivesAndNegativesAmount(int[,] array)
        {
            int positives = 0;
            int negatives = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                    {
                        positives++;
                    }
                    else if (array[i, j] < 0)
                    {
                        negatives++;
                    }
                }
            }
            return (positive: positives, negative: negatives);
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
            (int positives, int negatives) result = PositivesAndNegativesAmount(array);
            Console.WriteLine($"Количество элементов больше 0: {result.positives}, меньше 0: {result.negatives}");
        }
    }
}
