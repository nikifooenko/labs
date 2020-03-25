using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder c = new Cylinder(5, 6);
            c.PrintInfo();
            Console.WriteLine($"Площадь: {c.GetArea()}");
            Console.WriteLine($"Объём: {c.GetVolume()}");
        }
    }
}
