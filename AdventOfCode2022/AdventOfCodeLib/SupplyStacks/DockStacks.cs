using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCodeLib.SupplyStacks;

internal class DockStacks
{
    Dictionary<int, Stack<char>> _dockStacks = new Dictionary<int, Stack<char>>();

    public DockStacks(string[] stackInput)
    {
        Regex wsReg = new Regex(@"\s+");

        var numberOfStacks = wsReg.Split(stackInput.Last()).Where(s => !string.IsNullOrWhiteSpace(s)).Select(i => int.Parse(i));
        
        foreach (var i in numberOfStacks)
        {
            _dockStacks.Add(i, new Stack<char>());
        }

        foreach (var line in stackInput.Reverse().Skip(1)) 
        {
            for (int i = 0; i < numberOfStacks.Max(); i++)
            {
                var c = line[i * 4 + 1];
                if (char.IsLetter(c))
                    _dockStacks[i + 1].Push(c);
            }
        }
    }

    internal string Message()
    {
        return new string(_dockStacks.Values.Select(i => i.Peek()).ToArray());
    }

    internal void Move1(int number, int from, int to)
    {
        var fromStack = _dockStacks[from];
        var toStack = _dockStacks[to];

        Enumerable.Range(0, number).ToList().ForEach(_ => toStack.Push(fromStack.Pop()));
    }

    internal void Move2(int number, int from, int to)
    {
        var fromStack = _dockStacks[from];
        var toStack = _dockStacks[to];

        Enumerable.Range(0, number).ToList().Select(_ => fromStack.Pop()).Reverse().ToList().ForEach(c => toStack.Push(c));
    }
}
