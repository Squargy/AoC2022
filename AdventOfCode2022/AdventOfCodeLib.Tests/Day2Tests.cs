﻿namespace AdventOfCodeLib.Tests;

public class Day2Tests : DayTestSingleBase<Day2>
{
    protected override string Input => @"A Y
B X
C Z";

    protected override string Expected1 => "15";
    protected override string Expected2 => "12";
}