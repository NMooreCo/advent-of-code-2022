using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2022
{
    public class Day1
    {
        private int _max;
        private int _current;
        private readonly List<int> _calories = new List<int>();
        
        private void UpdateMax()
        {
            if (_current <= _max)
                return;
            
            _max = _current;
        }
        
        public void GetMostCalories(string file)
        {
            var lines = File.ReadAllLines(file).ToList();
            lines.ForEach(t1 =>
            {
                if (string.IsNullOrWhiteSpace(t1))
                {
                    _calories.Add(_current);
                    _current = 0;
                }
                else
                {
                    _current += int.Parse(t1);
                }
                
                UpdateMax();
            });
            
            _calories.Add(_current);
            UpdateMax();

            Console.WriteLine($"Part1 = {_max}");
            Console.WriteLine($"Part2 = {_calories.OrderByDescending(c => c).Take(3).Sum()}");
        }
    }
}