namespace AdventOfCodeLib.Days;

public class Day4 : IDay
{
    private List<Tuple<string, string>> GetAssignmentList(string input)
    {
        return input.Split(Environment.NewLine)
            .Select(line => line.Split(','))
            .Select(s => new Tuple<string, string>(s.First(), s.Last()))
            .ToList();
    }

    private IEnumerable<int> GetAssignmentRange(string rangeAsString)
    {
        var range = rangeAsString.Split('-').Select(i => int.Parse(i));
        return Enumerable.Range(range.First(), range.Last() - range.First() + 1);
    }

    public string SolveFirst(string input)
    {
        int total = 0;

        foreach (var assignmentPair in GetAssignmentList(input))
        {
            var firstRange = GetAssignmentRange(assignmentPair.Item1);
            var secondRange = GetAssignmentRange(assignmentPair.Item2);

            if (firstRange.All(r => secondRange.Any(s => s == r)) || secondRange.All(r => firstRange.Any(f => f == r)))
                total++;
        }

        return total.ToString();
    }

    public string SolveSecond(string input)
    {
        int total = 0;

        foreach (var assignmentPair in GetAssignmentList(input))
        {
            var firstRange = GetAssignmentRange(assignmentPair.Item1);
            var secondRange = GetAssignmentRange(assignmentPair.Item2);

            if (firstRange.Intersect(secondRange).Count() > 0)
                total++;
        }

        return total.ToString();
    }
}
