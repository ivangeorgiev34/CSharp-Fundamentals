using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestNumber(numberOne, numberTwo, numberThree));
        }
        static int SmallestNumber(int numberOne, int numberTwo, int numberThree)
        {
            int result = Math.Min(numberOne, Math.Min(numberTwo, numberThree));
            return result;
        }
    }
}
