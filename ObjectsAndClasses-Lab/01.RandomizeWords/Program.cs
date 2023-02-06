using System;

namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Random number = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                int randomIndex = number.Next(0, input.Length);

                string temp = input[i];
                input[i] = input[randomIndex];
                input[randomIndex] = temp;

            }
            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
