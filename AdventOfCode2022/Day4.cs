using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2022
{
    public class Day4
    {
        public void FullyContainsPairs(string file)
        {
            var line = File.ReadAllLines(file).ToList();
            var pairs = 0;
            line.ForEach(l =>
            {
                var groups = l.Split(',');
                var g1 = groups[0].Split('-').Select(int.Parse).ToList();
                var g2 = groups[1].Split('-').Select(int.Parse).ToList();
                if (g1[0] >= g2[0] && g1[1] <= g2[1] ||
                    g2[0] >= g1[0] && g2[1] <= g1[1])
                {
                    pairs++;
                }
            });
            
            Console.WriteLine($"Part1 = {pairs}");
        }
        
        public void FullyContainsPairs2(string file)
        {
            var line = File.ReadAllLines(file).ToList();
            var pairs = 0;
            line.ForEach(l =>
            {
                var groups = l.Split(',');
                var g1 = groups[0].Split('-').Select(int.Parse).ToList();
                var g2 = groups[1].Split('-').Select(int.Parse).ToList();
                var dict = new Dictionary<int, int>();
                for (var i = g1[0]; i <= g1[1]; i++)
                {
                    dict.Add(i,1);
                }
                for (var i = g2[0]; i <= g2[1]; i++)
                {
                    if (!dict.ContainsKey(i)) continue;
                    pairs++;
                    break;
                }
                
            });
            
            Console.WriteLine($"Part2 = {pairs}");
        }
    }
}