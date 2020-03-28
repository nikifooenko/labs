using System;

namespace Task3
{
    class Program
    {
        public static bool CheckParentheses(string str)
        {
            int parentheses = 0;
            int i = 0;
            while (i < str.Length || parentheses < 0)
            {
                if (str[i] == '(')
                {
                    parentheses++;
                }
                else if (str[i] == ')')
                {
                    parentheses--;
                }
                i++;
            }
            return parentheses == 0;
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            if (CheckParentheses(str))
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
        }
    }
}
