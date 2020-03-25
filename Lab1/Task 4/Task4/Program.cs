using System;
using System.Text;

namespace Task4
{
    class Program
    {
        public static int GetValue()
        {
            int input;
            while (!Int32.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Введено некорректное значение, повторите попытку");
            }
            return input;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = GetValue();
            bool isNegative = number < 0 ? true : false;
            StringBuilder numString = new StringBuilder(Math.Abs(number).ToString());
            char temp = numString[0];
            numString[0] = numString[numString.Length - 1];
            numString[numString.Length - 1] = temp;
            number = int.Parse(numString.ToString());
            if (isNegative)
            {
                number *= -1;
            }
            Console.WriteLine(number);
        }
    }
}
