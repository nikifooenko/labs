using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = -15.246;
            double y = 4.642 * Math.Pow(10, -2);
            double z = 21;
            double part1 = Math.Log10(Math.Pow(y, -Math.Sqrt(Math.Abs(x))));
            double part2 = x - y / 2;
            double part3 = Math.Pow(Math.Sin(Math.Atan(z)), 2);
            double s = part1 * part2 + part3;
            Console.WriteLine(s);
        }
    }
}
