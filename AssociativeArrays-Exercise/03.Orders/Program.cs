using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> orders = new Dictionary<string, double>();
            Dictionary<string, int> newOrders = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input != "buy")
            {
                string[] tokens = input.Split().ToArray();
                string name = tokens[0];
                double price = double.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);

                if (!orders.ContainsKey(name))
                {
                    orders.Add(name, price);
                    newOrders.Add(name, quantity);
                }
                else if (orders.ContainsKey(name))
                {
                    newOrders[name] = newOrders[name] + quantity;
                    if (price != orders[name])
                    {
                        orders.Remove(name);
                        orders.Add(name, price);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var name in orders)
            {
                foreach (var item in newOrders)
                {
                    if (item.Key == name.Key)
                    {
                        Console.WriteLine($"{name.Key} -> {item.Value * name.Value:f2}");
                    }

                }
            }
        }
    }
}
