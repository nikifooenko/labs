using System;

namespace Task5
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
            bool isNegative = number < 0 ? true : false;
            number = int.Parse("1" + Math.Abs(number).ToString() + "1");
            number = isNegative ? number * -1 : number;
            Console.WriteLine(number);
        }
    }
}
