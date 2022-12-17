using AdventOfCodeLib.Days;

namespace AdventOfCodeLib;

public static class DayFactory
{
    public static IDay Create(int dayNumber)
    {
        return (IDay)Type.GetType($"AdventOfCodeLib.Days.Day{dayNumber}")!
            .GetConstructors()
            .First()
            .Invoke(default);
    }
}
