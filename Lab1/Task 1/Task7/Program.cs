using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0.1722;
            double y = 6.33;
            double z = 3.25 * Math.Pow(10, -4);
            double part1 = 5 * Math.Atan(x);
            double part2 = Math.Acos(x) / 4;
            double part3 = (x + 3 * Math.Abs(x - y) + x * x) / (Math.Abs(x - y) * z + x * x);
            double s = part1 - part2 * part3;
            Console.WriteLine(s);
        }
    }
}
