using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square c = new Square(6);
            c.PrintInfo();
            Console.WriteLine($"Площадь: {c.GetArea()}");
            Console.WriteLine($"Объём: {c.GetPerimetr()}");
        }
    }
}
