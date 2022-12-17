namespace AdventOfCodeLib.Tests;

public abstract class DayTestSingleBase<T> where T : Day, new()
{
    abstract protected string Input { get; }
    abstract protected string Expected1 { get; }
    abstract protected string Expected2 { get; }

    [Fact]
    public void ShouldSolveFirstStar()
    {
        Day day = new T();
        Assert.Equal(Expected1, day.SolveFirst(Input));
    }

    [Fact]
    public void ShouldSolveSecondStar()
    {
        Day day = new T();
        Assert.Equal(Expected2, day.SolveSecond(Input));
    }
}
