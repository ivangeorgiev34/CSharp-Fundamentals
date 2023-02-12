namespace _07.WaterOverflow
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const int WATERTANKCAPACITY = 255;
			int n = int.Parse(Console.ReadLine());
			int litersSum = 0;
			for (int i = 0; i < n; i++)
			{
				int quantity = int.Parse(Console.ReadLine());
				litersSum = litersSum + quantity;
				if (WATERTANKCAPACITY < litersSum)
				{
					Console.WriteLine($"Insufficient capacity!");
					litersSum = litersSum - quantity;
				}
			}
			Console.WriteLine(litersSum);
		}
	}
}