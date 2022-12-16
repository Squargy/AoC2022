using AdventOfCodeLib.Days;

namespace AdventOfCodeLib;

public static class DayFactory
{
    public static Day Create(int dayNumber, DayContext context)
    {
        return (Day)Type.GetType($"AdventOfCodeLib.Days.Day{dayNumber}")!
            .GetConstructors()
            .First()
            .Invoke(new object[] { context });
    }

    public static Day Create(int dayNumber)
    {
        return (Day)Type.GetType($"AdventOfCodeLib.Days.Day{dayNumber}")!
            .GetConstructors()
            .First()
            .Invoke(default);
    }
}
