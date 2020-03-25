using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.74 * Math.Pow(10, -2);
            double y = -0.825;
            double z = 0.16 * Math.Pow(10, 2);
            double part1 = 1 + Math.Pow(Math.Sin(x + y), 2) * Math.Pow(x, Math.Abs(y));
            double part2 = Math.Abs(x - 2 * y / (1 + x * x * y * y));
            double part3 = Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);
            double s = part1 / part2 + part3;
            Console.WriteLine(s);
        }
    }
}
