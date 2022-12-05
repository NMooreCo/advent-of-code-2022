using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2022
{
    public class Day2
    {
        
        public void RockPaperScissors(string file)
        {
            var map = new Dictionary<char, int>()
            {
                { 'A', 1 },
                { 'X', 1 },
                { 'B', 2 },
                { 'Y', 2 },
                { 'C', 3 },
                { 'Z', 3 },
            };
            
            var lines = File.ReadAllLines(file).ToList();
            var myPoints = 0;
            lines.ForEach(l =>
            {
                var s = l.Split(' ');
                var opp = map[s[0][0]];
                var me = map[s[1][0]];
                
                myPoints += me;
                
                if (opp == me)
                {
                    myPoints += 3;
                }
                else if (me - opp % 3 == 1)
                {
                    myPoints += 6;
                }
            });
            
            Console.WriteLine($"Part1 = {myPoints}");
            
            myPoints = 0;
            lines.ForEach(l =>
            {
                var s = l.Split(' ');
                var opp = map[s[0][0]];
                var me = map[s[1][0]];

                switch (me)
                {
                    case 1:
                    {
                        me = opp - 1;
                        if (me <= 0)
                            me = 3;
                        break;
                    }
                    case 2:
                        myPoints += 3;
                        me = opp;
                        break;
                    case 3:
                    {
                        myPoints += 6;
                        me = opp + 1;
                        if (me > 3)
                            me = 1;
                        break;
                    }
                }
                
                myPoints += me;
            });
            
            Console.WriteLine($"Part2 = {myPoints}");
        }
    }
}