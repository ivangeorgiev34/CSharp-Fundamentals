using System.Text;

namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            StringBuilder result = new StringBuilder();
            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result.Append(word);
                }
            }
            Console.WriteLine(result);
        }
    }
}