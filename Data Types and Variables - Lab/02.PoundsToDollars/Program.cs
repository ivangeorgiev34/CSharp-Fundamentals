using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double britishPounds = double.Parse(Console.ReadLine());
            double americanDollars = 1.31 * britishPounds;
            Console.WriteLine($"{americanDollars:f3}");
        }
    }
}
