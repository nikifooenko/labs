using System;

namespace Task7
{
    class Program
    {
        public static int GetIntValue()
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
            Console.Write("Введите R: ");
            int R = GetIntValue();
            int k = ((5 * R + 2) * (5 * R + 2)) % 4;
            double u = 0;
            switch (k)
            {
                case 0:
                    u = Math.Tan(R) + Math.Sin(Math.Pow(R, 3));
                break;
                case 1:
                    u = Math.Pow(R, 2) + Math.Sqrt(R);
                break;
                case 2:
                case 3:
                    u = Math.Pow(Math.E, R) + 2.5 * (R - 3);
                break;
                default:
                    u = 0;
                break;
            }
            Console.WriteLine($"Результат: {u}");
        }
    }
}
