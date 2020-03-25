using System;

namespace Task7
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
            char[] numChars = Math.Abs(number).ToString().ToCharArray();
            Array.Reverse(numChars);
            number = int.Parse(numChars);
            number = isNegative ? number * -1 : number;
            Console.WriteLine($"Результат: {number}");
        }
    }
}
