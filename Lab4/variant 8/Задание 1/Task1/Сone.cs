using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Сone
    {
        private double height;
        private double radius;
        private double coneLine;

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

        public double ConeLine
        {
            get
            {
                return coneLine;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Образующая не может быть меньше 0");
                }
                coneLine = value;
            }
        }

        public Сone(double radius, double coneLine, double height)
        {
            Radius = radius;
            ConeLine = coneLine;
            Height = height;
        }

        public double GetArea()
        {
            return Math.PI * radius * coneLine + Math.PI * Math.Pow(radius, 2);
        }

        public double GetVolume()
        {
            return Math.PI * Math.Pow(radius, 2) * height / 3;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Радиус: {radius}, образующая: {coneLine}, высота: {height}");
        }
    }
}
