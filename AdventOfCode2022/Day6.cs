using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2022
{
    public class Day6
    {
        public void FindStartOfPacket(string file, int numberOfChars)
        {
            var lines = File.ReadAllLines(file);
            foreach (var line in lines)
            {
                var charStream = new List<char>(); 
                var count = 0;
                foreach (var c in line)
                {
                    count++;
                    if (charStream.Count >= numberOfChars)
                    {
                        charStream.RemoveAt(0);
                    }
                    
                    charStream.Add(c);

                    if (charStream.Distinct().Count() < numberOfChars) continue;
                    
                    Console.WriteLine($"Part 1: {count}");
                    break;
                }
            }
        }
    }
}