namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSideSum = 0;
            int rightSideSum = 0;
            for (int indexOne = 0; indexOne < array.Length; indexOne++) // 1 2 3 3
            {
                if (array.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }
                leftSideSum = 0;
                for (int leftSide = 0; leftSide < indexOne; leftSide++)
                {
                    leftSideSum = leftSideSum + array[leftSide];
                }

                rightSideSum = 0;
                for (int rightSide = array.Length - 1; indexOne < rightSide; rightSide--)
                {
                    rightSideSum = rightSideSum + array[rightSide];
                }

                if (leftSideSum == rightSideSum)
                {
                    Console.WriteLine(indexOne);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}