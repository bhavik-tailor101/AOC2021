using System;
using System.Collections.Generic;

namespace AOC2021.src
{
    public class Day1
    {
        public static int Problem1(int[] input) {
            int measurementCounter = 0;

            for(int i = 1; i < input.Length; i++) {
                if (input[i - 1] < input[i]) {
                    measurementCounter++;
                } 
            }
            
            return measurementCounter; 
        }   

        public static int[] Day1Input() {
            List<int> inputList = new List<int>();
            
            string[] inputLines = System.IO.File.ReadAllLines(@"inputDay1.txt");
            foreach (string line in inputLines) {
                inputList.Add(Int32.Parse(line));
            }

            return inputList.ToArray();
        }
    }
}