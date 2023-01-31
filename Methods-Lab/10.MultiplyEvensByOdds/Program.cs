using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int number = int.Parse(Console.ReadLine());
                number = Math.Abs(number);
                Console.WriteLine(GetMultipleOfEvenAndOdds(number));

            }

            static int GetSumOfEvenDigits(int number)
            {
                int sumEven = 0;

                while (number > 0)
                {
                    int currentDigit = number % 10;
                    if (currentDigit % 2 == 0)
                    {
                        sumEven = sumEven + currentDigit;

                    }
                    number = number / 10;
                }
                return sumEven;
            }
            static int GetSumOfOddDigits(int number)
            {
                int sumOdd = 0;

                while (number > 0)
                {
                    int currentDigit = number % 10;
                    if (!(currentDigit % 2 == 0))
                    {
                        sumOdd = sumOdd + currentDigit;

                    }
                    number = number / 10;
                }
                return sumOdd;
            }
            static int GetMultipleOfEvenAndOdds(int number)
            {
                int evenSum = GetSumOfEvenDigits(number);
                int oddSum = GetSumOfOddDigits(number);
                return evenSum * oddSum;

            }
        }
    }
}
