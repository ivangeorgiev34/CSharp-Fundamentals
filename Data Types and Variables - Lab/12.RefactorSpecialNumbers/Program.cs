using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numbers; i++)
            {
                int sumOfDigits = 0;
                int currentDigit = i;
                bool isSumValid = false;
                while (currentDigit != 0)
                {
                    sumOfDigits += currentDigit % 10;
                    currentDigit = currentDigit / 10;
                }

                isSumValid = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{i} -> {isSumValid}");

            }
        }
    }
}
