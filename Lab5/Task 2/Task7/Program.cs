using System;

namespace Task7
{
    class Program
    {
        public static int GetMultiplesAmount(int number, int value)
        {
            int counter = 0;
            while (number > 0)
            {
                if ((number % 10) % value == 0)
                {
                    counter++;
                }
                number /= 10;
            }
            return counter;
        }

        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Количество цифр, которые кратны 4: {GetMultiplesAmount(number, 4)}");
        }
    }
}
