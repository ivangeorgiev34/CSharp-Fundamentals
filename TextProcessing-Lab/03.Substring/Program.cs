namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string substringToRemove = Console.ReadLine();
            string str = Console.ReadLine();
            while (str.Contains(substringToRemove))
            {
                str = str.Replace(substringToRemove, "");
            }
            Console.WriteLine(str);
        }
    }
}