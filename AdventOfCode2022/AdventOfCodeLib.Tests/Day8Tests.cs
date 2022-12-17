namespace AdventOfCodeLib.Tests
{
    public class Day8Tests : DayTestSingleBase<Day7>
    {
        protected override string Input => @"30373
25512
65332
33549
35390";

        protected override string ExpectedFirstStar => "21";

        protected override string ExpectedSecondStar => throw new NotImplementedException();
    }
}
