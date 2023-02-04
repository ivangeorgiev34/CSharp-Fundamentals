namespace _01.SumAdjacentEqualNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<double> numberInput = Console.ReadLine().Split().Select(double.Parse).ToList();
			int listCount = numberInput.Count;
			for (int i = 0; i < numberInput.Count - 1; i++)
			{
				if (numberInput[i] == numberInput[i + 1])
				{
					numberInput[i] = numberInput[i] + numberInput[i + 1];
					numberInput.RemoveAt(i + 1);
					i = -1;
				}
			}
			Console.WriteLine(string.Join(" ", numberInput));
		}
	}
}