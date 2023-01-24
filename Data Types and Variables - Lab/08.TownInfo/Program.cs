using System;

namespace _08.TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTown = Console.ReadLine();
            ulong population = ulong.Parse(Console.ReadLine());
            uint kilometers = uint.Parse(Console.ReadLine());

            Console.WriteLine($"Town {nameOfTown} has population of {population} and area {kilometers} square km.");
        }
    }
}
