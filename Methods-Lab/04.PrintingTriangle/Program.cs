using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int trianglePyramidLength = int.Parse(Console.ReadLine());
            for (int i = 0; i <= trianglePyramidLength; i++)
            {
                PrintTrianglePyramid(1, i);
            }
            for (int i = trianglePyramidLength - 1; i >= 1; i--)
            {
                PrintTrianglePyramid(1, i);
            }
        }

        static void PrintTrianglePyramid(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");

            }
            Console.WriteLine();
        }
    }
}
