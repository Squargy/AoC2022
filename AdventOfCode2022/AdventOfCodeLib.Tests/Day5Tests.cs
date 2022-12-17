namespace AdventOfCodeLib.Tests;

public class Day5Tests : DayTestSingleBase<Day5>
{
    protected override string Input => @"    [D]    
[N] [C]    
[Z] [M] [P]
 1   2   3 

move 1 from 2 to 1
move 3 from 1 to 3
move 2 from 2 to 1
move 1 from 1 to 2";

    protected override string Expected1 => "CMZ";
    protected override string Expected2 => "MCD";
}
