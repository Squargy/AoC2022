namespace AdventOfCodeLib.Tests;

public abstract class DayTestSingleBase<T> where T : IDay, new()
{
    abstract protected string Input1 { get; }
    virtual protected string Input2 { get; }
    abstract protected string ExpectedFirstStar { get; }
    abstract protected string ExpectedSecondStar { get; }

    [Fact]
    public void ShouldSolveFirstStar()
    {
        IDay day = new T();
        Assert.Equal(ExpectedFirstStar, day.SolveFirst(Input1));
    }

    [Fact]
    public void ShouldSolveSecondStar()
    {
        IDay day = new T();
        Assert.Equal(ExpectedSecondStar, day.SolveSecond(Input2 ?? Input1));
    }
}
