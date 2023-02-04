namespace _04.ListOfProducts
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> list = new List<string>();
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++) 
			{
				string product = Console.ReadLine();
				list.Add(product);
			}
			list.Sort();
			for (int i = 0; i < list.Count; i++)
			{
				Console.WriteLine($"{i + 1}.{list[i]}");
			}
		}
	}
}