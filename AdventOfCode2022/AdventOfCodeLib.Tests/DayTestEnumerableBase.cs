using AdventOfCodeLib.Tests.TestData;
using Xunit;

namespace AdventOfCodeLib.Tests;

public abstract class DayTestEnumerableBase<T, U, V> 
    where T : Day, new()
    where U : IEnumerable<(string, string)>, new()
    where V : IEnumerable<(string, string)>, new()
{
    [Fact]
    public void ShouldSolveFirstStar()
    {
        Day day = new T();
        foreach (var (input, expected) in new U())
        {
            Assert.Equal(expected, day.SolveFirst(input));
        }
    }

    [Fact]
    public void ShouldSolveSecondStar()
    {
        Day day = new T();
        foreach (var (input, expected) in new V())
        {
            Assert.Equal(expected, day.SolveSecond(input));
        }
    }
}
