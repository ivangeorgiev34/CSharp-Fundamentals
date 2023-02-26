using System.Text.RegularExpressions;

namespace _03.MatchDates
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			string pattern = @"(?<day>[0-9]{2})(?<separator>[\-/\.])(?<month>[A-Z][a-z]+)\k<separator>(?<year>[0-9]{4})";

			Regex regex = new Regex(pattern);

			MatchCollection matches = regex.Matches(input);

			foreach (Match match in matches)
			{
				Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
			}
		}
	}
}