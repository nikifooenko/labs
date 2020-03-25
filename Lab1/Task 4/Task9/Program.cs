using System;

namespace Task9
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
            int iterationNum = 0;
            int result = 0;
            while (result <= 0 && iterationNum < 1000)
            {
                result = -100 - iterationNum + iterationNum * 3;
                iterationNum++;
            }
            if (result > 0)
            {
                Console.WriteLine($"Значение первого положительного элемента: {result}");
            }
            else
            {
                Console.WriteLine("Среди 1000 элементов нет положительного");
            }
        }
    }
}
