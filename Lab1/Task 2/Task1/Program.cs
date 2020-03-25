using System;
using System.Linq;

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

        public static int GetDifferentNumberPosition(int[] numbers)
        {
            var elementsByFreq = numbers.GroupBy(i => i).Select(i => new { value = i.Key, count = i.Count() }).OrderBy(i => i.count);
            if (elementsByFreq.Count() != 2 || elementsByFreq.First().count > 1)
            {
                return -1;
            }
            return Array.IndexOf(numbers, elementsByFreq.First().value) + 1;
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[4];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Введите число №{i}");
                numbers[i] = GetIntValue();
            }
            int result = GetDifferentNumberPosition(numbers);
            if (result != -1)
            {
                Console.WriteLine($"Номер элемента: {result}");
            }
            else
            {
                Console.WriteLine("Введены некорректные данные");
            }
        }
    }
}
