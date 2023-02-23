using System.Text;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int smallNumber = int.Parse(Console.ReadLine());
            StringBuilder str = new StringBuilder();
            int remainder = 0;
            if (smallNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = bigNumber.Length - 1; i >= 0; i--) // 28 2
            {
                int product = smallNumber * int.Parse(bigNumber[i].ToString()) + remainder; // 8 * 2 = 16
                str.Append(product % 10);
                remainder = product / 10;
            }

            if (remainder != 0)
            {
                str.Append(remainder);
            }
            StringBuilder newStr = new StringBuilder(); // 19998 -> 89991
            for (int i = str.Length - 1; i >= 0; i--)
            {
                newStr.Append(str[i]);
            }
            Console.WriteLine(newStr);
        }
    }
}