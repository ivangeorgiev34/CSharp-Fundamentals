using System;

namespace _10.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter <= 10)
            {
                Console.WriteLine($"{number} X {counter} = {number * counter}");
                counter++;
            }
        }
    }
}
