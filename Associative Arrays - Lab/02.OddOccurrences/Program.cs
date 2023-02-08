namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string[] array = Console.ReadLine().Split().ToArray();
            foreach (var word in array)
            {
                string wordInLowerCase = word.ToLower();
                if (!dictionary.ContainsKey(wordInLowerCase))
                {
                    dictionary.Add(wordInLowerCase, 1);
                }
                else
                {
                    dictionary[wordInLowerCase]++;
                }
            }
            foreach (var item in dictionary)
            {
                if (!(item.Value % 2 == 0))
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}