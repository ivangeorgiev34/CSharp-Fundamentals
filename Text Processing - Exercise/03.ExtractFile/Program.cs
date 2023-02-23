
namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            int index = path.LastIndexOf('\\');
            path = path.Remove(0, index + 1);
            string[] pathComponents = path.Split('.');
            Console.WriteLine($"File name: {pathComponents[0]}");
            Console.WriteLine($"File extension: {pathComponents[1]}");
        }
    }
}