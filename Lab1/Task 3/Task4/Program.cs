using System;

namespace Task4
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

        public static string GetWordDeclination(int crows)
        {
            string str;
            switch (crows % 10)
            {
                case 1:
                    str = "ворона";
                    break;
                case 2:
                case 3:
                case 4:
                    str = "вороны";
                    break;
                default:
                    str = "ворон";
                    break;
            }
            return $"{crows} {str}";
        }


        static void Main(string[] args)
        {
            Console.Write("Введите количество лет: ");
            int crows = GetIntValue();
            Console.WriteLine(GetWordDeclination(crows));
        }
    }
}
