namespace AdventOfCodeLib.Tests;

public class Day1Tests : DayTestSingleBase<Day1>
{
    protected override string Input1 => @"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000";

    protected override string ExpectedFirstStar => "24000";
    protected override string ExpectedSecondStar => "45000";
}
