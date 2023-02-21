namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ").ToArray();
            string text = Console.ReadLine();
            for (int i = 0; i <= bannedWords.Length - 1; i++)
            {
                string asteriks = "";
                for (int j = 0; j < bannedWords[i].Length - 1; j++)
                {
                    asteriks = asteriks + "*";
                }
                text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
            }
            Console.WriteLine(text);
        }
    }
}