using System;

namespace Task7
{
    class Program
    {
        public static double Func(double a, double b)
        {
            return a / (5 * a) + (5 * a) / a + Math.Pow((a - b), 2);
        }

        static void Main(string[] args)
        {
            double s = Double.Parse(Console.ReadLine());
            double t = Double.Parse(Console.ReadLine());
            double v = Double.Parse(Console.ReadLine());
            double result = Func(4 * s, t) + Func(2 * t, v) + Func(3 * v, s);
            Console.WriteLine($"резульат: {result}");
        }
    }
}
