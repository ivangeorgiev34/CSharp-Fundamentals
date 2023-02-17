using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleCharacters(input);
        }
        static void PrintMiddleCharacters(string input)
        {
            if (input.Length % 2 == 0) // 6
            {

                Console.WriteLine($"{input[(input.Length / 2) - 1]}{input[(input.Length / 2)]}");
            }
            else // 7       a s d f g h j
            {
                Console.WriteLine(input[(input.Length / 2)]);
            }
        }
    }
}
