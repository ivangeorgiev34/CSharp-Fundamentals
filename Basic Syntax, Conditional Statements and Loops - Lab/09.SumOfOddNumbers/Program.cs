using System;

namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            for (int i = 1; i < 100; i++)
            {
                if (!(i % 2 == 0))
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                    counter++;
                }
                if (n == counter)
                {
                    break;
                }

            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
