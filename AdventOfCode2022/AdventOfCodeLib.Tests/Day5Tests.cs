namespace AdventOfCodeLib.Tests;

public class Day5Tests : DayTestSingleBase<Day5>
{
    protected override string Input1 => @"    [D]    
[N] [C]    
[Z] [M] [P]
 1   2   3 

move 1 from 2 to 1
move 3 from 1 to 3
move 2 from 2 to 1
move 1 from 1 to 2";

    protected override string ExpectedFirstStar => "CMZ";
    protected override string ExpectedSecondStar => "MCD";
}
