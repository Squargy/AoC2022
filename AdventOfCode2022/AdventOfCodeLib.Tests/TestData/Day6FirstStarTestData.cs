using System.Collections;

namespace AdventOfCodeLib.Tests.TestData;

public class Day6FirstStarTestData : IEnumerable<(string, string)>
{
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator<(string, string)> GetEnumerator()
    {
        yield return ("mjqjpqmgbljsphdztnvjfqwrcgsmlb", "7");
        yield return ("bvwbjplbgvbhsrlpgdmjqwftvncz", "5");
        yield return ("nppdvjthqldpwncqszvftbrmjlhg", "6");
        yield return ("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", "10");
        yield return ("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", "11");
    }
}
