namespace AdventOfCodeLib.Tests;

public class Day4Tests : DayTestSingleBase<Day4>
{
    protected override string Input => @"2-4,6-8
2-3,4-5
5-7,7-9
2-8,3-7
6-6,4-6
2-6,4-8";

    protected override string ExpectedFirstStar => "2";
    protected override string ExpectedSecondStar => "4";
}
