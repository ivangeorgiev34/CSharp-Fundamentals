namespace _02.ChangeList
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();
			string command = Console.ReadLine();
			while (command != "end")
			{
				string[] array = command.Split();
				switch (array[0])
				{
					case "Delete":
						int element = int.Parse(array[1]);
						myList.RemoveAll(el => el == element);
						break;
					case "Insert":
						myList.Insert(int.Parse(array[2]), int.Parse(array[1]));
						break;
					default:
						break;
				}
				command = Console.ReadLine();
			}
			Console.WriteLine(string.Join(" ", myList));
		}
	}
}