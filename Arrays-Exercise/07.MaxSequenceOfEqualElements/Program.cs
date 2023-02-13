namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int longestStreakCount = 0;
            int currentStreakCount = 1;
            string longestStreak = string.Empty;
            string currentStreak = string.Empty;
            for (int i = 0; i < numbers.Length - 1; i++) //   2 1 1 2 3 3 2 2 2 1
            {
                if (numbers[i] == numbers[i + 1])
                {
                    if (currentStreakCount == 1)
                    {
                        currentStreak = numbers[i].ToString() + " ";
                    }
                    currentStreakCount++;
                    currentStreak = currentStreak + numbers[i] + " ";
                }
                else
                {
                    currentStreakCount = 1;
                    currentStreak = numbers[i].ToString() + " ";
                }
                if (currentStreakCount > longestStreakCount)
                {
                    longestStreak = currentStreak;
                    longestStreakCount = currentStreakCount;
                }
            }
            Console.WriteLine(longestStreak);
        }
    }
}