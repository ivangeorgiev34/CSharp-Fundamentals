using System;

namespace _01.SignOfIntegerNumbers
{
   public class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            CheckNegativeZeroOrPositive(number);
        }
        static void CheckNegativeZeroOrPositive(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {

                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
