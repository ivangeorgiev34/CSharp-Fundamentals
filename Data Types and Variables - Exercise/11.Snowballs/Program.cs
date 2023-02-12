namespace _11.Snowballs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numberOfSnowballs = int.Parse(Console.ReadLine());
			int bestSnowball = 0;
			int snowballSnow = 0;
			int snowballTime = 0;
			int snowballQuality = 0;
			int snowballValue = 0;
			int bestsnowballSnow = 0;
			int bestsnowballTime = 0;
			int bestsnowballQuality = 0;

			for (int i = 0; i < numberOfSnowballs; i++)
			{
				snowballSnow = int.Parse(Console.ReadLine());
				snowballTime = int.Parse(Console.ReadLine());
				snowballQuality = int.Parse(Console.ReadLine());

				snowballValue = (snowballSnow / snowballTime);
				int finalValue = (int)Math.Pow(snowballValue, snowballQuality);

				if (finalValue > bestSnowball)
				{
					bestSnowball = finalValue;
					bestsnowballSnow = snowballSnow;
					bestsnowballTime = snowballTime;
					bestsnowballQuality = snowballQuality;

				}
			}
			Console.WriteLine($"{bestsnowballSnow} : {bestsnowballTime} = {bestSnowball} ({bestsnowballQuality})");
		}
	}
}