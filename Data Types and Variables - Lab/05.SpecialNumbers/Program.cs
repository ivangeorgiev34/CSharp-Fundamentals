using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            for (int i = 1; i <= num; i++)
            {
                int sumOfDigits = 0;
                int currentDigit = i;
                while (currentDigit != 0)
                {
                    sumOfDigits = sumOfDigits + currentDigit % 10;
                    currentDigit = currentDigit / 10;
                }

                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
