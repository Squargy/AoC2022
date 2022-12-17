﻿namespace AdventOfCodeLib.Tests;

public class Day9Tests : DayTestSingleBase<Day9>
{
    protected override string Input1 => @"R 4
U 4
L 3
D 1
R 4
D 1
L 5
R 2";

    protected override string Input2 => @"R 5
U 8
L 8
D 3
R 17
D 10
L 25
U 20";

    protected override string ExpectedFirstStar => "13";

    protected override string ExpectedSecondStar => "36";
}
