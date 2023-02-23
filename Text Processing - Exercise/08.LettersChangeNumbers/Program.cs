namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            double sum = 0;
            foreach (string item in items)
            {
                char firstLetter = item[0];
                char lastLetter = item[item.Length - 1];
                double number = double.Parse(item.Substring(1, item.Length - 2));

                if (firstLetter >= 65 && firstLetter <= 90) //  IsUpper
                {
                    number = number / (firstLetter - 64);
                }
                else//  IsLower
                {
                    number = number * (firstLetter - 96);
                }

                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    number = number - (lastLetter - 64);
                }
                else
                {
                    number = number + (lastLetter - 96);
                }
                sum = sum + number;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}