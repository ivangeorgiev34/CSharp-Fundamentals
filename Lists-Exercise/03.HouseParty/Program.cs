namespace _03.HouseParty
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//            On the next lines, you are going to receive some of the following:  "{name} is going!"
			//•	You have to add the person if they are not on the guestlist already.
			//•	If the person is on the list print the following to the console: "{name} is already in the list!"

			//"{name} is not going!"
			//•	You have to remove the person if they are on the list. 
			//•	If not, print out: "{name} is not in the list!"

			//Finally, print all of the guests, each on a new line.
			List<string> listOfNames = new List<string>();
			int numberOfCommands = int.Parse(Console.ReadLine());
			for (int i = 0; i < numberOfCommands; i++)
			{

				string[] command = Console.ReadLine().Split().ToArray();
				string name = command[0];
				if (command.Length == 3) // is going command
				{
					if (!listOfNames.Contains(name))
					{
						listOfNames.Add(command[0]);
					}
					else
					{
						Console.WriteLine($"{name} is already in the list!");
					}
				}
				else if (command.Length == 4)
				{
					if (listOfNames.Contains(name))
					{
						listOfNames.Remove(command[0]);
					}
					else
					{
						Console.WriteLine($"{name} is not in the list!");
					}
				}
			}
			for (int i = 0; i < listOfNames.Count; i++)
			{
				Console.WriteLine(listOfNames[i]);
			}
		}
	}
}