namespace _07.ListManipulationAdvanced
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			string[] command = Console.ReadLine().Split().ToArray();
			bool areChangesMade = false;
			while (command[0] != "end")
			{
				switch (command[0])
				{
					case "Add":
						numbers.Add(int.Parse(command[1]));
						areChangesMade = true;
						break;
					case "Remove":
						numbers.Remove(int.Parse(command[1]));
						areChangesMade = true;
						break;
					case "RemoveAt":
						numbers.RemoveAt(int.Parse(command[1]));
						areChangesMade = true;
						break;
					case "Insert":
						numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
						areChangesMade = true;
						break;
					case "Contains":
						if (numbers.Contains(int.Parse(command[1])))
						{
							Console.WriteLine("Yes");
						}
						else
						{
							Console.WriteLine("No such number");
						}
						break;
					case "PrintEven":
						for (int i = 0; i < numbers.Count; i++)
						{
							if (numbers[i] % 2 == 0)
							{
								Console.Write($"{numbers[i]} ");
							}
						}
						break;
					case "PrintOdd":
						for (int i = 0; i < numbers.Count; i++)
						{
							if (numbers[i] % 2 != 0)
							{
								Console.Write($"{numbers[i]} ");
							}

						}
						Console.WriteLine();
						break;
					case "GetSum":
						int sum = 0;
						for (int i = 0; i < numbers.Count; i++)
						{
							sum = sum + numbers[i];
						}
						Console.WriteLine(sum);
						break;
					case "Filter":
						switch (command[1])
						{
							case "<":
								for (int i = 0; i < numbers.Count; i++)
								{
									if (numbers[i] < int.Parse(command[2]))
									{
										Console.Write($"{numbers[i]} ");
									}
								}
								Console.WriteLine();
								break;
							case ">":
								for (int i = 0; i < numbers.Count; i++)
								{
									if (numbers[i] > int.Parse(command[2]))
									{
										Console.Write($"{numbers[i]} ");
									}
								}
								Console.WriteLine();
								break;
							case ">=":
								for (int i = 0; i < numbers.Count; i++)
								{
									if (numbers[i] >= int.Parse(command[2]))
									{
										Console.Write($"{numbers[i]} ");
									}
								}
								Console.WriteLine();
								break;
							case "<=":
								for (int i = 0; i < numbers.Count; i++)
								{
									if (numbers[i] <= int.Parse(command[2]))
									{
										Console.Write($"{numbers[i]} ");
									}
								}
								Console.WriteLine();
								break;
							default:
								break;
						}
						break;
					default:
						break;
				}
				command = Console.ReadLine().Split().ToArray();
			}
			if (areChangesMade)
			{
				Console.WriteLine(string.Join(" ", numbers));
			}
		}
	}
}