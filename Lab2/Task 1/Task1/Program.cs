
using System;

namespace Task1
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

        static void Main(string[] args)
        {
            int[] a = { 2, 1, 0, 0, 2, 1 };
            Console.WriteLine("Исходный массив:");
            ShowArray(a);
            Array.Sort(a);
            Console.WriteLine("Отсортированный массив:"); 
            ShowArray(a);
        }
    }
}
