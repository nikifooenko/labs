using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Parallelogram
    {
        private double height;
        private double sideA;
        private double sideB;

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
        public double A
        {
            get
            {
                return sideA;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Сторона не может быть меньше 0");
                }
                sideA = value;
            }
        }

        public double B
        {
            get
            {
                return sideB;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Сторона не может быть меньше 0");
                }
                sideB = value;
            }
        }

        public Parallelogram(double sideA, double sideB, double height)
        {
            A = sideA;
            B = sideB;
            Height = height;
        }

        public double GetArea()
        {
            return A * height;
        }

        public double GetPerimetr()
        {
            return sideA * 2 + sideB * 2;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Сторона А: { sideA}, Сторона B: { sideB}, высота: {height}");
        }
    }
}
