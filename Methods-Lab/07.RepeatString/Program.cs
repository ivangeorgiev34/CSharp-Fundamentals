using System;
using System.Text;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int timesRepeatedText = int.Parse(Console.ReadLine());
            string result = RepeatedString(text, timesRepeatedText);
            Console.WriteLine(result);
        }

        static string RepeatedString(string text, int timesRepeatedText)
        {
            StringBuilder repeatedString = new StringBuilder();
            for (int i = 0; i < timesRepeatedText; i++)
            {
                repeatedString.Append(text);
            }
            return repeatedString.ToString();
        }
    }
}
