using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;
            switch (product)
            {
                case "coffee":
                    price = 1.5;
                    break;
                case "water":
                    price = 1;
                    break;
                case "coke":
                    price = 1.4;
                    break;
                case "snacks":
                    price = 2;
                    break;
                default:
                    break;
            }
            PrintPriceOfOrder(quantity, price);
        }

        static void PrintPriceOfOrder(int quantity, double price)
        {
            Console.WriteLine($"{(quantity * price):f2}");
        }
    }
}
