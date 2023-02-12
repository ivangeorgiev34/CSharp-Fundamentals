namespace _03.Elevator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double totalPeople = double.Parse(Console.ReadLine());
			double capacity = double.Parse(Console.ReadLine());
			Console.WriteLine(Math.Ceiling(totalPeople / capacity));
		}
	}
}