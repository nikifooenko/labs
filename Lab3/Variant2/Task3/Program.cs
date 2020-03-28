using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int commaPosiiton = str.IndexOf(", a");
            if (commaPosiiton != -1)
            {
                Console.WriteLine($"позиция запятой: {commaPosiiton}");
            }
            else
            {
                Console.WriteLine($"в тексте нет, запятых удовлетворящих параметрам");
            }
            
        }
    }
}
