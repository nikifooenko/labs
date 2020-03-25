using System;

namespace Task7
{
    class Program
    {

        public static int GetInt()
        {
            int input;
            while (!Int32.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Неверный ввод повторите попытку: ");
            }
            return input;
        }

        public static char[] GetCharArray(int size)
        {
            char[] array = new char[size];
            Console.WriteLine("Введите символы: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadKey().KeyChar;
            }
            Console.WriteLine();
            return array;
        }

        public static bool IsMirrored(char[] array)
        {
            for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
            {
                if (array[i] != array[j])
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество символов: ");
            int lenght = GetInt();
            char[] symbols = GetCharArray(lenght);
            if (IsMirrored(symbols))
            {
                Console.WriteLine("Зеркальный");
            }
            else
            {
                Console.WriteLine("Не зеркальный");
            }
            
        }
    }
}
