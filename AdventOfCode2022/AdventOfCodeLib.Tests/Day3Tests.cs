namespace AdventOfCodeLib.Tests;

public class Day3Tests : DayTestSingleBase<Day3>
{
    protected override string Input => @"vJrwpWtwJgWrhcsFMMfFFhFp
jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL
PmmdzqPrVvPwwTWBwg
wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn
ttgJtRGJQctTZtZT
CrZsJsPPZsGzwwsLwLmpwMDw";

    protected override string ExpectedFirstStar => "157";
    protected override string ExpectedSecondStar => "70";
}
