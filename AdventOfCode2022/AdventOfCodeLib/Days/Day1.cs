namespace AdventOfCodeLib.Days;

public class Day1 : Day
{
    public Day1(DayContext context) : base(context)
    {
    }

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

    protected override string FirstSolutionLogic(string input)
    {
        return CreateElves(input)
            .Max(elf => elf.SnackBag!.Sum())
            .ToString();
    }

    protected override string SecondSolutionLogic(string input)
    {
        return CreateElves(input)
            .OrderByDescending(elf => elf.SnackBag!.Sum())
            .Take(3)
            .Sum(elf => elf.SnackBag!.Sum())
            .ToString();
    }
}
