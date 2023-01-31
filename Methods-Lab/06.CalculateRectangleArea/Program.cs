using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideOne = int.Parse(Console.ReadLine());
            int sideTwo = int.Parse(Console.ReadLine());

            Console.WriteLine(RectangleArea(sideOne, sideTwo));
        }

        static int RectangleArea(int sideOne, int sideTwo)
        {
            int area = sideOne * sideTwo;
            return area;
        }
    }
}
