using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                string operation = Console.ReadLine();
                double firstNumber = int.Parse(Console.ReadLine());
                double secondNumber = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case "add":
                        AddNumbers(firstNumber, secondNumber);
                        break;
                    case "multiply":
                        MultiplyNumbers(firstNumber, secondNumber);
                        break;
                    case "substract":
                        SubstractNumbers(firstNumber, secondNumber);
                        break;
                    case "divide":
                        DivideNumbers(firstNumber, secondNumber);
                        break;
                    default:
                        break;
                }
            }
            static void AddNumbers(double firstNumber, double secondNumber)
            {
                double result = firstNumber + secondNumber;
                Console.WriteLine(result);
            }
            static void MultiplyNumbers(double firstNumber, double secondNumber)
            {
                double result = firstNumber * secondNumber;
                Console.WriteLine(result);
            }
            static void SubstractNumbers(double firstNumber, double secondNumber)
            {
                double result = firstNumber - secondNumber;
                Console.WriteLine(result);
            }
            static void DivideNumbers(double firstNumber, double secondNumber)
            {
                double result = firstNumber / secondNumber;
                Console.WriteLine(result);
            }
        }
    }
}
