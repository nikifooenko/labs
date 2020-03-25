using System;
using System.Linq;

namespace Task6
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

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = GetValue();
            string numString = Math.Abs(number).ToString();
            int zeroAmount = numString.Count(i => i == '0');
            Console.WriteLine($"Количество нулей: {zeroAmount}");
        }
    }
}
