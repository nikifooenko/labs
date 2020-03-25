using System;

namespace Task5
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

        public static string GetWordDeclination(int cats)
        {
            string str;
            switch (cats % 10)
            {
                case 1:
                    str = "кот";
                    break;
                case 2:
                case 3:
                case 4:
                    str = "кота";
                    break;
                default:
                    str = "котов";
                    break;
            }
            return $"{cats} {str}";
        }


        static void Main(string[] args)
        {
            Console.Write("Введите количество лет: ");
            int cats = GetIntValue();
            Console.WriteLine(GetWordDeclination(cats));
        }
    }
}
