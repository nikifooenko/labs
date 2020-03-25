using System;

namespace Task6
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

        public static string GetWordDeclination(int amountOfDogs)
        {
            string str;
            switch (amountOfDogs % 10)
            {
                case 1:
                    str = "собака";
                    break;
                case 2:
                case 3:
                case 4:
                    str = "собаки";
                    break;
                default:
                    str = "собак";
                    break;
            }
            return $"{amountOfDogs} {str}";
        }


        static void Main(string[] args)
        {
            Console.Write("Введите количество собак: ");
            int amountOfDogs = GetIntValue();
            Console.WriteLine(GetWordDeclination(amountOfDogs));
        }
    }
}
