using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            List<double> numbers = new List<double>();

            numbers.Add(firstNumber);
            numbers.Add(secondNumber);
            numbers.Add(thirdNumber);

            foreach (var number in numbers.OrderByDescending(n => n))
            {
                Console.WriteLine(number);
            }
        }
    }
}
