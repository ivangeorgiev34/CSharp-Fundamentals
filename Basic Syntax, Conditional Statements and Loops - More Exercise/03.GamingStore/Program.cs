using System;

namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            decimal balance = decimal.Parse(Console.ReadLine());
            decimal totalMoneySpent = 0;

            string command = Console.ReadLine();
            while (command!="Game Time")
            {
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                else if (command == "OutFall 4")
                {
                    if (balance - 39.99m >= 0)
                    {
                        totalMoneySpent = totalMoneySpent + 39.99m;
                        balance = balance - 39.99m;
                        Console.WriteLine($"Bought {command}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "CS: OG")
                {
                    if (balance - 15.99m >= 0)
                    {
                        totalMoneySpent = totalMoneySpent + 15.99m;
                        balance = balance - 15.99m;
                        Console.WriteLine($"Bought {command}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "Zplinter Zell")
                {
                    if (balance - 19.99m >= 0)
                    {
                        totalMoneySpent = totalMoneySpent + 19.99m;
                        balance = balance - 19.99m;
                        Console.WriteLine($"Bought {command}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "Honored 2")
                {
                    if (balance - 59.99m >= 0)
                    {
                        totalMoneySpent = totalMoneySpent + 59.99m;
                        balance = balance - 59.99m;
                        Console.WriteLine($"Bought {command}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "RoverWatch")
                {
                    if (balance - 29.99m >= 0)
                    {
                        totalMoneySpent = totalMoneySpent + 29.99m;
                        balance = balance - 29.99m;
                        Console.WriteLine($"Bought {command}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "RoverWatch Origins Edition")
                {
                    if (balance - 39.99m >= 0)
                    {
                        totalMoneySpent = totalMoneySpent + 39.99m;
                        balance = balance - 39.99m;
                        Console.WriteLine($"Bought {command}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${totalMoneySpent:f2}. Remaining: ${balance:f2}");
        }
    }
}
