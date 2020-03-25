using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 14.26;
            double y = -1.22;
            double z = 3.5 * Math.Pow(10, -2);
            double part1 = 2 * Math.Cos(x - 2 / 3);
            double part2 = 1 / 2 + Math.Pow(Math.Sin(y), 2);
            double part3 = 1 + Math.Pow(z, 2) / (3 - Math.Pow(z, 2) / 5);
            double s = part1 / part2 * part3;
            Console.WriteLine(s);
        }
    }
}
