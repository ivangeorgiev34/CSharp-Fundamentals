using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            switch (dataType)
            {
                case "int":
                    int firstInputInt = int.Parse(Console.ReadLine());
                    int secondInputInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstInputInt, secondInputInt));
                    break;
                case "char":
                    char firstInputChar = char.Parse(Console.ReadLine());
                    char secondInputChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstInputChar, secondInputChar));
                    break;
                case "string":
                    string firstInputString = Console.ReadLine();
                    string secondInputString = Console.ReadLine();
                    Console.WriteLine(GetMax(firstInputString, secondInputString));
                    break;
                default:
                    break;
            }

        }

        static int GetMax(int firstInputInt, int secondInputInt)
        {
            if (firstInputInt > secondInputInt)
            {
                return firstInputInt;
            }
            else
            {
                return secondInputInt;
            }
        }

        static char GetMax(char firstInputChar, char secondInputChar)
        {
            if (firstInputChar > secondInputChar)
            {
                return firstInputChar;
            }
            else
            {
                return secondInputChar;
            }
        }
        static string GetMax(string firstInputString, string secondInputString)
        {
            int comparison = firstInputString.CompareTo(secondInputString);
            if (comparison > 0)
            {
                return firstInputString;
            }
            else
            {
                return secondInputString;
            }
        }
    }
}
