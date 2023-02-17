using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            PrintTopNumber(range);
        }
        static void PrintTopNumber(int range)
        {
            for (int i = 0; i < range; i++)
            {
                bool isOddDigit = false;
                int sum = 0;
                int currentNumber = i;

                while (currentNumber != 0)
                {
                    int digit = currentNumber % 10;
                    sum = sum + digit;
                    currentNumber = currentNumber / 10;
                    if (digit % 2 != 0)
                    {
                        isOddDigit = true;
                    }
                }
                if (isOddDigit && sum % 8 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
