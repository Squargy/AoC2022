namespace AdventOfCodeLib.Days;

public class Day4 : Day
{
    public Day4(DayContext context) : base(context)
    {
    }

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

    protected override string FirstSolutionLogic(string input)
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

    protected override string SecondSolutionLogic(string input)
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
