﻿namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Where(w => w.Length % 2 == 0).Select(w => w).ToArray();
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}