using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
