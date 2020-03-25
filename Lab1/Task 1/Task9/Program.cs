using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1.825 * Math.Pow(10, 2);
            double y = 18.225;
            double z = -3.298 * Math.Pow(10, -2);
            double part1 = Math.Abs(Math.Pow(x, y / x) - Math.Pow(y / x, 1 / 3)) + (y - x);
            double part2 = Math.Cos(y) - z / (y - x);
            double part3 = 1 + Math.Pow((y - x), 2);
            double s = part1 * part2 / part3;
            Console.WriteLine(s);
        }
    }
}
