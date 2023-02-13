namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int indexOne = 0; indexOne < array.Length; indexOne++) // 1 4 3 2
            {
                int currentNumber = array[indexOne];
                bool isNumberGreater = true;
                for (int indexTwo = indexOne + 1; indexTwo < array.Length; indexTwo++)
                {

                    int nextNumber = array[indexTwo];
                    if (currentNumber <= nextNumber)
                    {
                        isNumberGreater = false;
                        break;
                    }
                }
                if (isNumberGreater)
                {
                    Console.Write($"{currentNumber} ");
                }
            }
        }
    }
}