using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle c = new Triangle(4, 5, 6);
            c.PrintInfo();
            Console.WriteLine($"Площадь: {c.GetArea()}");
            Console.WriteLine($"Периметр: {c.GetPerimetr()}");
        }
    }
}
