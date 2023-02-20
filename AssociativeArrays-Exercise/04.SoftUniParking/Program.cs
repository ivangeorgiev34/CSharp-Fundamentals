using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registry = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();
                switch (tokens[0])
                {
                    case "register":
                        if (registry.ContainsKey(tokens[1]))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {tokens[2]}");
                        }
                        else
                        {
                            registry.Add(tokens[1], tokens[2]);
                            Console.WriteLine($"{tokens[1]} registered {tokens[2]} successfully");
                        }
                        break;
                    case "unregister":
                        if (!registry.ContainsKey(tokens[1]))
                        {
                            Console.WriteLine($"ERROR: user {tokens[1]} not found");
                        }
                        else
                        {
                            registry.Remove(tokens[1]);
                            Console.WriteLine($"{tokens[1]} unregistered successfully");
                        }
                        break;
                    default:
                        break;
                }
            }
            foreach (var person in registry)
            {
                Console.WriteLine($"{person.Key} => {person.Value}");
            }
        }
    }
}
