namespace _09.SpiceMustFlow
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const int WORKERS_CONSUMPTION = 26;
			const int DAILYDECREMENTATION = 10;
			int startingYield = int.Parse(Console.ReadLine());
			int daysCounter = 0;
			int totalSum = 0;
			while (startingYield >= 100)
			{
				daysCounter++;
				totalSum = totalSum + startingYield - WORKERS_CONSUMPTION;
				startingYield = startingYield - DAILYDECREMENTATION;
				if (startingYield < 100)
				{
					totalSum = totalSum - WORKERS_CONSUMPTION;
				}
			}
			Console.WriteLine(daysCounter);
			Console.WriteLine(totalSum);
		}
	}
}