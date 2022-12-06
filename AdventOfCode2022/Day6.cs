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
                for (var i = 0; i < line.Count(); i++)
                {
                    if (charStream.Count >= numberOfChars)
                        charStream.RemoveAt(0);

                    charStream.Add(line[i]);

                    if (charStream.Distinct().Count() < numberOfChars) continue;
                    
                    Console.WriteLine($"Part 1: {i + 1}");
                    break;
                }
            }
        }
    }
}