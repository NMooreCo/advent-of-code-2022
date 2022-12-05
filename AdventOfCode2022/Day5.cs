using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2022
{
    public class Day5
    {
        private Dictionary<int, List<char>> _stacks = new Dictionary<int, List<char>>();

        private void AddToDict(int column, char c)
        {
            var realC = column + 1;
            if (!_stacks.ContainsKey(realC))
            {
                _stacks.Add(realC, new List<char>());
            }
            _stacks[realC].Add(c);
        }

        private int SetupStacks(string[] stackInfo)
        {
            var counter = 0;
            foreach (var line in stackInfo)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    counter--;
                    break;
                }

                counter++;
            }

            var numberOfStacks = stackInfo[counter].Split(new[] { "   " }, StringSplitOptions.None);

            for (var j = 0; j < counter; j++)
            {
                var columnCounter = 0;
                for (var i = 0; i < numberOfStacks.Length * 4; i += 4)
                {
                    var data = stackInfo[j][i + 1];
                    if (data == ' ')
                    {
                        columnCounter++;
                        continue;
                    }
                    
                    AddToDict(columnCounter, data);
                    columnCounter++;
                }
            }

            return counter;
        }
        
        public void DetermineStacks(string file)
        {
            _stacks.Clear();
            var lines = File.ReadAllLines(file);
            var counter = SetupStacks(lines);

            foreach (var line in lines.Skip(counter + 2))
            {
                var splits = line.Split(' ');
                var numToMove = splits[1];
                for (var i = 0; i < int.Parse(numToMove); i++)
                {
                    var from = int.Parse(splits[3]);
                    var to = int.Parse(splits[5]);
                    if (!_stacks[from].Any())
                    {
                        continue;
                    }
                    _stacks[to].Insert(0, _stacks[from].First());
                    _stacks[from].RemoveAt(0);
                }
            }

            var topStacks = string.Empty;
            for(var i =1;i<=_stacks.Count;i++)
            {
                topStacks += _stacks[i].First().ToString();
            }
            
            Console.WriteLine($"Part1: {topStacks}");
        }
        
        public void DetermineStacks2(string file)
        {
            _stacks.Clear();
            var lines = File.ReadAllLines(file);
            var counter = SetupStacks(lines);

            foreach (var line in lines.Skip(counter + 2))
            {
                var splits = line.Split(' ');
                var numToMove = int.Parse(splits[1]);
                for (var i = 0; i < numToMove; i++)
                {
                    var from = int.Parse(splits[3]);
                    var to = int.Parse(splits[5]);
                    if (!_stacks[from].Any())
                    {
                        continue;
                    }
                    _stacks[to].Insert(0, _stacks[from][numToMove-1-i]);
                    _stacks[from].RemoveAt(numToMove-1-i);
                }
            }

            var topStacks = string.Empty;
            for(var i =1;i<=_stacks.Count;i++)
            {
                topStacks += _stacks[i].First().ToString();
            }
            
            Console.WriteLine($"Part1: {topStacks}");
        }
    }
}