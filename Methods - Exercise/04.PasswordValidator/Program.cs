using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isPasswordBetween6And10 = CheckPasswordBetween6And10Chars(password);
            bool isPasswordOnlyOfDigitsAndLetters = CheckPasswordOnlyDigitsAndLetters(password);
            bool isPasswordHaving2Digits = CheckPasswordHaving2Digits(password);
            if (!isPasswordBetween6And10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPasswordOnlyOfDigitsAndLetters)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isPasswordHaving2Digits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isPasswordBetween6And10 && isPasswordHaving2Digits && isPasswordOnlyOfDigitsAndLetters)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool CheckPasswordBetween6And10Chars(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            return false;
        }
        static bool CheckPasswordOnlyDigitsAndLetters(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }

            }
            return true;

        }
        static bool CheckPasswordHaving2Digits(string password)
        {
            int counter = 0;
            foreach (char symbol in password)
            {
                if ("1234567890".Contains(symbol))
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                return true;
            }
            return false;
        }
    }
}
