namespace AdventOfCodeLib.Tests;

public class Day6Tests : DayTestEnumerableBase<Day6>
{
    protected override IEnumerable<(string, string)> FirstStarTestData => new (string, string)[]
    {
        ("mjqjpqmgbljsphdztnvjfqwrcgsmlb", "7"),
        ("bvwbjplbgvbhsrlpgdmjqwftvncz", "5"),
        ("nppdvjthqldpwncqszvftbrmjlhg", "6"),
        ("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", "10"),
        ("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", "11"),
    };

    protected override IEnumerable<(string, string)> SecondStarTestData => new (string, string)[]
    {
        ("mjqjpqmgbljsphdztnvjfqwrcgsmlb", "19"),
        ("bvwbjplbgvbhsrlpgdmjqwftvncz", "23"),
        ("nppdvjthqldpwncqszvftbrmjlhg", "23"),
        ("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", "29"),
        ("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", "26"),
    };
}
