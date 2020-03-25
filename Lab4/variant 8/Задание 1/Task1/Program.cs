using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Сone c = new Сone(4, 5, 6);
            c.PrintInfo();
            Console.WriteLine($"Площадь: {c.GetArea()}");
            Console.WriteLine($"Объём: {c.GetVolume()}");
        }
    }
}
