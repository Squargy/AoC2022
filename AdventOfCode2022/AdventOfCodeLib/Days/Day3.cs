namespace AdventOfCodeLib.Days;

public class Day3 : IDay
{
    private const string Alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public string SolveFirst(string input)
    {
        var total = 0;

        foreach (var line in input.Split(Environment.NewLine))
        {
            var firstCompartment = line.Substring(0, line.Length / 2);
            var secondCompartment = line.Substring(line.Length / 2);

            var inBoth = firstCompartment.Intersect(secondCompartment).ToList();

            foreach (var item in inBoth)
            {
                total += Alpha.IndexOf(item) + 1;
            }
        }

        return total.ToString();
    }

    private List<string[]> GroupInThrees(string[] input)
    {
        List<string[]> groups = new List<string[]>();

        for (int i = 0; i < input.Length; i += 3)
        {
            groups.Add(new string[] { input.ElementAt(i), input.ElementAt(i + 1), input.ElementAt(i + 2) } );
        }

        return groups;
    }

    public string SolveSecond(string input)
    {
        var total = 0;

        foreach (var elfGroup in GroupInThrees(input.Split(Environment.NewLine)))
        {
            var inAll = elfGroup[0].Intersect(elfGroup[1]).Intersect(elfGroup[2]).ToList();

            foreach (var item in inAll)
            {
                total += Alpha.IndexOf(item) + 1;
            }
        }
        
        return total.ToString();
    }
}
