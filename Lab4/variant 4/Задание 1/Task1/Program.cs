using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallelogram c = new Parallelogram(4, 5, 6);
            c.PrintInfo();
            Console.WriteLine($"Площадь: {c.GetArea()}");
            Console.WriteLine($"Периметр: {c.GetPerimetr()}");
        }
    }
}
