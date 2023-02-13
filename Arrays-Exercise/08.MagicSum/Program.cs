namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNumber = int.Parse(Console.ReadLine());
            for (int indexOne = 0; indexOne < array.Length; indexOne++)       // 1 7 6 2 19 23
            {
                for (int indexTwo = indexOne + 1; indexTwo < array.Length; indexTwo++)
                {
                    if (array[indexOne] + array[indexTwo] == magicNumber)
                    {
                        Console.WriteLine(string.Join(" ", array[indexOne], array[indexTwo]));

                    }
                }
            }
        }
    }
    }
}