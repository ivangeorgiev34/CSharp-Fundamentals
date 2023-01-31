using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            double powerNumber = double.Parse(Console.ReadLine());
            double result = PoweredNumber(baseNumber, powerNumber);
            Console.WriteLine(result);
        }

        static double PoweredNumber(double baseNumber, double powerNumber)
        {
            return Math.Pow(baseNumber, powerNumber);
        }
    }
}
