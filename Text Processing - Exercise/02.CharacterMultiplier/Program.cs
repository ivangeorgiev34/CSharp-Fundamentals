
namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            int sum = 0;
            string longer = "";
            string smaller = "";

            if (strings[0].Length > strings[1].Length)
            {
                smaller = strings[1];
                longer = strings[0];
            }
            else
            {
                smaller = strings[0];
                longer = strings[1];
            }



            for (int i = 0; i < smaller.Length; i++) // Peter George
            {

                sum = sum + smaller[i] * longer[i];
            }


            for (int i = smaller.Length; i < longer.Length; i++)
            {
                sum = sum + longer[i];
            }
            Console.WriteLine(sum);
        }
    }
}