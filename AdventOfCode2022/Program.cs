using System;
using System.Diagnostics;
using System.IO;

namespace AdventOfCode2022
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var d1 = new Day1();
            Console.WriteLine($"Day 1 Example:");
            d1.GetMostCalories("ReferenceFiles/Day1Example.txt");
            Console.WriteLine($"Day 1:");
            d1.GetMostCalories("ReferenceFiles/Day1.txt");
            
            var d2 = new Day2();
            Console.WriteLine($"Day 2 Example:");
            d2.RockPaperScissors("ReferenceFiles/Day2Example.txt");
            Console.WriteLine($"Day 2:");
            d2.RockPaperScissors("ReferenceFiles/Day2.txt");

            var d3 = new Day3();
            Console.WriteLine($"Day 3 Example:");
            d3.GetPriority("ReferenceFiles/Day3Example.txt");
            d3.GetSecondPriority("ReferenceFiles/Day3Example.txt");
            Console.WriteLine($"Day 3:");
            d3.GetPriority("ReferenceFiles/Day3.txt");
            d3.GetSecondPriority("ReferenceFiles/Day3.txt");

            var d4 = new Day4();
            Console.WriteLine($"Day 4 Example:");
            d4.FullyContainsPairs("ReferenceFiles/Day4Example.txt");
            d4.FullyContainsPairs2("ReferenceFiles/Day4Example.txt");
            Console.WriteLine($"Day 4:");
            d4.FullyContainsPairs("ReferenceFiles/Day4.txt");
            d4.FullyContainsPairs2("ReferenceFiles/Day4.txt");

            var d5 = new Day5();
            Console.WriteLine($"Day 5 Example:");
            d5.DetermineStacks("ReferenceFiles/Day5Example.txt");
            d5.DetermineStacks2("ReferenceFiles/Day5Example.txt");
            Console.WriteLine($"Day 5:");
            d5.DetermineStacks("ReferenceFiles/Day5.txt");
            d5.DetermineStacks2("ReferenceFiles/Day5.txt");
            
            var d6 = new Day6();
            Console.WriteLine($"Day 6 Example:");
            d6.FindStartOfPacket("ReferenceFiles/Day6Example.txt", 4);
            d6.FindStartOfPacket("ReferenceFiles/Day6Example.txt", 14);
            Console.WriteLine($"Day 6:");
            d6.FindStartOfPacket("ReferenceFiles/Day6.txt", 4);
            d6.FindStartOfPacket("ReferenceFiles/Day6.txt", 14);
        }
    }
}