namespace _08.AnonymousThreat
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> input = Console.ReadLine().Split().ToList();
			string command = Console.ReadLine();
			while (command != "3:1")
			{
				string[] arrayCommand = command.Split().ToArray();
				string operation = arrayCommand[0];
				if (operation == "merge")
				{
					CommandMerge(operation, arrayCommand, input);
				}
				else if (operation == "divide")
				{

					CommandDivide(arrayCommand, input);
				}
				command = Console.ReadLine();
			}
			Console.WriteLine(string.Join(" ", input));


		}
		static void CommandMerge(string operation, string[] arrayCommand, List<string> input)
		{
			if (operation == "merge")
			{

				int startIndex = int.Parse(arrayCommand[1]);
				int endIndex = int.Parse(arrayCommand[2]);
				string mergedElements = "";
				if (startIndex < 0 && endIndex <= input.Count - 1) // only start index is wrong
				{
					startIndex = 0;
					for (int i = startIndex; i <= endIndex; i++)
					{
						mergedElements = mergedElements + input[i];
					}

				}
				else if (startIndex > 0 && endIndex > input.Count - 1)//only end index is wrong
				{
					endIndex = input.Count - 1;
					for (int i = startIndex; i <= endIndex; i++)
					{
						mergedElements = mergedElements + input[i];
					}
				}
				else if (startIndex < 0 && endIndex > input.Count - 1) //start and end indexes are wrong
				{
					startIndex = 0;
					endIndex = input.Count - 1;
					for (int i = startIndex; i <= endIndex; i++)
					{
						mergedElements = mergedElements + input[i];
					}
				}
				else
				{
					for (int i = startIndex; i <= endIndex; i++)
					{
						mergedElements = mergedElements + input[i];
					}
				}
				input.RemoveRange(startIndex, endIndex - startIndex + 1);
				input.Insert(startIndex, mergedElements);

			}
		}
		static void CommandDivide(string[] arrayCommand, List<string> input)
		{
			List<string> dividedList = new List<string>();
			int index = int.Parse(arrayCommand[1]);
			int partitions = int.Parse(arrayCommand[2]);
			string indexToDivide = (input[index]);
			input.RemoveAt(index);
			int possibleSubtrings = indexToDivide.Length / partitions;

			for (int i = 0; i < partitions; i++)
			{
				if (i == partitions - 1)
				{
					dividedList.Add(indexToDivide.Substring(i * possibleSubtrings));
				}
				else
				{
					dividedList.Add(indexToDivide.Substring(i * possibleSubtrings, possibleSubtrings));
				}

			}
			input.InsertRange(index, dividedList);
		}
	}
}