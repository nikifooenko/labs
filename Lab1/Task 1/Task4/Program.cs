using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0.4 * Math.Pow(10, 4);
            double y = -0.875;
            double z = -0.475 * Math.Pow(10, -3);
            double part1 = Math.Pow(Math.Abs(Math.Cos(x) - Math.Cos(y)), 1 + 2 * Math.Pow(Math.Sin(y), 2));
            double part2 = 1 + z + Math.Pow(z, 2) / 2 + Math.Pow(z, 3) / 3 + Math.Pow(z, 4) / 4;
            double s = part1 * part2;
            Console.WriteLine(s);
        }
    }
}
