using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Square
    {
        private double sideLength;

        public double Side
        {
            get
            {
                return sideLength;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Длина стороны не может быть меньше 0");
                }
                sideLength = value;
            }
        }


        public Square(double side)
        {
            sideLength = side;
        }

        public double GetArea()
        {
            return sideLength * sideLength;
        }

        public double GetPerimetr()
        {
            return sideLength * 4;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Длина стороны: {sideLength}");
        }
    }
}