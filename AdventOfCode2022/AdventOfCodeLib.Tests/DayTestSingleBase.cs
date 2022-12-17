namespace AdventOfCodeLib.Tests;

public abstract class DayTestSingleBase<T> where T : Day, new()
{
    abstract protected string Input1 { get; }
    virtual protected string Input2 { get; }
    abstract protected string ExpectedFirstStar { get; }
    abstract protected string ExpectedSecondStar { get; }

    [Fact]
    public void ShouldSolveFirstStar()
    {
        Day day = new T();
        Assert.Equal(ExpectedFirstStar, day.SolveFirst(Input1));
    }

    [Fact]
    public void ShouldSolveSecondStar()
    {
        Day day = new T();
        Assert.Equal(ExpectedSecondStar, day.SolveSecond(Input2 ?? Input1));
    }
}
