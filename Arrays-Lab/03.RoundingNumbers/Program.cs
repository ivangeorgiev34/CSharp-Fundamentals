using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbersArray = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.WriteLine($"{numbersArray[i]} => {(int)Math.Round(numbersArray[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
