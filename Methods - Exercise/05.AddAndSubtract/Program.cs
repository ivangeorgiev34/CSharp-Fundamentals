using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(SubstractSum(firstNumber, secondNumber, thirdNumber));
        }
        static int AddNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        static int SubstractSum(int firstNumber, int secondNumber, int thirdNumber)
        {
            return AddNumbers(firstNumber, secondNumber) - thirdNumber;
        }
    }
}
