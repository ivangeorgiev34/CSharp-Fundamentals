using System;

namespace _07.TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int ticket = 0;
            switch (input)
            {
                case "Weekday":
                    if (age >= 0 && age <= 18)
                    {
                        ticket = 12;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        ticket = 18;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        ticket = 12;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Weekend":
                    if (age >= 0 && age <= 18)
                    {
                        ticket = 15;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        ticket = 20;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        ticket = 15;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        ticket = 5;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        ticket = 12;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        ticket = 10;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;

            }
            if (ticket > 0)
            {
                Console.WriteLine($"{ticket}$");
            }
        }
    }
}
