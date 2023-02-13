namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split();
            string[] arrTwo = Console.ReadLine().Split();

            for (int i = 0; i < arrOne.Length; i++)
            {
                for (int j = 0; j < arrTwo.Length; j++)
                {

                    if (arrTwo[j] == arrOne[i])
                    {
                        Console.Write($"{arrTwo[j]} ");
                        break;
                    }
                }
            }
        }
    }
}