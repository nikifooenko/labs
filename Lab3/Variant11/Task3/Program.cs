using System;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            var mostFrequentSymbol = str.GroupBy(i => i).GroupBy(i => i.Count())
                                     .OrderByDescending(i => i.Key).First().Select(i => i.Key);
            Console.WriteLine("Символ(ы), которые встречаются чаще всего:");
            foreach (var i in mostFrequentSymbol)
            {
                Console.WriteLine(i);
            }
        }
    }
}
