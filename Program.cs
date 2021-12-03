using System;
using AOC2021.src;

namespace AOC2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testData = Day1.Day1Input();
            int[] summedList = Day1.Problem2(testData);
            Console.WriteLine(Day1.Problem1(summedList));
        }
    }
}
