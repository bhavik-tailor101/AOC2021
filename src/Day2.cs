using System;
using System.Collections.Generic;

namespace AOC2021.src
{
    public class Day2
    {
        public static int RunPath(string[] path)
        {
            int position = 0;
            int depth = 0;

            foreach (string instruction in path) {
                string[] instructionArr = instruction.Split(" ");
                
                switch (instructionArr[0]) {
                    case "forward":
                        position += Int32.Parse(instructionArr[1]);
                        break;
                    case "up":
                        depth -= Int32.Parse(instructionArr[1]);
                        break;
                    case "down":
                        depth += Int32.Parse(instructionArr[1]);
                        break;
                    default:
                        break;
                }
            }
            return position*depth;
        }

        public static int RunPathWithAim(string[] path)
        {
            int position = 0;
            int depth = 0;
            int aim = 0;

            foreach (string instruction in path) {
                string[] instructionArr = instruction.Split(" ");
                
                switch (instructionArr[0]) {
                    case "forward":
                        position += Int32.Parse(instructionArr[1]);
                        depth += aim * Int32.Parse(instructionArr[1]);
                        break;
                    case "up":
                        aim -= Int32.Parse(instructionArr[1]);
                        break;
                    case "down":
                        aim += Int32.Parse(instructionArr[1]);
                        break;
                    default:
                        break;
                }
            }
            return position*depth;
        }

        public static string[] Day2Input() 
        {
            List<string> inputList = new List<string>();
            
            string[] inputLines = System.IO.File.ReadAllLines(@"inputDay2.txt");
            foreach (string line in inputLines) {
                inputList.Add(line);
            }

            return inputList.ToArray();
        }
    }
}