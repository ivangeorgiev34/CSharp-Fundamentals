namespace _06.TriplesOfLatinLetters
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const int STARTOFALPHABET = 97;


			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					for (int k = 0; k < n; k++)
					{
						Console.WriteLine($"{(char)(STARTOFALPHABET + i)}{(char)(STARTOFALPHABET + j)}{(char)(STARTOFALPHABET + k)}");
					}
				}
			}
		}
	}
}