namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> dictionary = new SortedDictionary<int, int>();
            int[] arr = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            foreach (int number in arr)
            {
                if (!dictionary.ContainsKey(number))
                {
                    dictionary.Add(number, 1);
                }
                else
                {
                    dictionary[number]++;
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}