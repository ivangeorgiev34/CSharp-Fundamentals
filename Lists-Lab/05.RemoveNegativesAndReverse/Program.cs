namespace _05.RemoveNegativesAndReverse
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			int listCount = listOfNumbers.Count;
			for (int i = 0; i < listOfNumbers.Count; i++) // 7 -2 -10 1
			{
				if (listOfNumbers[i] < 0)
				{
					listOfNumbers.RemoveAt(i);
					i--;
				}
			}
			listOfNumbers.Reverse();
			if (listOfNumbers.Count == 0)
			{
				Console.WriteLine("empty");
			}
			else
			{
				Console.WriteLine(string.Join(" ", listOfNumbers));
			}
		}
	}
}