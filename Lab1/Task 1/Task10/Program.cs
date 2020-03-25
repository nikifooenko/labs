using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.981 + Math.Pow(10, -2);
            double y = -1.625 + Math.Pow(10, 3);
            double z = 0.512;
            double part1 = Math.Pow(2, -x) * Math.Sqrt(x + Math.Pow(Math.Abs(y), 1 / 4));
            double part2 = Math.Pow(Math.Pow(Math.E, x - 1 / Math.Sin(z)), 1 / 3);
            double s = part1 * part2;
            Console.WriteLine(s);
        }
    }
}
