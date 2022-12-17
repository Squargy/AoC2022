namespace AdventOfCodeLib.Days;

public class Day1 : IDay
{
    private IEnumerable<Elf> CreateElves(string input)
    {
        var elves = new List<Elf>();
        foreach (var snackbag in input.Split("\r\n\r\n"))
        {
            var elf = new Elf();
            elf.SnackBag = snackbag!.Split("\r\n").Select(int.Parse);
            elves.Add(elf);
        }
        return elves;
    }

    public string SolveFirst(string input)
    {
        return CreateElves(input)
            .Max(elf => elf.SnackBag!.Sum())
            .ToString();
    }

    public string SolveSecond(string input)
    {
        return CreateElves(input)
            .OrderByDescending(elf => elf.SnackBag!.Sum())
            .Take(3)
            .Sum(elf => elf.SnackBag!.Sum())
            .ToString();
    }
}
