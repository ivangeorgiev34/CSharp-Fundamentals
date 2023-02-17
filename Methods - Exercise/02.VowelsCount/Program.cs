using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            VowelsInInput(input);
        }
        static void VowelsInInput(string input)
        {
            int counter = 0;
            string vowels = "aouei";
            for (int i = 0; i < input.Length; i++) // softuni
            {
                if (input[i] == 'a')
                {
                    counter++;
                }
                else if (input[i] == 'o')
                {
                    counter++;
                }
                else if (input[i] == 'u')
                {
                    counter++;
                }
                else if (input[i] == 'e')
                {
                    counter++;
                }
                else if (input[i] == 'i')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
