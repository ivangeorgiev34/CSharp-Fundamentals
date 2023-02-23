using System.Text;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                int encryptedtCharNumber = input[i] + 3;
                char encryptedChar = (char)encryptedtCharNumber;
                stringBuilder.Append(encryptedChar);
            }
            Console.WriteLine(stringBuilder);
        }
    }
}