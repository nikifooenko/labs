using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;

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

        public double C
        {
            get
            {
                return sideC;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Сторона не может быть меньше 0");
                }
                sideC = value;
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            A = sideA;
            B = sideB;
            C = sideC;
        }

        public double GetArea()
        {
            double halfPerimetr = GetPerimetr() / 2;
            double height = 2 * Math.Sqrt(halfPerimetr * (halfPerimetr - A) * (halfPerimetr - B) * (halfPerimetr - C)) / A;
            return A * height / 2;
        }

        public double GetPerimetr()
        {
            return sideA + sideB + sideC;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Сторона А: {sideA}, Сторона B: {sideB}, Сторона С: {sideC}");
        }
    }
}
