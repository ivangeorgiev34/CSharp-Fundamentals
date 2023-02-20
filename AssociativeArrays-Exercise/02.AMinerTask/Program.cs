using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            while (true)
            {
                string typeOfOre = Console.ReadLine();
                if (typeOfOre == "stop")
                {
                    break;
                }
                int numberOfOres = int.Parse(Console.ReadLine());
                if (!dictionary.ContainsKey(typeOfOre))
                {
                    dictionary.Add(typeOfOre, numberOfOres);
                }
                else
                {

                    dictionary[typeOfOre] = dictionary[typeOfOre] + numberOfOres;
                }

            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
