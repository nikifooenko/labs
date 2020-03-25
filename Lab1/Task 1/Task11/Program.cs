using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 6.251;
            double y = 0.827;
            double z = 25.001;
            double part1 = Math.Pow(y, Math.Pow(Math.Abs(x), 1 / 3)) + Math.Pow(Math.Cos(y), 3);
            double part2 = Math.Abs(x - y) * (1 + Math.Pow(Math.Sin(z), 2) / Math.Sqrt(x + y));
            double part3 = Math.Pow(Math.E, Math.Abs(x - y)) + x / 2;
            double s = part1 * part2 / part3;
            Console.WriteLine(s);
        }
    }
}
