using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5, 6);
            r.PrintInfo();
            Console.WriteLine($"Площадь: {r.GetArea()}");
            Console.WriteLine($"Периметр: {r.GetPerimetr()}");
        }
    }
}
