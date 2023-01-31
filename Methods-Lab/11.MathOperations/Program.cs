using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            if (@operator == '/')
            {
                Console.WriteLine(DivideNumbers(firstNumber, secondNumber));
            }
            else if (@operator == '*')
            {
                Console.WriteLine(MultiplyNumbers(firstNumber, secondNumber));
            }
            else if (@operator == '-')
            {
                Console.WriteLine(SubstractNumbers(firstNumber, secondNumber));
            }
            else if (@operator == '+')
            {
                Console.WriteLine(AddNumbers(firstNumber, secondNumber));
            }
        }
        static int MultiplyNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
        static int DivideNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
        static int SubstractNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        static int AddNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }


    }
}

