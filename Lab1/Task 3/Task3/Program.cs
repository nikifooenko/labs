using System;

namespace Task3
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

        public static string GetWordDeclination(int pennies)
        {
            string str;
            switch (pennies % 10)
            {
                case 1:
                    str = "копейка";
                    break;
                case 2:
                case 3:
                case 4:
                    str = "копейки";
                    break;
                default:
                    str = "копеек";
                    break;
            }
            return $"{pennies} {str}";
        }


        static void Main(string[] args)
        {
            Console.Write("Введите количество лет: ");
            int pennies = GetIntValue();
            Console.WriteLine(GetWordDeclination(pennies));
        }
    }
}
