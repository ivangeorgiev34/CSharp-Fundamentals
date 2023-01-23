﻿using System;

namespace _05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int offset = 0;
            int index = 0;
            string message = string.Empty;

            for (int i = 1; i <= input; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int lenght = number.ToString().Length;
                int digit = number % 10;

                if (digit == 0)
                {
                    message += (char)32;
                }
                else
                {
                    if (digit == 8 || digit == 9)
                    {
                        offset = ((digit - 2) * 3) + 1;
                    }
                    else
                    {
                        offset = (digit - 2) * 3;
                    }

                    index = offset + lenght - 1;
                    message += (char)(index + 97);
                }
            }

            Console.WriteLine(message);
        }
    }
}
