using System;

namespace _07.ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string arrow = Console.ReadLine();
            string result = firstName + arrow + secondName;
            Console.WriteLine(result);
        }
    }
}
