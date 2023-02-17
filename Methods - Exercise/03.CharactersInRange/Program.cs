using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            PrintChars(firstChar, secondChar);
        }
        static void PrintChars(char firstChar, char secondChar)
        {
            int biggerChar = Math.Max(firstChar, secondChar);
            int smallerChar = Math.Min(firstChar, secondChar);
            for (int i = smallerChar + 1; i < biggerChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
