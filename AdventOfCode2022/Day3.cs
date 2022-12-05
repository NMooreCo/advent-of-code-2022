using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2022
{
    public class Day3
    {
        private readonly Dictionary<char, int> _dict = new Dictionary<char, int>();
        public Day3()
        {
            var c = 'a';
            for (var i = 0; i < 26; i++)
            {
                _dict.Add(c, i + 1);
                c = (char)(c + 1);
            }
            c = 'A';
            for (var i = 26; i < 52; i++)
            {
                _dict.Add(c, i + 1);
                c = (char)(c + 1);
            }
        }
        
        public void GetPriority(string file)
        {
            var line = File.ReadAllLines(file).ToList();
            var priority = 0;
            line.Distinct().ToList().ForEach(l =>
            {
                var length = l.Length / 2;
                var l1 = l.Substring(0, length).Distinct();
                var l2 = l.Substring(length,length);

                l1.ToList().ForEach(c1 =>
                {
                    if (l2.Contains(c1))
                    {
                        priority += _dict[c1];
                    }
                });
            });
            
            Console.WriteLine($"Part1 = {priority}");
        }

        public void GetSecondPriority(string file)
        {
            var line = File.ReadAllLines(file).ToList();
            var priority = 0;
            for (var i = 0; i < line.Count; i+=3)
            {
                var l1 = line[i].Distinct();
                var l2 = line[i + 1];
                var l3 = line[i + 2];
                l1.ToList().ForEach(c1 =>
                {
                    if (l2.Contains(c1) && l3.Contains(c1))
                    {
                        priority += _dict[c1];
                    }
                });
            }
            
            Console.WriteLine($"Part2 = {priority}");
        }
    }
}