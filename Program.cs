using System;
using AOC2021.src;

namespace AOC2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testData = Day2.Day2Input();
            Console.WriteLine(Day2.RunPathWithAim(testData));
        }
    }
}
