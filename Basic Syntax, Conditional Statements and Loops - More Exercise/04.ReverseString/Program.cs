using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            List<char> chars = str.ToCharArray().Reverse().ToList();


            Console.WriteLine(string.Join("",chars));
        }
    }
}
