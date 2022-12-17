using System;

namespace AdventOfCodeLib.Days;

public class Day9 : Day
{
    private (int dX, int dY) ResolveDirection(string d)
    {
        switch (d)
        {
            case "U":
                return (0, 1);
            case "D":
                return (0, -1);
            case "R":
                return (1, 0);
            case "L":
                return (-1, 0);
            default:
                throw new NotImplementedException();
        }
    }

    private (int X, int Y) FollowHead((int X, int Y) tail, (int X, int Y) head)
    {
        if (Math.Abs(head.X - tail.X) < 2 && Math.Abs(head.Y - tail.Y) < 2)
            return tail;

        int dX = tail.X < head.X ? 1 : head.X < tail.X ? -1 : 0;
        int dY = tail.Y < head.Y ? 1 : head.Y < tail.Y ? -1 : 0;

        return (tail.X + dX, tail.Y + dY);
    }

    private string Solve(string input, int numberOfKnots)
    {
        (int X, int Y)[] knots = new (int X, int Y)[numberOfKnots];

        HashSet<string> tailVisits = new HashSet<string>() { "0,0" };

        foreach (var line in input.Split(Environment.NewLine))
        {
            string[] splitted = line.Split(' ');
            var dir = ResolveDirection(splitted[0]);
            var times = int.Parse(splitted[1]);

            foreach (var _ in Enumerable.Range(0, times))
            {
                knots[0] = (knots[0].X + dir.dX, knots[0].Y + dir.dY);

                for (int i = 1; i < knots.Length; i++)
                {
                    var head = knots[i - 1];
                    var tail = knots[i];
                    knots[i] = FollowHead(tail, head);

                    if (i == knots.Length - 1)
                        tailVisits.Add($"{knots[i].X},{knots[i].Y}");
                }
            }
        }

        return tailVisits.Count.ToString();
    }

    public override string SolveFirst(string input)
    {
        return Solve(input, 2);
    }

    public override string SolveSecond(string input)
    {
        return Solve(input, 10);
    }
}
