using System;

namespace Task1
{
    class Rectangle
    {
        private double length;
        private double width;

        public double Length
        {
            get 
            {
                return length;
            }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Длина не может быть меньше 0");
                }
                length = value;
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("ширина не может быть меньше 0");
                }
                width = value;
            }
        }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double GetArea()
        {
            return width * length;
        }

        public double GetPerimetr()
        {
            return (width + length) * 2;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Ширина: {width}, длина: {length}");
        }
    }
}
