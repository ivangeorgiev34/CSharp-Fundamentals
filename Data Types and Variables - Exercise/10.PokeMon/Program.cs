namespace _10.PokeMon
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int m = int.Parse(Console.ReadLine());
			int y = int.Parse(Console.ReadLine());
			int pokedTargets = 0;
			int originalValueOfN = n;
			while (n >= m)
			{
				n = n - m;
				pokedTargets++;
				if (n * 2 == originalValueOfN && y > 0)
				{
					n = n / y;
				}
			}

			Console.WriteLine(n);
			Console.WriteLine(pokedTargets);
		}
	}
}