using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = -4.5;
            double y = 0.75 * Math.Pow(10, -4);
            double z = -0.845 * Math.Pow(10, 2);
            double part1 = Math.Pow(9 + Math.Pow(x - y, 2), 1 / 3);
            double part2 = x * x + y * y + 2;
            double part3 = 1 + Math.Pow(Math.E, Math.Abs(x - y)) * Math.Pow(Math.Tan(z), 3);
            double s = part1 / part2 - part3;
            Console.WriteLine(s);
        }
    }
}
