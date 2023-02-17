using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "END")
            {

                Console.WriteLine(CheckNumberIfPalindrome(command).ToString().ToLower());
                command = Console.ReadLine();

            }
        }

        static bool CheckNumberIfPalindrome(string command)
        {
            if (command[0] == command[command.Length - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
