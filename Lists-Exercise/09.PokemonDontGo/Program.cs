namespace _09.PokemonDontGo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();
			int sum = 0;
			while (myList.Count > 0)
			{
				int currentIndex = int.Parse(Console.ReadLine());
				if (myList.Count <= 0)
				{
					break;
				}
				if (currentIndex < 0) // if current index is less than 0
				{
					int valueOfRemovedElement = myList[0];
					myList.RemoveAt(0);
					int lastElement = myList[myList.Count - 1];
					myList.Insert(0, lastElement);
					sum = sum + valueOfRemovedElement;

					for (int i = 0; i < myList.Count; i++)
					{
						if (valueOfRemovedElement >= myList[i])
						{
							myList[i] = myList[i] + valueOfRemovedElement;

						}
						else if (valueOfRemovedElement < myList[i])
						{
							myList[i] = myList[i] - valueOfRemovedElement;
						}
					}
				}
				else if (currentIndex > myList.Count - 1) // if current index is more than last index 
				{
					int valueOfRemovedElement = myList[myList.Count - 1];
					myList.RemoveAt(myList.Count - 1);
					int firstElement = myList[0];
					myList.Insert(myList.Count, firstElement);
					sum = sum + valueOfRemovedElement;

					for (int i = 0; i < myList.Count; i++)
					{
						if (valueOfRemovedElement >= myList[i])
						{
							myList[i] = myList[i] + valueOfRemovedElement;

						}
						else if (valueOfRemovedElement < myList[i])
						{
							myList[i] = myList[i] - valueOfRemovedElement;
						}
					}
				}
				else  // if current index is in range of the list
				{
					int valueOfRemovedElement = myList[currentIndex];
					myList.RemoveAt(currentIndex);
					sum = sum + valueOfRemovedElement;

					for (int i = 0; i < myList.Count; i++)
					{
						if (valueOfRemovedElement >= myList[i])
						{
							myList[i] = myList[i] + valueOfRemovedElement;

						}
						else if (valueOfRemovedElement < myList[i])
						{
							myList[i] = myList[i] - valueOfRemovedElement;
						}
					}
				}
			}
			Console.WriteLine(sum);

		}
		static void IncreaseOrDecreaseValues1(List<int> myList, int valueOfRemovedElement)
		{
			for (int i = 0; i < myList.Count; i++)
			{
				if (myList[0] >= myList[i])
				{
					myList[i] = myList[i] + valueOfRemovedElement;

				}
				else if (myList[0] <= myList[i])
				{
					myList[i] = myList[i] - valueOfRemovedElement;
				}
			}
		}

		static void IncreaseOrDecreaseValues2(List<int> myList, int valueOfRemovedElement)
		{
			for (int i = 0; i < myList.Count; i++)
			{
				if (myList[myList.Count - 1] >= myList[i])
				{
					myList[i] = myList[i] + valueOfRemovedElement;

				}
				else if (myList[myList.Count - 1] <= myList[i])
				{
					myList[i] = myList[i] - valueOfRemovedElement;
				}
			}
		}

		static void IncreaseOrDecreaseValues3(List<int> myList, int valueOfRemovedElement, int currentIndex)
		{
			for (int i = 0; i < myList.Count; i++)
			{
				if (myList[currentIndex] >= myList[i])
				{
					myList[i] = myList[i] + valueOfRemovedElement;

				}
				else if (myList[currentIndex] <= myList[i])
				{
					myList[i] = myList[i] - valueOfRemovedElement;
				}
			}
		}
	}
}