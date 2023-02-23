using System.Text;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int skip = 0;



            //  abv>1>1>2>2asdasd
            for (int i = 0; i < input.Length; i++)
            {
                char currentCharacter = input[i];
                if (currentCharacter == '>')
                {
                    skip = int.Parse(input[i + 1].ToString()) + skip;
                    sb.Append(currentCharacter);
                }
                else if (skip == 0)
                {
                    sb.Append(currentCharacter);
                }
                else
                {
                    skip--;
                }
            }
            Console.WriteLine(sb);
        }
    }
}