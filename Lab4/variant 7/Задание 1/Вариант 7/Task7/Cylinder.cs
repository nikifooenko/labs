using System;
using System.Collections.Generic;
using System.Text;

namespace Task7
{
    class Cylinder
    {
        private double height;
        private double radius;

        public double Height
        {
            get 
            {
                return height;
            }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Высота не может быть меньше 0");
                }
                height = value;
            }
        }
        public double Radius
        {
            get
            {
                return radius;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Радиус не может быть меньше 0");
                }
                radius = value;
            }
        }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public double GetArea()
        {
            return 2 * Math.PI * radius * height;
        }

        public double GetVolume()
        {
            return Math.PI * radius * radius * height;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Радиус: {radius}, высота: {height}");
        }
    }
}
