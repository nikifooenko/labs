using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = -2.235 * Math.Pow(10, -2);
            double y = 2.23;
            double z = 15.221;
            double part1 = Math.Pow(Math.E, Math.Abs(x - y)) * Math.Pow(Math.Abs(x - y), x + y);
            double part2 = Math.Atan(x) + Math.Tan(z);
            double part3 = Math.Pow(Math.Pow(x, 6) + Math.Pow(Math.Log10(y), 2), 1 / 3);
            double s = part1 / part2 + part3;
            Console.WriteLine(s);
        }
    }
}
