using System;

namespace Task1
{
    class RectangularBox
    {
        private double height;
        private double length;
        private double width;

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
                    throw new ArgumentOutOfRangeException("Ширина не может быть меньше 0");
                }
                width = value;
            }
        }

        public RectangularBox(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double GetArea()
        {
            return (length * height + length * width + width * height) * 2;
        }

        public double GetVolume()
        {
            return length * width * height;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Длина: {length}, ширина: {width}, высота: {height}");
        }
    }
}
