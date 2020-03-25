using System;
using System.Linq;

namespace Task7
{
    class Program
    {
        public static int TaskFunc(byte[] array)
        {
            return array.Min() + array[array.Length - 1];
        }

        public static double TaskFunc(double[] array)
        {
            return array.Min() + array[array.Length - 1];
        }

        public static int TaskFunc(char[] array)
        {
            int[] codes = array.Select(i => (int)i).ToArray();
            return codes.Min() + codes[codes.Length - 1];
        }

        static void Main(string[] args)
        {
            byte[] byteArray = { 1, 3, 4, 5, 2, 4, 2 };
            Console.WriteLine($"Результат для byteArray {TaskFunc(byteArray)}");
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
            Console.WriteLine($"Результат для dobuleArray {TaskFunc(doubleArray)}");
            char[] charArray = { 'a', 'b', 'c', 'b', 'e', 'f', 'g' };
            Console.WriteLine($"Результат для charArray {TaskFunc(charArray)}");
        }
    }
}
