namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                list.Add(line);
            }
            foreach (var word in list)
            {
                string reversedWord = string.Empty;
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversedWord = reversedWord + word[i];
                }
                Console.WriteLine($"{word} = {reversedWord}");
            }
        }
    }
}