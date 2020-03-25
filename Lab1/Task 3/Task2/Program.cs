using System;

namespace Task2
{
    class Program
    {
        public static int GetIntValue()
        {
            int input;
            while (!Int32.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Введено некорректное значение, повторите попытку");
            }
            return input;
        }

        public static string GetWordDeclination(int years)
        {
            string str;
            switch (years % 10)
            {
                case 1:
                    str = "год";
                    break;
                case 2:
                case 3:
                case 4:
                    str = "года";
                    break;
                default:
                    str = "лет";
                    break;
            }
            return $"{years} {str}";
        }


        static void Main(string[] args)
        {
            Console.Write("Введите количество лет: ");
            int years = GetIntValue();
            Console.WriteLine(GetWordDeclination(years));
        }
    }
}
