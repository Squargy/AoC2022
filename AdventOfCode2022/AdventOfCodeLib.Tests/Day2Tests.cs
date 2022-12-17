namespace AdventOfCodeLib.Tests;

public class Day2Tests : DayTestSingleBase<Day2>
{
    protected override string Input1 => @"A Y
B X
C Z";

    protected override string ExpectedFirstStar => "15";
    protected override string ExpectedSecondStar => "12";
}
