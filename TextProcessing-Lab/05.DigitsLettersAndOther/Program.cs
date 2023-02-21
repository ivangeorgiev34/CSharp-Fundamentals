namespace _05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();
            string digits = "";
            string letters = "";
            string others = "";
            foreach (var character in arr)
            {
                if (char.IsDigit(character))
                {
                    digits = digits + character;
                }
                else if (char.IsLetter(character))
                {
                    letters = letters + character;
                }
                else
                {
                    others = others + character;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}