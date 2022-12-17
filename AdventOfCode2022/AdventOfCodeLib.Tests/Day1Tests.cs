namespace AdventOfCodeLib.Tests;

public class Day1Tests : DayTestSingleBase<Day1>
{
    protected override string Input => @"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000";

    protected override string Expected1 => "24000";
    protected override string Expected2 => "45000";
}
