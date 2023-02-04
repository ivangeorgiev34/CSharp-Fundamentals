namespace _03.MergingLists
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> mergedList = new List<int>();
			int biggerList = Math.Max(firstList.Count, secondList.Count);
			for (int i = 0; i < biggerList; i++)
			{
				if (firstList.Count > i)
				{
					mergedList.Add(firstList[i]);
				}
				if (secondList.Count > i)
				{
					mergedList.Add(secondList[i]);
				}
			}
			Console.WriteLine(string.Join(" ", mergedList));
		}
	}
}