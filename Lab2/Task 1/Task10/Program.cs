using System;

namespace Task10
{
    class Program
    {
        public struct Triangle
        {
            public double a;
            public double b;
            public double c;
            public double halfPerimeter;

            public Triangle(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                halfPerimeter = (a + b + c) / 2;
            }

            public double GetArea()
            {
                return Math.Sqrt(halfPerimeter * (halfPerimeter - a)
                                 * (halfPerimeter - b) * halfPerimeter * c);
            }
        }

        public static double GetValue()
        {
            double input;
            while (!Double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Введено некорректное значение, повторите попытку");
            }
            return input;
        }

        //необходимо добавитьь проверку на корректность данных
        public static Triangle CreateTrinagle()
        {
            Console.WriteLine("Введите первую сторону: ");
            double a = GetValue();
            Console.WriteLine("Введите вторую сторону: ");
            double b = GetValue();
            Console.WriteLine("Введите третью сторону: ");
            double c = GetValue();
            return new Triangle(a, b, c);
        }

        static void Main(string[] args)
        {
            Triangle[] triangles = new Triangle[10];
            for (int i = 0; i < triangles.Length; i++)
            {
                Console.WriteLine($"Параметры {i} треугольника:");
                triangles[i] = CreateTrinagle();
            }
            Triangle biggestTriangle = triangles[0];
            int triangleNum = 0;
            for (int i = 1; i < triangles.Length; i++)
            {
                if (biggestTriangle.GetArea() < triangles[i].GetArea())
                {
                    biggestTriangle = triangles[i];
                    triangleNum = i;
                }
            }
            Console.WriteLine($"Номер треугольника с наибольшей площадью: {triangleNum}");
        }
    }
}
