namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] evenArray = new int[n];
            int[] oddArray = new int[n];
            for (int i = 0; i < evenArray.Length; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    evenArray[i] = numbers[0];
                    oddArray[i] = numbers[1];
                }
                else
                {
                    evenArray[i] = numbers[1];
                    oddArray[i] = numbers[0];
                }
            }
            Console.WriteLine(string.Join(" ", evenArray));
            Console.WriteLine(string.Join(" ", oddArray));
        }
    }
}