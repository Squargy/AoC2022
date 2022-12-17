using Xunit;

namespace AdventOfCodeLib.Tests;

public abstract class DayTestEnumerableBase<T> 
    where T : Day, new()
{
    abstract protected IEnumerable<(string, string)> FirstStarTestData { get; }
    abstract protected IEnumerable<(string, string)> SecondStarTestData { get; }

    [Fact]
    public void ShouldSolveFirstStar()
    {
        Day day = new T();
        foreach (var (input, expected) in FirstStarTestData)
        {
            Assert.Equal(expected, day.SolveFirst(input));
        }
    }

    [Fact]
    public void ShouldSolveSecondStar()
    {
        Day day = new T();
        foreach (var (input, expected) in SecondStarTestData)
        {
            Assert.Equal(expected, day.SolveSecond(input));
        }
    }
}
