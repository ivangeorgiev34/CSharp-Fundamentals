using System;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] word = input.ToCharArray();
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            foreach (var letter in word)
            {
                if (letter != ' ')
                {
                    if (!dictionary.ContainsKey(letter))
                    {
                        dictionary.Add(letter, 1);
                    }
                    else
                    {
                        dictionary[letter]++;
                    }
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
