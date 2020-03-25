using System;

namespace Task1
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

        public static string GetWordDeclination(int cash)
        {
            string str;
            switch (cash % 10)
            {
                case 1:
                    str = "рубль";
                    break;
                case 2:
                case 3:
                case 4:
                    str = "рубля";
                    break;
                default:
                    str = "рублей";
                    break;
            }
            return $"{cash} {str}";
        }


        static void Main(string[] args)
        {
            Console.Write("Введите количество рублей: ");
            int rubles = GetIntValue();
            Console.WriteLine(GetWordDeclination(rubles));
        }
    }
}
