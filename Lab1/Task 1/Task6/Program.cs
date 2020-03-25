using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 16.55 * Math.Pow(10, -3);
            double y = -2.75;
            double z = 0.15;
            double result = Math.Sqrt(10 * Math.Pow(x, 1d / 3) + Math.Pow(x, y + 2))
                            * Math.Pow(Math.Asin(z), 2) - Math.Abs(x - y);
            Console.WriteLine($"Резульат: {result}");
        }
    }
}
